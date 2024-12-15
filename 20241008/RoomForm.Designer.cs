namespace _20241008
{
    partial class RoomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBack = new Button();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            txtName = new TextBox();
            label2 = new Label();
            btnEdit = new Button();
            label1 = new Label();
            txtCode = new TextBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            cmbRoles = new ComboBox();
            cmbCandidates = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            cmbPartylists = new ComboBox();
            btnClear = new Button();
            btnVote = new Button();
            groupBox3 = new GroupBox();
            btnFinalize = new Button();
            txtResult = new TextBox();
            panel1 = new Panel();
            btnExit = new Button();
            panel2 = new Panel();
            pnlMain = new Panel();
            pnlRoomForm = new Panel();
            label19 = new Label();
            pictureBox1 = new PictureBox();
            pnlRoomList = new Panel();
            label20 = new Label();
            pictureBox2 = new PictureBox();
            pnlManageRoom = new Panel();
            label22 = new Label();
            pictureBox4 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlRoomForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlRoomList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlManageRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.BackgroundImage = Properties.Resources.move_left;
            btnBack.BackgroundImageLayout = ImageLayout.Center;
            btnBack.FlatStyle = FlatStyle.Popup;
            btnBack.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(123, 687);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 31);
            btnBack.TabIndex = 1;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCode);
            groupBox1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(17, 185);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(298, 356);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Room settings";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Image = Properties.Resources.trash;
            btnDelete.ImageAlign = ContentAlignment.MiddleRight;
            btnDelete.Location = new Point(47, 243);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 68);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete Room";
            btnDelete.TextAlign = ContentAlignment.MiddleLeft;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(27, 92);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(251, 26);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 143);
            label2.Name = "label2";
            label2.Size = new Size(76, 18);
            label2.TabIndex = 3;
            label2.Text = "Room code:";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(255, 189, 3);
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Font = new Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Image = Properties.Resources.edit;
            btnEdit.ImageAlign = ContentAlignment.MiddleRight;
            btnEdit.Location = new Point(153, 243);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(101, 68);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit Room";
            btnEdit.TextAlign = ContentAlignment.MiddleLeft;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 55);
            label1.Name = "label1";
            label1.Size = new Size(80, 18);
            label1.TabIndex = 3;
            label1.Text = "Room name:";
            // 
            // txtCode
            // 
            txtCode.BackColor = Color.White;
            txtCode.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCode.Location = new Point(27, 168);
            txtCode.Margin = new Padding(3, 4, 3, 4);
            txtCode.Name = "txtCode";
            txtCode.ReadOnly = true;
            txtCode.Size = new Size(251, 26);
            txtCode.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cmbRoles);
            groupBox2.Controls.Add(cmbCandidates);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cmbPartylists);
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnVote);
            groupBox2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(321, 4);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(301, 753);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Vote";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 181);
            label3.Name = "label3";
            label3.Size = new Size(34, 18);
            label3.TabIndex = 0;
            label3.Text = "Role";
            // 
            // cmbRoles
            // 
            cmbRoles.BackColor = Color.DimGray;
            cmbRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoles.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(24, 211);
            cmbRoles.Margin = new Padding(3, 4, 3, 4);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(251, 26);
            cmbRoles.TabIndex = 1;
            cmbRoles.SelectionChangeCommitted += cmbRoles_SelectedIndexChanged;
            // 
            // cmbCandidates
            // 
            cmbCandidates.BackColor = Color.DimGray;
            cmbCandidates.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCandidates.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCandidates.FormattingEnabled = true;
            cmbCandidates.Location = new Point(24, 424);
            cmbCandidates.Margin = new Padding(3, 4, 3, 4);
            cmbCandidates.Name = "cmbCandidates";
            cmbCandidates.Size = new Size(251, 26);
            cmbCandidates.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(24, 395);
            label5.Name = "label5";
            label5.Size = new Size(65, 18);
            label5.TabIndex = 0;
            label5.Text = "Candidate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(24, 288);
            label4.Name = "label4";
            label4.Size = new Size(57, 18);
            label4.TabIndex = 0;
            label4.Text = "Partylist";
            // 
            // cmbPartylists
            // 
            cmbPartylists.BackColor = Color.DimGray;
            cmbPartylists.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPartylists.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbPartylists.FormattingEnabled = true;
            cmbPartylists.Location = new Point(24, 317);
            cmbPartylists.Margin = new Padding(3, 4, 3, 4);
            cmbPartylists.Name = "cmbPartylists";
            cmbPartylists.Size = new Size(251, 26);
            cmbPartylists.TabIndex = 1;
            cmbPartylists.SelectionChangeCommitted += cmbPartylists_SelectedIndexChanged;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.IndianRed;
            btnClear.FlatStyle = FlatStyle.Popup;
            btnClear.Font = new Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Image = Properties.Resources.trash;
            btnClear.ImageAlign = ContentAlignment.MiddleRight;
            btnClear.Location = new Point(24, 659);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(124, 55);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear Vote";
            btnClear.TextAlign = ContentAlignment.MiddleLeft;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnVote
            // 
            btnVote.BackColor = Color.FromArgb(51, 178, 73);
            btnVote.FlatStyle = FlatStyle.Popup;
            btnVote.Font = new Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVote.ForeColor = Color.White;
            btnVote.Image = Properties.Resources.vote;
            btnVote.ImageAlign = ContentAlignment.MiddleRight;
            btnVote.Location = new Point(154, 659);
            btnVote.Margin = new Padding(3, 4, 3, 4);
            btnVote.Name = "btnVote";
            btnVote.Size = new Size(121, 55);
            btnVote.TabIndex = 2;
            btnVote.Text = "Vote";
            btnVote.UseVisualStyleBackColor = false;
            btnVote.Click += btnVote_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(btnFinalize);
            groupBox3.Controls.Add(txtResult);
            groupBox3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(628, 4);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(348, 753);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Your votes";
            // 
            // btnFinalize
            // 
            btnFinalize.BackColor = Color.FromArgb(51, 178, 73);
            btnFinalize.FlatStyle = FlatStyle.Popup;
            btnFinalize.Font = new Font("Bahnschrift SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnFinalize.ForeColor = Color.White;
            btnFinalize.Image = Properties.Resources.vote;
            btnFinalize.ImageAlign = ContentAlignment.MiddleRight;
            btnFinalize.Location = new Point(107, 659);
            btnFinalize.Margin = new Padding(3, 4, 3, 4);
            btnFinalize.Name = "btnFinalize";
            btnFinalize.Size = new Size(149, 55);
            btnFinalize.TabIndex = 1;
            btnFinalize.Text = "Finalize Votes";
            btnFinalize.TextAlign = ContentAlignment.MiddleLeft;
            btnFinalize.UseVisualStyleBackColor = false;
            btnFinalize.Click += btnFinalize_Click;
            // 
            // txtResult
            // 
            txtResult.BackColor = Color.FromArgb(251, 211, 179);
            txtResult.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtResult.Location = new Point(23, 53);
            txtResult.Margin = new Padding(3, 4, 3, 4);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(304, 579);
            txtResult.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 40, 190);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-22, -20);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1664, 51);
            panel1.TabIndex = 26;
            panel1.MouseDown += Status_Down;
            panel1.MouseMove += Status_Move;
            panel1.MouseUp += Status_Up;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.BackgroundImage = Properties.Resources.close;
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Location = new Point(1158, 22);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(29, 25);
            btnExit.TabIndex = 37;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.close;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(1478, 23);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(27, 28);
            panel2.TabIndex = 19;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(235, 244, 253);
            pnlMain.Controls.Add(groupBox3);
            pnlMain.Controls.Add(btnBack);
            pnlMain.Controls.Add(groupBox1);
            pnlMain.Controls.Add(groupBox2);
            pnlMain.Location = new Point(189, 39);
            pnlMain.Margin = new Padding(3, 4, 3, 4);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(991, 767);
            pnlMain.TabIndex = 27;
            // 
            // pnlRoomForm
            // 
            pnlRoomForm.Controls.Add(label19);
            pnlRoomForm.Controls.Add(pictureBox1);
            pnlRoomForm.Location = new Point(-22, 235);
            pnlRoomForm.Margin = new Padding(3, 4, 3, 4);
            pnlRoomForm.Name = "pnlRoomForm";
            pnlRoomForm.Size = new Size(205, 104);
            pnlRoomForm.TabIndex = 30;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.White;
            label19.Location = new Point(65, 71);
            label19.Name = "label19";
            label19.Size = new Size(80, 20);
            label19.TabIndex = 4;
            label19.Text = "Room Form";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.ROOM1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(77, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 51);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pnlRoomList
            // 
            pnlRoomList.Controls.Add(label20);
            pnlRoomList.Controls.Add(pictureBox2);
            pnlRoomList.Location = new Point(-22, 360);
            pnlRoomList.Margin = new Padding(3, 4, 3, 4);
            pnlRoomList.Name = "pnlRoomList";
            pnlRoomList.Size = new Size(205, 104);
            pnlRoomList.TabIndex = 31;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.White;
            label20.Location = new Point(69, 71);
            label20.Name = "label20";
            label20.Size = new Size(71, 20);
            label20.TabIndex = 5;
            label20.Text = "Room List";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.LIST;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(77, 16);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 51);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pnlManageRoom
            // 
            pnlManageRoom.Controls.Add(label22);
            pnlManageRoom.Controls.Add(pictureBox4);
            pnlManageRoom.Location = new Point(-22, 485);
            pnlManageRoom.Margin = new Padding(3, 4, 3, 4);
            pnlManageRoom.Name = "pnlManageRoom";
            pnlManageRoom.Size = new Size(205, 104);
            pnlManageRoom.TabIndex = 33;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.White;
            label22.Location = new Point(58, 71);
            label22.Name = "label22";
            label22.Size = new Size(96, 20);
            label22.TabIndex = 6;
            label22.Text = "Manage Room";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = Properties.Resources.MANAGE;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(77, 16);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 51);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // RoomForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 6, 79);
            BackgroundImage = Properties.Resources.BACKGROUND;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1186, 819);
            Controls.Add(pnlMain);
            Controls.Add(panel1);
            Controls.Add(pnlRoomForm);
            Controls.Add(pnlRoomList);
            Controls.Add(pnlManageRoom);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "RoomForm";
            Text = "RoomForm";
            Load += RoomForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            pnlRoomForm.ResumeLayout(false);
            pnlRoomForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlRoomList.ResumeLayout(false);
            pnlRoomList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlManageRoom.ResumeLayout(false);
            pnlManageRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private GroupBox groupBox1;
        private TextBox txtCode;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private Button btnEdit;
        private GroupBox groupBox2;
        private Button btnVote;
        private ComboBox cmbCandidates;
        private ComboBox cmbPartylists;
        private ComboBox cmbRoles;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnDelete;
        private GroupBox groupBox3;
        private TextBox txtResult;
        private Button btnFinalize;
        private Button btnClear;
        private Panel panel1;
        private Panel pnlMain;
        private Panel pnlRoomForm;
        private Label label19;
        private PictureBox pictureBox1;
        private Panel pnlRoomList;
        private Label label20;
        private PictureBox pictureBox2;
        private Panel pnlManageRoom;
        private Label label22;
        private PictureBox pictureBox4;
        private Panel panel2;
        private Button btnExit;
    }
}