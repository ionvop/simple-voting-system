#nullable disable
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string firstname = txtRegisterFirstname.Text;
                string lastname = txtRegisterLastname.Text;
                string email = txtRegisterEmail.Text;
                string phone = txtRegisterPhone.Text;
                string username = txtRegisterUsername.Text;
                string password = txtRegisterPassword.Text;
                string repassword = txtRegisterRepassword.Text;

                if (firstname.Length <= 0 || lastname.Length <= 0 || email.Length <= 0 || phone.Length <= 0 || username.Length <= 0 || password.Length <= 0 || repassword.Length <= 0)
                {
                    MessageBox.Show("Please fill in all the fields.");
                    return;
                }

                if (password.Length < 4)
                {
                    MessageBox.Show("Password must be at least 4 characters long.");
                    return;
                }

                if (password.Equals(repassword) == false)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }

                GlobalProcedures g_proc = new();
                g_proc.fncDatabaseConnection();

                if (g_proc.fncRegister(firstname, lastname, username, email, password, phone) == false)
                {
                    MessageBox.Show("Failed to register.");
                    return;
                }

                MySqlDataReader reader = g_proc.fncLogin(username, password);
                reader.Read();
                int userId = reader.GetInt32(0);
                Navigator.Navigate(this, new RoomListForm(userId));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtLoginUsername.Text;
                string password = txtLoginPassword.Text;

                if (username == "" || password == "")
                {
                    MessageBox.Show("Please fill in all the fields.");
                    return;
                }

                GlobalProcedures g_proc = new();
                g_proc.fncDatabaseConnection();
                MySqlDataReader reader = g_proc.fncLogin(username, password);
                reader.Read();
                int userId = reader.GetInt32(0);
                Navigator.Navigate(this, new RoomListForm(userId));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
