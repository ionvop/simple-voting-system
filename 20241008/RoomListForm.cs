using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _20241008
{
    public partial class RoomListForm : Form
    {
        bool mousedown;
        Point offset;
        public int userId;
        public List<int> roomIds = new();
        public List<string> roomNames = new();
        public List<int> createdRoomIds = new();
        public List<string> createdRoomNames = new();


        public RoomListForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
            SetRoundedCornersForPanel();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
         int nLeftRect,
         int nTopRect,
         int nRightRect,
         int nBottomRect,
         int nWidthEllipse,
         int nHeightEllipse
        );

        private void SetRoundedCornersForPanel()
        {
            int cornerRadius = 40;
            pnlMain.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlMain.Width, pnlMain.Height, cornerRadius, cornerRadius));

        }
        private void pnlMain_Resize(object sender, EventArgs e)
        {
            SetRoundedCornersForPanel();
        }
        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            SetRoundedCornersForPanel();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int cornerRadius = 25;
            Rectangle panelRect = new Rectangle(0, 0, pnlMain.Width, pnlMain.Height);

            using (GraphicsPath path = GetRoundedRectPath(panelRect, cornerRadius))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.Clear(pnlMain.Parent.BackColor);


                using (SolidBrush brush = new SolidBrush(pnlMain.BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

            }
        }
        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            int diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);

            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);

            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);

            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
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

                if (reader.GetBoolean("is_verified"))
                {
                    lblStatus.Text = "Account status: Verified";

                    foreach (Control ctrl in grpProfile.Controls)
                    {
                        if (ctrl.Name == "btnLogout" || ctrl.Name == "lblStatus")
                        {
                            continue;
                        }

                        ctrl.Enabled = false;
                    }
                }

                reader.Close();
                reader = g_proc.fncGetRoomsByUserId(userId);

                while (reader.Read())
                {
                    roomIds.Add(reader.GetInt32("id"));
                    roomNames.Add(reader.GetString("name"));
                }

                listRooms.DataSource = roomNames.ToArray();
                reader.Close();
                reader = g_proc.fncGetRoomsByAuthor(userId);

                while (reader.Read())
                {
                    createdRoomIds.Add(reader.GetInt32("id"));
                    createdRoomNames.Add(reader.GetString("name"));
                }

                listCreatedRooms.DataSource = createdRoomNames.ToArray();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            SetRoundedCornersForPanel();
            pnlRoomList.BackgroundImage = Properties.Resources.active;
            pnlRoomList.BackgroundImageLayout = ImageLayout.Stretch;
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
                string votersId = txtVotersId.Text;

                if (firstname.Length <= 0 || lastname.Length <= 0 || username.Length <= 0 || email.Length <= 0 || phone.Length <= 0)
                {
                    MessageBox.Show("Please fill in all the fields.");
                    return;
                }

                GlobalProcedures g_proc = new();
                g_proc.fncDatabaseConnection();

                if (g_proc.fncUpdateUserById(userId, firstname, lastname, username, email, phone, votersId) == false)
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
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    return;
                }

                Navigator.Navigate(this, new LoginForm());
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnCreateRoom_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalProcedures g_proc = new();
                g_proc.fncDatabaseConnection();
                MySqlDataReader reader = g_proc.fncCreateRoom(userId);
                reader.Read();
                int roomId = reader.GetInt32(0);
                Navigator.Navigate(this, new RoomForm(userId, roomId));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                int roomId = roomIds.ElementAt(listRooms.SelectedIndex);
                Navigator.Navigate(this, new RoomForm(userId, roomId));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnOpenCreatedRoom_Click(object sender, EventArgs e)
        {
            try
            {
                int roomId = createdRoomIds.ElementAt(listCreatedRooms.SelectedIndex);
                Navigator.Navigate(this, new RoomForm(userId, roomId));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnJoinRoom_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalProcedures g_proc = new();
                g_proc.fncDatabaseConnection();
                MySqlDataReader reader = g_proc.fncJoinRoomByCode(userId, txtRoomCode.Text);

                if (reader.Read() == false)
                {
                    MessageBox.Show("Room does not exist or you're not authorized.");
                    return;
                }

                if (reader.GetInt32(0) == -1)
                {
                    MessageBox.Show("Room does not exist or you're not authorized.");
                    return;
                }

                int roomId = reader.GetInt32(0);
                Navigator.Navigate(this, new RoomForm(userId, roomId));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.StackTrace);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to leave this room?", "Leave room", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    return;
                }

                GlobalProcedures g_proc = new();
                g_proc.fncDatabaseConnection();
                int roomId = roomIds.ElementAt(listRooms.SelectedIndex);

                if (g_proc.fncLeaveRoom(userId, roomId) == false)
                {
                    MessageBox.Show("Failed to leave room.");
                    return;
                }

                Navigator.Navigate(this, new RoomListForm(userId));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {



                DialogResult result = MessageBox.Show("Do you really want to close?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {

                    this.Close();
                }
            }
            catch (Exception)
            {


            }


        }
        private void Status_Move(object sender, MouseEventArgs e)
        {
            if (mousedown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void Status_Up(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void Status_Down(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mousedown = true;
        }
    }
}
