using Hashing.data;
using Hashing.users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hashing
{
    public partial class Form1 : Form
    {
        private Admin admin = new Admin("Admin", "Admin");
        private User user1 = new User("Pepa", "Pepa");
        private User user2 = new User("Franta", "Franta");
        private User user3 = new User("Jana", "Jana");
        private XmlDataHandler xmlDat = new XmlDataHandler();
        public Form1()
        {
            XmlDataHandler.users.Add(admin);
            XmlDataHandler.users.Add(user1);
            XmlDataHandler.users.Add(user2);
            XmlDataHandler.users.Add(user3);

            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text;
            string password = textBoxPasswd.Text;

            if (admin.Username == username && admin.VerifyPassword(password))
            {
                MessageBox.Show("Login successful!");
                Form2 userManagementForm = new Form2();
                userManagementForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
