using MySql.Data.MySqlClient;
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
    public partial class ResultsForm : Form
    {
        public int userId;
        public int roomId;

        public ResultsForm(int userId, int roomId)
        {
            InitializeComponent();
            this.userId = userId;
            this.roomId = roomId;
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            try
            {
                GlobalProcedures g_proc = new();
                g_proc.fncDatabaseConnection();
                MySqlDataReader reader = g_proc.fncPrintResults(roomId);

                while (reader.Read())
                {
                    gridResult.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetInt32(2));
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
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
    }
}
