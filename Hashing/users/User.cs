using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Hashing.users
{
    [XmlInclude(typeof(User))]
    public class User
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }

        public User() { } // Defaultní konstruktor pro serializaci

        public User(string username, string password)
        {
            Username = username;
            PasswordHash = CalculateHash(password);
        }

        // Metoda pro kontrolu hesla
        public bool VerifyPassword(string password)
        {
            return PasswordHash == CalculateHash(password);
        }

        // Metoda pro výpočet hash hodnoty hesla
        public string CalculateHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                return Convert.ToBase64String(hashedBytes);
            }
        }
        public override string ToString()
        {
            return string.Format("{0}-{1}", Username, PasswordHash);
        }
    }
}
