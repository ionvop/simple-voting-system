using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20241008
{
    public partial class ManageRoomForm : Form
    {
        public int userId;
        public int roomId;
        public bool ignoreEvents = false;
        public List<int> memberIds = new();
        public List<string> memberNames = new();
        public List<int> roleIds = new();
        public List<string> roleTitles = new();
        public List<int> partylistIds = new();
        public List<string> partylistNames = new();
        public List<int> candidateIds = new();
        public List<string> candidateNames = new();
        public List<string> availableMembers = new();
        public List<int> availableMemberIds = new();

        public ManageRoomForm(int userId, int roomId)
        {
            InitializeComponent();
            this.userId = userId;
            this.roomId = roomId;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Navigator.Navigate(this, new RoomForm(userId, roomId));
        }

        private void ManageRoomForm_Load(object sender, EventArgs e)
        {
            try
            {
                GlobalProcedures g_proc = new();
                g_proc.fncDatabaseConnection();
                MySqlDataReader reader = g_proc.fncGetRoomById(roomId);
                reader.Read();
                txtName.Text = reader.GetString("name");
                txtCode.Text = reader.GetString("code");
                reader.Close();
                reader = g_proc.fncGetUsersByRoomId(roomId);

                while (reader.Read())
                {
                    memberIds.Add(reader.GetInt32("id"));
                    memberNames.Add(reader.GetString("firstname") + " " + reader.GetString("lastname") + " (" + reader.GetString("username") + ")");
                }

                availableMembers = memberNames;
                availableMemberIds = memberIds;
                listMembers.DataSource = memberNames.ToArray();
                reader.Close();
                reader = g_proc.fncGetRolesByRoomId(roomId);

                while (reader.Read())
                {
                    roleIds.Add(reader.GetInt32("id"));
                    roleTitles.Add(reader.GetString("title"));
                }

                listRoles.DataSource = roleTitles.ToArray();
                cmbRoles.DataSource = roleTitles.ToArray();
                reader.Close();
                reader = g_proc.fncGetPartylistsByRoomId(roomId);

                while (reader.Read())
                {
                    partylistIds.Add(reader.GetInt32("id"));
                    partylistNames.Add(reader.GetString("name"));
                }

                listPartylists.DataSource = partylistNames.ToArray();
                cmbPartylists.DataSource = partylistNames.ToArray();
                reader.Close();
                reader = g_proc.fncGetUserCandidatesByRoomId(roomId);

                while (reader.Read())
                {
                    candidateIds.Add(reader.GetInt32("id"));
                    string name = reader.GetString("firstname") + " " + reader.GetString("lastname") + " (" + reader.GetString("username") + ")";
                    candidateNames.Add(name);

                    if (availableMembers.Contains(name))
                    {
                        int index = availableMembers.IndexOf(name);
                        availableMemberIds.RemoveAt(index);
                        availableMembers.RemoveAt(index);
                    }
                }

                listCandidates.DataSource = candidateNames.ToArray();
                cmbCandidates.DataSource = availableMembers.ToArray();
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
                GlobalProcedures g_proc = new();
                g_proc.fncDatabaseConnection();

                if (g_proc.fncUpdateRoomById(roomId, txtName.Text, txtCode.Text) == false)
                {
                    MessageBox.Show("Failed to update room");
                    return;
                }

                MessageBox.Show("Room updated");
                Navigator.Navigate(this, new ManageRoomForm(userId, roomId));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void listMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ignoreEvents = true;
                chkModerator.Checked = false;
                ignoreEvents = false;
                GlobalProcedures g_proc = new();
                g_proc.fncDatabaseConnection();
                MySqlDataReader reader = g_proc.fncGetModeratorsByRoomId(roomId);

                while (reader.Read())
                {
                    int selectedMemberId = memberIds.ElementAt(listMembers.SelectedIndex);

                    if (selectedMemberId == reader.GetInt32("id"))
                    {
                        ignoreEvents = true;
                        chkModerator.Checked = true;
                        ignoreEvents = false;
                        break;
                    }
                }

                reader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void chkModerator_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ignoreEvents == true)
                {
                    return;
                }

                GlobalProcedures g_proc = new();
                g_proc.fncDatabaseConnection();
                int selectedMemberId = memberIds.ElementAt(listMembers.SelectedIndex);

                if (g_proc.fncSetModerator(selectedMemberId, roomId, chkModerator.Checked) == false)
                {
                    MessageBox.Show("Failed to set moderator status");
                    return;
                }

                MessageBox.Show("Moderator status updated");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnRemoveRole_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this role?", "Delete role", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    return;
                }

                GlobalProcedures g_proc = new();
                g_proc.fncDatabaseConnection();
                int roleId = roleIds.ElementAt(listRoles.SelectedIndex);

                if (g_proc.fncDeleteRoleById(roleId) == false)
                {
                    MessageBox.Show("Failed to delete role");
                    return;
                }

                MessageBox.Show("Role deleted");
                Navigator.Navigate(this, new ManageRoomForm(userId, roomId));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalProcedures g_proc = new();
                g_proc.fncDatabaseConnection();

                if (g_proc.fncInsertRole(txtRole.Text, roomId) == false)
                {
                    MessageBox.Show("Failed to insert role");
                    return;
                }

                MessageBox.Show("Role inserted");
                Navigator.Navigate(this, new ManageRoomForm(userId, roomId));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnRemovePartylist_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this partylist?", "Delete partylist", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    return;
                }

                GlobalProcedures g_proc = new();
                g_proc.fncDatabaseConnection();
                int partylistId = partylistIds.ElementAt(listPartylists.SelectedIndex);

                if (g_proc.fncDeletePartylistById(partylistId) == false)
                {
                    MessageBox.Show("Failed to delete partylist");
                    return;
                }

                MessageBox.Show("Partylist deleted");
                Navigator.Navigate(this, new ManageRoomForm(userId, roomId));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnAddPartylist_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalProcedures g_proc = new();
                g_proc.fncDatabaseConnection();

                if (g_proc.fncInsertPartylist(txtPartylist.Text, roomId) == false)
                {
                    MessageBox.Show("Failed to insert partylist");
                    return;
                }

                MessageBox.Show("Partylist inserted");
                Navigator.Navigate(this, new ManageRoomForm(userId, roomId));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnRemoveCandidate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this candidate?", "Delete candidate", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    return;
                }

                GlobalProcedures g_proc = new();
                g_proc.fncDatabaseConnection();
                int candidateId = candidateIds.ElementAt(listCandidates.SelectedIndex);

                if (g_proc.fncDeleteCandidateById(candidateId) == false)
                {
                    MessageBox.Show("Failed to delete candidate");
                    return;
                }

                MessageBox.Show("Candidate deleted");
                Navigator.Navigate(this, new ManageRoomForm(userId, roomId));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnAddCandidate_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalProcedures g_proc = new();
                g_proc.fncDatabaseConnection();
                int selectedMemberId = availableMemberIds.ElementAt(cmbCandidates.SelectedIndex);
                int roleId = roleIds.ElementAt(listRoles.SelectedIndex);
                int partylistId = partylistIds.ElementAt(listPartylists.SelectedIndex);

                if (g_proc.fncInsertCandidate(selectedMemberId, roomId, roleId, partylistId) == false)
                {
                    MessageBox.Show("Failed to insert candidate");
                    return;
                }

                MessageBox.Show("Candidate inserted");
                Navigator.Navigate(this, new ManageRoomForm(userId, roomId));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void listCandidates_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GlobalProcedures g_proc = new();
                g_proc.fncDatabaseConnection();
                int selectedCandidateId = candidateIds.ElementAt(listCandidates.SelectedIndex);

                MySqlDataReader reader = g_proc.fncGetCandidateById(selectedCandidateId);
                reader.Read();
                cmbRoles.SelectedIndex = roleIds.IndexOf(reader.GetInt32("role_id"));
                cmbPartylists.SelectedIndex = partylistIds.IndexOf(reader.GetInt32("partylist_id"));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnSaveCandidate_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalProcedures g_proc = new();
                g_proc.fncDatabaseConnection();
                int selectedCandidateId = candidateIds.ElementAt(listCandidates.SelectedIndex);
                int roleId = roleIds.ElementAt(cmbRoles.SelectedIndex);
                int partylistId = partylistIds.ElementAt(cmbPartylists.SelectedIndex);

                if (g_proc.fncUpdateCandidateById(selectedCandidateId, roleId, partylistId) == false)
                {
                    MessageBox.Show("Failed to update candidate");
                    return;
                }

                MessageBox.Show("Candidate updated");
                Navigator.Navigate(this, new ManageRoomForm(userId, roomId));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            try
            {
                Navigator.Navigate(this, new ResultsForm(userId, roomId));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
