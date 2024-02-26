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
    public partial class Form2 : Form
    {
        XmlDataHandler dh = new XmlDataHandler();
        Admin admin = new Admin();
        public Form2()
        {
            dh.LoadXML();
            
            InitializeComponent();
            UpdateUserList();
        }

        private void UpdateUserList()
        {
            userList.Items.Clear();
            foreach (User user in XmlDataHandler.users)
            {
                userList.Items.Add(user);
                
            }
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            newPasswordTextBox.Enabled = true;
            NewPassConfirmBtn.Enabled = true;
        }

        private void SaveXmlBtn_Click(object sender, EventArgs e)
        {
            dh.SaveXML();
        }

        private void NewPassConfirmBtn_Click(object sender, EventArgs e)
        {
            string[] parts = userList.SelectedItem?.ToString().Split('-');
            string selectedUsername = parts[0];
            if (!string.IsNullOrEmpty(selectedUsername))
            {
                User selectedUser = XmlDataHandler.users.Find(u => u.Username == selectedUsername);
                if (selectedUser != null)
                {
                    string newPassword = newPasswordTextBox.Text;
                    admin.ChangeUserPassword(selectedUser, newPassword);
                    StatusLabel.Text = "Password changed successfully.";
                    UpdateUserList();
                }
                else
                {
                    StatusLabel.Text = "User not found.";
                }
            }
            else
            {
                MessageBox.Show("Please select a user.");
            }
            newPasswordTextBox.Clear();
            newPasswordTextBox.Enabled = false;
            NewPassConfirmBtn.Enabled = false;
            
        }
        
    }
}
