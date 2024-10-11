using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _20241008
{
    public partial class RoomListForm : Form
    {
        public int userId;

        public RoomListForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void RoomListForm_Load(object sender, EventArgs e)
        {
            try
            {
                GlobalProcedures g_proc = new();
                g_proc.fncDatabaseConnection();
                MySqlDataReader reader = g_proc.fncGetUserById(userId);
                reader.Read();
                txtFirstname.Text = reader.GetString("firstname");
                txtLastname.Text = reader.GetString("lastname");
                txtUsername.Text = reader.GetString("username");
                txtEmail.Text = reader.GetString("email");
                txtPhone.Text = reader.GetString("phone");
                txtUsername.Text = reader.GetString("username");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string firstname = txtFirstname.Text;
                string lastname = txtLastname.Text;
                string username = txtUsername.Text;
                string email = txtEmail.Text;
                string phone = txtPhone.Text;

                if (firstname.Length <= 0 || lastname.Length <= 0 || username.Length <= 0 || email.Length <= 0 || phone.Length <= 0)
                {
                    MessageBox.Show("Please fill in all the fields.");
                    return;
                }

                GlobalProcedures g_proc = new();
                g_proc.fncDatabaseConnection();

                if (g_proc.fncUpdateUserById(userId, firstname, lastname, username, email, phone) == false)
                {
                    MessageBox.Show("Failed to update changes.");
                    return;
                }

                MessageBox.Show("Changes saved.");
                Navigator.Navigate(this, new RoomListForm(userId));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                string oldPassword = txtOldPassword.Text;
                string newPassword = txtNewPassword.Text;
                string repassword = txtRepassword.Text;
                GlobalProcedures g_proc = new();
                g_proc.fncDatabaseConnection();
                MySqlDataReader reader = g_proc.fncGetUserById(userId);
                reader.Read();
                string userPassword = reader.GetString("password");

                if (oldPassword.Equals(userPassword) == false)
                {
                    MessageBox.Show("Invalid password.");
                    return;
                }

                if (newPassword.Length < 4)
                {
                    MessageBox.Show("Password must be at least 4 characters long.");
                    return;
                }

                if (newPassword.Equals(repassword) == false)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }

                if (g_proc.fncUpdateUserPasswordById(userId, newPassword) == false)
                {
                    MessageBox.Show("Failed to change password.");
                    return;
                }
            } catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
