namespace _20241008
{
    partial class ManageRoomForm
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
            btnKick = new Button();
            chkVerified = new CheckBox();
            chkModerator = new CheckBox();
            btnSave = new Button();
            listMembers = new ListBox();
            txtCode = new TextBox();
            txtName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtPartylist = new TextBox();
            txtRole = new TextBox();
            btnRemovePartylist = new Button();
            btnRemoveRole = new Button();
            btnAddPartylist = new Button();
            btnAddRole = new Button();
            listRoles = new ListBox();
            listPartylists = new ListBox();
            label5 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            cmbPartylists = new ComboBox();
            btnResults = new Button();
            btnSaveCandidate = new Button();
            cmbRoles = new ComboBox();
            cmbCandidates = new ComboBox();
            label6 = new Label();
            listCandidates = new ListBox();
            btnAddCandidate = new Button();
            btnRemoveCandidate = new Button();
            label8 = new Label();
            label7 = new Label();
            pnlMain = new Panel();
            panel1 = new Panel();
            btnExit = new Button();
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
            pnlMain.SuspendLayout();
            panel1.SuspendLayout();
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
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(86, 524);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnKick);
            groupBox1.Controls.Add(chkVerified);
            groupBox1.Controls.Add(chkModerator);
            groupBox1.Controls.Add(btnBack);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(listMembers);
            groupBox1.Controls.Add(txtCode);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(15, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(260, 565);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Room settings";
            // 
            // btnKick
            // 
            btnKick.BackColor = Color.FromArgb(221, 121, 115);
            btnKick.FlatStyle = FlatStyle.Popup;
            btnKick.Font = new Font("Bahnschrift SemiBold SemiConden", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnKick.ForeColor = Color.White;
            btnKick.Location = new Point(148, 492);
            btnKick.Name = "btnKick";
            btnKick.Size = new Size(75, 23);
            btnKick.TabIndex = 6;
            btnKick.Text = "Kick";
            btnKick.UseVisualStyleBackColor = false;
            // 
            // chkVerified
            // 
            chkVerified.AutoSize = true;
            chkVerified.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chkVerified.Location = new Point(20, 160);
            chkVerified.Name = "chkVerified";
            chkVerified.Size = new Size(114, 18);
            chkVerified.TabIndex = 5;
            chkVerified.Text = "Verified users only";
            chkVerified.UseVisualStyleBackColor = true;
            chkVerified.CheckedChanged += chkVerified_CheckedChange;
            // 
            // chkModerator
            // 
            chkModerator.AutoSize = true;
            chkModerator.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chkModerator.Location = new Point(48, 492);
            chkModerator.Name = "chkModerator";
            chkModerator.Size = new Size(76, 18);
            chkModerator.TabIndex = 5;
            chkModerator.Text = "Moderator";
            chkModerator.UseVisualStyleBackColor = true;
            chkModerator.CheckedChanged += chkModerator_CheckedChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(51, 178, 73);
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Bahnschrift SemiBold SemiConden", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Image = Properties.Resources.save;
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(140, 160);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 29);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save changes";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // listMembers
            // 
            listMembers.BackColor = Color.FromArgb(251, 211, 179);
            listMembers.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listMembers.FormattingEnabled = true;
            listMembers.ItemHeight = 14;
            listMembers.Location = new Point(23, 227);
            listMembers.Name = "listMembers";
            listMembers.Size = new Size(220, 242);
            listMembers.TabIndex = 2;
            listMembers.SelectedIndexChanged += listMembers_SelectedIndexChanged;
            // 
            // txtCode
            // 
            txtCode.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCode.Location = new Point(23, 131);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(220, 22);
            txtCode.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(23, 64);
            txtName.Name = "txtName";
            txtName.Size = new Size(220, 22);
            txtName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(23, 207);
            label3.Name = "label3";
            label3.Size = new Size(51, 14);
            label3.TabIndex = 2;
            label3.Text = "Members";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 111);
            label2.Name = "label2";
            label2.Size = new Size(61, 14);
            label2.TabIndex = 2;
            label2.Text = "Room code";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 44);
            label1.Name = "label1";
            label1.Size = new Size(65, 14);
            label1.TabIndex = 2;
            label1.Text = "Room name";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(txtPartylist);
            groupBox2.Controls.Add(txtRole);
            groupBox2.Controls.Add(btnRemovePartylist);
            groupBox2.Controls.Add(btnRemoveRole);
            groupBox2.Controls.Add(btnAddPartylist);
            groupBox2.Controls.Add(btnAddRole);
            groupBox2.Controls.Add(listRoles);
            groupBox2.Controls.Add(listPartylists);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(280, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(263, 565);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Manage room";
            // 
            // txtPartylist
            // 
            txtPartylist.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPartylist.Location = new Point(20, 521);
            txtPartylist.Name = "txtPartylist";
            txtPartylist.Size = new Size(164, 22);
            txtPartylist.TabIndex = 3;
            // 
            // txtRole
            // 
            txtRole.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtRole.Location = new Point(20, 238);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(164, 22);
            txtRole.TabIndex = 3;
            // 
            // btnRemovePartylist
            // 
            btnRemovePartylist.BackColor = Color.FromArgb(221, 121, 115);
            btnRemovePartylist.FlatStyle = FlatStyle.Popup;
            btnRemovePartylist.Font = new Font("Bahnschrift SemiBold SemiConden", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemovePartylist.ForeColor = Color.White;
            btnRemovePartylist.Image = Properties.Resources.trash;
            btnRemovePartylist.ImageAlign = ContentAlignment.MiddleRight;
            btnRemovePartylist.Location = new Point(20, 486);
            btnRemovePartylist.Name = "btnRemovePartylist";
            btnRemovePartylist.Size = new Size(223, 29);
            btnRemovePartylist.TabIndex = 3;
            btnRemovePartylist.Text = "Remove";
            btnRemovePartylist.TextAlign = ContentAlignment.MiddleLeft;
            btnRemovePartylist.UseVisualStyleBackColor = false;
            btnRemovePartylist.Click += btnRemovePartylist_Click;
            // 
            // btnRemoveRole
            // 
            btnRemoveRole.BackColor = Color.FromArgb(221, 121, 115);
            btnRemoveRole.FlatStyle = FlatStyle.Popup;
            btnRemoveRole.Font = new Font("Bahnschrift SemiBold SemiConden", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemoveRole.ForeColor = Color.White;
            btnRemoveRole.Image = Properties.Resources.trash;
            btnRemoveRole.ImageAlign = ContentAlignment.MiddleRight;
            btnRemoveRole.Location = new Point(20, 201);
            btnRemoveRole.Name = "btnRemoveRole";
            btnRemoveRole.Size = new Size(223, 29);
            btnRemoveRole.TabIndex = 3;
            btnRemoveRole.Text = "Remove";
            btnRemoveRole.TextAlign = ContentAlignment.MiddleLeft;
            btnRemoveRole.UseVisualStyleBackColor = false;
            btnRemoveRole.Click += btnRemoveRole_Click;
            // 
            // btnAddPartylist
            // 
            btnAddPartylist.BackColor = Color.FromArgb(51, 178, 73);
            btnAddPartylist.BackgroundImage = Properties.Resources.square_plus;
            btnAddPartylist.BackgroundImageLayout = ImageLayout.Center;
            btnAddPartylist.FlatStyle = FlatStyle.Popup;
            btnAddPartylist.Location = new Point(189, 520);
            btnAddPartylist.Name = "btnAddPartylist";
            btnAddPartylist.Size = new Size(54, 23);
            btnAddPartylist.TabIndex = 3;
            btnAddPartylist.UseVisualStyleBackColor = false;
            btnAddPartylist.Click += btnAddPartylist_Click;
            // 
            // btnAddRole
            // 
            btnAddRole.BackColor = Color.FromArgb(51, 178, 73);
            btnAddRole.BackgroundImage = Properties.Resources.square_plus;
            btnAddRole.BackgroundImageLayout = ImageLayout.Center;
            btnAddRole.FlatStyle = FlatStyle.Popup;
            btnAddRole.Location = new Point(189, 236);
            btnAddRole.Name = "btnAddRole";
            btnAddRole.Size = new Size(54, 23);
            btnAddRole.TabIndex = 3;
            btnAddRole.UseVisualStyleBackColor = false;
            btnAddRole.Click += btnAddRole_Click;
            // 
            // listRoles
            // 
            listRoles.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listRoles.FormattingEnabled = true;
            listRoles.ItemHeight = 14;
            listRoles.Location = new Point(20, 54);
            listRoles.Name = "listRoles";
            listRoles.Size = new Size(224, 130);
            listRoles.TabIndex = 2;
            // 
            // listPartylists
            // 
            listPartylists.BackColor = Color.FromArgb(251, 211, 179);
            listPartylists.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listPartylists.FormattingEnabled = true;
            listPartylists.ItemHeight = 14;
            listPartylists.Location = new Point(20, 281);
            listPartylists.Name = "listPartylists";
            listPartylists.Size = new Size(224, 186);
            listPartylists.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(20, 261);
            label5.Name = "label5";
            label5.Size = new Size(52, 14);
            label5.TabIndex = 3;
            label5.Text = "Partylists";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 34);
            label4.Name = "label4";
            label4.Size = new Size(34, 14);
            label4.TabIndex = 3;
            label4.Text = "Roles";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(cmbPartylists);
            groupBox3.Controls.Add(btnResults);
            groupBox3.Controls.Add(btnSaveCandidate);
            groupBox3.Controls.Add(cmbRoles);
            groupBox3.Controls.Add(cmbCandidates);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(listCandidates);
            groupBox3.Controls.Add(btnAddCandidate);
            groupBox3.Controls.Add(btnRemoveCandidate);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(548, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(304, 565);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Manage candidates";
            // 
            // cmbPartylists
            // 
            cmbPartylists.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPartylists.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbPartylists.FormattingEnabled = true;
            cmbPartylists.Location = new Point(48, 472);
            cmbPartylists.Name = "cmbPartylists";
            cmbPartylists.Size = new Size(220, 22);
            cmbPartylists.TabIndex = 4;
            // 
            // btnResults
            // 
            btnResults.BackColor = Color.FromArgb(255, 189, 3);
            btnResults.FlatStyle = FlatStyle.Popup;
            btnResults.Font = new Font("Bahnschrift SemiBold SemiConden", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnResults.ForeColor = Color.White;
            btnResults.Location = new Point(63, 521);
            btnResults.Name = "btnResults";
            btnResults.Size = new Size(100, 23);
            btnResults.TabIndex = 0;
            btnResults.Text = "View results";
            btnResults.UseVisualStyleBackColor = false;
            btnResults.Click += btnResults_Click;
            // 
            // btnSaveCandidate
            // 
            btnSaveCandidate.BackColor = Color.FromArgb(51, 178, 73);
            btnSaveCandidate.FlatStyle = FlatStyle.Popup;
            btnSaveCandidate.Font = new Font("Bahnschrift SemiBold SemiConden", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveCandidate.ForeColor = Color.White;
            btnSaveCandidate.Image = Properties.Resources.save;
            btnSaveCandidate.ImageAlign = ContentAlignment.MiddleRight;
            btnSaveCandidate.Location = new Point(168, 516);
            btnSaveCandidate.Name = "btnSaveCandidate";
            btnSaveCandidate.Size = new Size(100, 30);
            btnSaveCandidate.TabIndex = 0;
            btnSaveCandidate.Text = "Save changes";
            btnSaveCandidate.TextAlign = ContentAlignment.MiddleLeft;
            btnSaveCandidate.UseVisualStyleBackColor = false;
            btnSaveCandidate.Click += btnSaveCandidate_Click;
            // 
            // cmbRoles
            // 
            cmbRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoles.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(48, 412);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(220, 22);
            cmbRoles.TabIndex = 4;
            // 
            // cmbCandidates
            // 
            cmbCandidates.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCandidates.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbCandidates.FormattingEnabled = true;
            cmbCandidates.Location = new Point(48, 362);
            cmbCandidates.Name = "cmbCandidates";
            cmbCandidates.Size = new Size(173, 22);
            cmbCandidates.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(22, 37);
            label6.Name = "label6";
            label6.Size = new Size(0, 14);
            label6.TabIndex = 3;
            // 
            // listCandidates
            // 
            listCandidates.BackColor = Color.FromArgb(251, 211, 179);
            listCandidates.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listCandidates.FormattingEnabled = true;
            listCandidates.ItemHeight = 14;
            listCandidates.Location = new Point(22, 57);
            listCandidates.Name = "listCandidates";
            listCandidates.Size = new Size(266, 256);
            listCandidates.TabIndex = 2;
            listCandidates.SelectedIndexChanged += listCandidates_SelectedIndexChanged;
            // 
            // btnAddCandidate
            // 
            btnAddCandidate.BackColor = Color.FromArgb(51, 178, 73);
            btnAddCandidate.BackgroundImage = Properties.Resources.square_plus;
            btnAddCandidate.BackgroundImageLayout = ImageLayout.Center;
            btnAddCandidate.FlatStyle = FlatStyle.Popup;
            btnAddCandidate.Location = new Point(226, 360);
            btnAddCandidate.Name = "btnAddCandidate";
            btnAddCandidate.Size = new Size(42, 23);
            btnAddCandidate.TabIndex = 3;
            btnAddCandidate.UseVisualStyleBackColor = false;
            btnAddCandidate.Click += btnAddCandidate_Click;
            // 
            // btnRemoveCandidate
            // 
            btnRemoveCandidate.BackColor = Color.FromArgb(221, 121, 115);
            btnRemoveCandidate.FlatStyle = FlatStyle.Popup;
            btnRemoveCandidate.Font = new Font("Bahnschrift SemiBold SemiConden", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemoveCandidate.ForeColor = Color.White;
            btnRemoveCandidate.Image = Properties.Resources.trash;
            btnRemoveCandidate.ImageAlign = ContentAlignment.MiddleRight;
            btnRemoveCandidate.Location = new Point(48, 322);
            btnRemoveCandidate.Name = "btnRemoveCandidate";
            btnRemoveCandidate.Size = new Size(220, 29);
            btnRemoveCandidate.TabIndex = 3;
            btnRemoveCandidate.Text = "Remove";
            btnRemoveCandidate.TextAlign = ContentAlignment.MiddleLeft;
            btnRemoveCandidate.UseVisualStyleBackColor = false;
            btnRemoveCandidate.Click += btnRemoveCandidate_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(22, 455);
            label8.Name = "label8";
            label8.Size = new Size(47, 14);
            label8.TabIndex = 2;
            label8.Text = "Partylist";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(22, 395);
            label7.Name = "label7";
            label7.Size = new Size(29, 14);
            label7.TabIndex = 2;
            label7.Text = "Role";
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(235, 244, 253);
            pnlMain.Controls.Add(groupBox3);
            pnlMain.Controls.Add(groupBox1);
            pnlMain.Controls.Add(groupBox2);
            pnlMain.Location = new Point(165, 29);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(868, 575);
            pnlMain.TabIndex = 35;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 40, 190);
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1038, 23);
            panel1.TabIndex = 34;
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
            btnExit.Location = new Point(992, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(25, 19);
            btnExit.TabIndex = 37;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pnlRoomForm
            // 
            pnlRoomForm.BackgroundImage = Properties.Resources.inactive;
            pnlRoomForm.Controls.Add(label19);
            pnlRoomForm.Controls.Add(pictureBox1);
            pnlRoomForm.Location = new Point(-19, 176);
            pnlRoomForm.Name = "pnlRoomForm";
            pnlRoomForm.Size = new Size(179, 78);
            pnlRoomForm.TabIndex = 38;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.White;
            label19.Location = new Point(57, 53);
            label19.Name = "label19";
            label19.Size = new Size(63, 16);
            label19.TabIndex = 4;
            label19.Text = "Room Form";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.ROOM1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(67, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 38);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pnlRoomList
            // 
            pnlRoomList.BackgroundImage = Properties.Resources.inactive;
            pnlRoomList.Controls.Add(label20);
            pnlRoomList.Controls.Add(pictureBox2);
            pnlRoomList.Location = new Point(-19, 270);
            pnlRoomList.Name = "pnlRoomList";
            pnlRoomList.Size = new Size(179, 78);
            pnlRoomList.TabIndex = 39;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.Transparent;
            label20.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.White;
            label20.Location = new Point(60, 53);
            label20.Name = "label20";
            label20.Size = new Size(55, 16);
            label20.TabIndex = 5;
            label20.Text = "Room List";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.LIST;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(67, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 38);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pnlManageRoom
            // 
            pnlManageRoom.BackgroundImage = Properties.Resources.inactive;
            pnlManageRoom.BackgroundImageLayout = ImageLayout.Stretch;
            pnlManageRoom.Controls.Add(label22);
            pnlManageRoom.Controls.Add(pictureBox4);
            pnlManageRoom.Location = new Point(-19, 364);
            pnlManageRoom.Name = "pnlManageRoom";
            pnlManageRoom.Size = new Size(179, 78);
            pnlManageRoom.TabIndex = 41;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.Transparent;
            label22.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.White;
            label22.Location = new Point(51, 53);
            label22.Name = "label22";
            label22.Size = new Size(73, 16);
            label22.TabIndex = 6;
            label22.Text = "Manage Room";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = Properties.Resources.MANAGE;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(67, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(44, 38);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // ManageRoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 6, 79);
            BackgroundImage = Properties.Resources.BACKGROUND;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1038, 591);
            Controls.Add(pnlMain);
            Controls.Add(panel1);
            Controls.Add(pnlRoomForm);
            Controls.Add(pnlRoomList);
            Controls.Add(pnlManageRoom);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageRoomForm";
            Text = "Room";
            Load += ManageRoomForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            pnlMain.ResumeLayout(false);
            panel1.ResumeLayout(false);
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
        private TextBox txtName;
        private Label label1;
        private TextBox txtCode;
        private Label label2;
        private ListBox listMembers;
        private Label label3;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox txtRole;
        private Button btnRemoveRole;
        private Button btnAddRole;
        private TextBox txtPartylist;
        private Button btnRemovePartylist;
        private Button btnAddPartylist;
        private ListBox listRoles;
        private ListBox listPartylists;
        private Label label5;
        private GroupBox groupBox3;
        private ComboBox cmbPartylists;
        private Button btnSaveCandidate;
        private ComboBox cmbRoles;
        private ComboBox cmbCandidates;
        private Label label6;
        private ListBox listCandidates;
        private Button btnAddCandidate;
        private Button btnRemoveCandidate;
        private Label label8;
        private Label label7;
        private CheckBox chkModerator;
        private Button btnSave;
        private Button btnKick;
        private Button btnResults;
        private Panel pnlMain;
        private Panel panel1;
        private Panel pnlRoomForm;
        private Label label19;
        private PictureBox pictureBox1;
        private Panel pnlRoomList;
        private Label label20;
        private PictureBox pictureBox2;
        private Panel pnlManageRoom;
        private Label label22;
        private PictureBox pictureBox4;
        private Button btnExit;
        private CheckBox chkVerified;
    }
}