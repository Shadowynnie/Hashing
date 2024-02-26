using Hashing.users;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Hashing.data
{
    public class XmlDataHandler
    {
        public static List<User> users = new List<User>();
        private static string filenameXML = "users.xml";
        public XmlDataHandler() { }
        public void SaveXML()
        {
            try
            {
                // Pokud soubor neexistuje, vytvoříme nový prázdný XML soubor
                if (!File.Exists(filenameXML))
                {
                    using (StreamWriter sw = File.CreateText(filenameXML))
                    {
                        
                    }
                }

                //XmlSerializer xmlseri = new XmlSerializer(users.GetType());
                XmlSerializer xmlseri = new XmlSerializer(typeof(List<User>), new Type[] { typeof(Admin) });

                using (StreamWriter sw = new StreamWriter(filenameXML))
                {
                    xmlseri.Serialize(sw, users);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save XML.\n" + ex.ToString());
                return;
            }
        }

        public void LoadXML()
        {
            try
            {
                XmlSerializer xmlDeseri = new XmlSerializer(users.GetType());
                using (StreamReader sr = new StreamReader(filenameXML))
                {
                    users = (List<User>)xmlDeseri.Deserialize(sr); //Vraci obecny objekt
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }
    }
}
