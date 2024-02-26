using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Hashing.users
{
    [XmlInclude(typeof(User))]
    public class Admin : User
    {
        //public List<User> Users { get; set; } = new List<User>();
        
        public Admin() { } // Konstruktor

        public Admin(string username, string password) : base(username, password) { }

        // Metoda pro změnu hesla uživatele
        public void ChangeUserPassword(User user, string newPassword)
        {
            user.PasswordHash = CalculateHash(newPassword);
        }
    }
}
