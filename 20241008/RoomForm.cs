using MySql.Data.MySqlClient;
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

namespace _20241008
{


    public partial class RoomForm : Form
    {

        bool mousedown;
        Point offset;
        public int userId;
        public int roomId;
        public List<int> memberIds = new();
        public List<string> memberNames = new();
        public List<int> roleIds = new();
        public List<string> roleTitles = new();
        public List<int> partylistIds = new();
        public List<string> partylistNames = new();
        public List<int> candidateIds = new();
        public List<string> candidateNames = new();

        public RoomForm(int userId, int roomId)
        {
            InitializeComponent();
            this.userId = userId;
            this.roomId = roomId;
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

        private void RoomForm_Load(object sender, EventArgs e)
        {
            try
            {
                btnDelete.Visible = false;
                btnEdit.Visible = false;
                GlobalProcedures g_proc = new();
                g_proc.fncDatabaseConnection();
                MySqlDataReader reader = g_proc.fncGetRoomById(roomId);
                reader.Read();
                txtName.Text = reader.GetString("name");
                txtCode.Text = reader.GetString("code");

                if (userId == reader.GetInt32("author"))
                {
                    btnDelete.Visible = true;
                    btnEdit.Visible = true;
                }

                reader.Close();
                reader = g_proc.fncGetModeratorsByRoomId(roomId);

                while (reader.Read())
                {
                    if (userId == reader.GetInt32("id"))
                    {
                        btnDelete.Visible = true;
                        btnEdit.Visible = true;
                        break;
                    }
                }

                reader.Close();
                reader = g_proc.fncGetUsersByRoomId(roomId);

                while (reader.Read())
                {
                    memberIds.Add(reader.GetInt32("id"));
                    memberNames.Add(reader.GetString("firstname") + " " + reader.GetString("lastname") + " (" + reader.GetString("username") + ")");

                    if (reader.GetInt32("id") == userId && reader.GetInt32("is_done") == 1)
                    {
                        btnVote.Visible = false;
                        btnFinalize.Visible = false;
                        btnClear.Visible = false;
                    }
                }

                reader.Close();
                reader = g_proc.fncGetRolesByRoomId(roomId);

                while (reader.Read())
                {
                    roleIds.Add(reader.GetInt32("id"));
                    roleTitles.Add(reader.GetString("title"));
                }

                cmbRoles.DataSource = roleTitles.ToArray();
                reader.Close();
                reader = g_proc.fncGetPartylistsByRoomId(roomId);

                while (reader.Read())
                {
                    partylistIds.Add(reader.GetInt32("id"));
                    partylistNames.Add(reader.GetString("name"));
                }

                cmbPartylists.DataSource = partylistNames.ToArray();
                reader.Close();
                reader = g_proc.fncGetUserVotes(userId, roomId);

                while (reader.Read())
                {
                    int roleId = reader.GetInt32(0);
                    int memberId = reader.GetInt32(1);
                    int roleIndex = roleIds.IndexOf(roleId);
                    int memberIndex = memberIds.IndexOf(memberId);
                    string roleTitle = roleTitles.ElementAt(roleIndex);
                    string memberName = memberNames.ElementAt(memberIndex);
                    txtResult.Text += roleTitle + ": " + memberName + "\n";
                }

                prcUpdateCandidates();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            pnlRoomForm.BackgroundImage = Properties.Resources.active;
            pnlRoomForm.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Navigator.Navigate(this, new RoomListForm(userId));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Navigator.Navigate(this, new ManageRoomForm(userId, roomId));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                prcUpdateCandidates();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public void prcUpdateCandidates()
        {
            try
            {
                GlobalProcedures g_proc = new();
                g_proc.fncDatabaseConnection();
                int roleId = roleIds.ElementAt(cmbRoles.SelectedIndex);
                int partylistId = partylistIds.ElementAt(cmbPartylists.SelectedIndex);
                MySqlDataReader reader = g_proc.fncGetCandidatesByRoomIdRoleIdAndPartylistId(roomId, roleId, partylistId);
                candidateIds.Clear();
                candidateNames.Clear();

                while (reader.Read())
                {
                    candidateIds.Add(reader.GetInt32("id"));
                    candidateNames.Add(reader.GetString("firstname") + " " + reader.GetString("lastname") + " (" + reader.GetString("username") + ")");
                }

                cmbCandidates.DataSource = candidateNames.ToArray();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void cmbPartylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                prcUpdateCandidates();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnVote_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalProcedures g_proc = new();
                g_proc.fncDatabaseConnection();
                int candidateId = candidateIds.ElementAt(cmbCandidates.SelectedIndex);

                if (g_proc.fncVote(userId, candidateId) == false)
                {
                    MessageBox.Show("Failed to vote");
                    return;
                }

                MessageBox.Show("Voted");
                Navigator.Navigate(this, new RoomForm(userId, roomId));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to finalize vote?", "Finalize Vote", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    return;
                }

                GlobalProcedures g_proc = new();
                g_proc.fncDatabaseConnection();

                if (g_proc.fncFinalizeVote(userId, roomId) == false)
                {
                    MessageBox.Show("Failed to finalize vote");
                    return;
                }

                MessageBox.Show("Finalized vote");
                Navigator.Navigate(this, new RoomForm(userId, roomId));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to clear votes?", "Clear Votes", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    return;
                }

                GlobalProcedures g_proc = new();
                g_proc.fncDatabaseConnection();

                if (g_proc.fncClearVotes(userId, roomId) == false)
                {
                    MessageBox.Show("Failed to clear votes");
                    return;
                }

                MessageBox.Show("Cleared votes");
                Navigator.Navigate(this, new RoomForm(userId, roomId));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this room?", "Delete Room", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    return;
                }

                GlobalProcedures g_proc = new();
                g_proc.fncDatabaseConnection();

                if (g_proc.fncDeleteRoomById(roomId) == false)
                {
                    MessageBox.Show("Failed to delete room");
                    return;
                }

                MessageBox.Show("Room deleted");
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
