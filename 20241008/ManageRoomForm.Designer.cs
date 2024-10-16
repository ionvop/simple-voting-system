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
            btnSaveCandidate = new Button();
            cmbRoles = new ComboBox();
            cmbCandidates = new ComboBox();
            label6 = new Label();
            listCandidates = new ListBox();
            btnAddCandidate = new Button();
            btnRemoveCandidate = new Button();
            label8 = new Label();
            label7 = new Label();
            btnResults = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(20, 20);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnKick);
            groupBox1.Controls.Add(chkModerator);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(listMembers);
            groupBox1.Controls.Add(txtCode);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(20, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 360);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Room settings";
            // 
            // btnKick
            // 
            btnKick.Location = new Point(120, 320);
            btnKick.Name = "btnKick";
            btnKick.Size = new Size(75, 23);
            btnKick.TabIndex = 6;
            btnKick.Text = "Kick";
            btnKick.UseVisualStyleBackColor = true;
            // 
            // chkModerator
            // 
            chkModerator.AutoSize = true;
            chkModerator.Location = new Point(20, 320);
            chkModerator.Name = "chkModerator";
            chkModerator.Size = new Size(82, 19);
            chkModerator.TabIndex = 5;
            chkModerator.Text = "Moderator";
            chkModerator.UseVisualStyleBackColor = true;
            chkModerator.CheckedChanged += chkModerator_CheckedChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(100, 160);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save changes";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // listMembers
            // 
            listMembers.FormattingEnabled = true;
            listMembers.ItemHeight = 15;
            listMembers.Location = new Point(20, 220);
            listMembers.Name = "listMembers";
            listMembers.Size = new Size(180, 94);
            listMembers.TabIndex = 2;
            listMembers.SelectedIndexChanged += listMembers_SelectedIndexChanged;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(20, 120);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(180, 23);
            txtCode.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(20, 60);
            txtName.Name = "txtName";
            txtName.Size = new Size(180, 23);
            txtName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 200);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Members";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 100);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 2;
            label2.Text = "Room code";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 40);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 2;
            label1.Text = "Room name";
            // 
            // groupBox2
            // 
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
            groupBox2.Location = new Point(260, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(240, 400);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Manage room";
            // 
            // txtPartylist
            // 
            txtPartylist.Location = new Point(20, 360);
            txtPartylist.Name = "txtPartylist";
            txtPartylist.Size = new Size(140, 23);
            txtPartylist.TabIndex = 3;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(20, 180);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(140, 23);
            txtRole.TabIndex = 3;
            // 
            // btnRemovePartylist
            // 
            btnRemovePartylist.Location = new Point(20, 340);
            btnRemovePartylist.Name = "btnRemovePartylist";
            btnRemovePartylist.Size = new Size(200, 23);
            btnRemovePartylist.TabIndex = 3;
            btnRemovePartylist.Text = "Remove";
            btnRemovePartylist.UseVisualStyleBackColor = true;
            btnRemovePartylist.Click += btnRemovePartylist_Click;
            // 
            // btnRemoveRole
            // 
            btnRemoveRole.Location = new Point(20, 160);
            btnRemoveRole.Name = "btnRemoveRole";
            btnRemoveRole.Size = new Size(200, 23);
            btnRemoveRole.TabIndex = 3;
            btnRemoveRole.Text = "Remove";
            btnRemoveRole.UseVisualStyleBackColor = true;
            btnRemoveRole.Click += btnRemoveRole_Click;
            // 
            // btnAddPartylist
            // 
            btnAddPartylist.Location = new Point(160, 360);
            btnAddPartylist.Name = "btnAddPartylist";
            btnAddPartylist.Size = new Size(60, 23);
            btnAddPartylist.TabIndex = 3;
            btnAddPartylist.Text = "Add";
            btnAddPartylist.UseVisualStyleBackColor = true;
            btnAddPartylist.Click += btnAddPartylist_Click;
            // 
            // btnAddRole
            // 
            btnAddRole.Location = new Point(160, 180);
            btnAddRole.Name = "btnAddRole";
            btnAddRole.Size = new Size(60, 23);
            btnAddRole.TabIndex = 3;
            btnAddRole.Text = "Add";
            btnAddRole.UseVisualStyleBackColor = true;
            btnAddRole.Click += btnAddRole_Click;
            // 
            // listRoles
            // 
            listRoles.FormattingEnabled = true;
            listRoles.ItemHeight = 15;
            listRoles.Location = new Point(20, 60);
            listRoles.Name = "listRoles";
            listRoles.Size = new Size(200, 94);
            listRoles.TabIndex = 2;
            // 
            // listPartylists
            // 
            listPartylists.FormattingEnabled = true;
            listPartylists.ItemHeight = 15;
            listPartylists.Location = new Point(20, 240);
            listPartylists.Name = "listPartylists";
            listPartylists.Size = new Size(200, 94);
            listPartylists.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 220);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 3;
            label5.Text = "Partylists";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 40);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 3;
            label4.Text = "Roles";
            // 
            // groupBox3
            // 
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
            groupBox3.Location = new Point(520, 20);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(260, 400);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Manage candidates";
            // 
            // cmbPartylists
            // 
            cmbPartylists.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPartylists.FormattingEnabled = true;
            cmbPartylists.Location = new Point(20, 300);
            cmbPartylists.Name = "cmbPartylists";
            cmbPartylists.Size = new Size(220, 23);
            cmbPartylists.TabIndex = 4;
            // 
            // btnSaveCandidate
            // 
            btnSaveCandidate.Location = new Point(140, 360);
            btnSaveCandidate.Name = "btnSaveCandidate";
            btnSaveCandidate.Size = new Size(100, 23);
            btnSaveCandidate.TabIndex = 0;
            btnSaveCandidate.Text = "Save changes";
            btnSaveCandidate.UseVisualStyleBackColor = true;
            btnSaveCandidate.Click += btnSaveCandidate_Click;
            // 
            // cmbRoles
            // 
            cmbRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(20, 240);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(220, 23);
            cmbRoles.TabIndex = 4;
            // 
            // cmbCandidates
            // 
            cmbCandidates.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCandidates.FormattingEnabled = true;
            cmbCandidates.Location = new Point(20, 180);
            cmbCandidates.Name = "cmbCandidates";
            cmbCandidates.Size = new Size(160, 23);
            cmbCandidates.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 40);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 3;
            label6.Text = "Candidates";
            // 
            // listCandidates
            // 
            listCandidates.FormattingEnabled = true;
            listCandidates.ItemHeight = 15;
            listCandidates.Location = new Point(20, 60);
            listCandidates.Name = "listCandidates";
            listCandidates.Size = new Size(220, 94);
            listCandidates.TabIndex = 2;
            listCandidates.SelectedIndexChanged += listCandidates_SelectedIndexChanged;
            // 
            // btnAddCandidate
            // 
            btnAddCandidate.Location = new Point(180, 180);
            btnAddCandidate.Name = "btnAddCandidate";
            btnAddCandidate.Size = new Size(60, 23);
            btnAddCandidate.TabIndex = 3;
            btnAddCandidate.Text = "Add";
            btnAddCandidate.UseVisualStyleBackColor = true;
            btnAddCandidate.Click += btnAddCandidate_Click;
            // 
            // btnRemoveCandidate
            // 
            btnRemoveCandidate.Location = new Point(20, 160);
            btnRemoveCandidate.Name = "btnRemoveCandidate";
            btnRemoveCandidate.Size = new Size(220, 23);
            btnRemoveCandidate.TabIndex = 3;
            btnRemoveCandidate.Text = "Remove";
            btnRemoveCandidate.UseVisualStyleBackColor = true;
            btnRemoveCandidate.Click += btnRemoveCandidate_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 280);
            label8.Name = "label8";
            label8.Size = new Size(49, 15);
            label8.TabIndex = 2;
            label8.Text = "Partylist";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 220);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 2;
            label7.Text = "Role";
            // 
            // btnResults
            // 
            btnResults.Location = new Point(20, 360);
            btnResults.Name = "btnResults";
            btnResults.Size = new Size(100, 23);
            btnResults.TabIndex = 0;
            btnResults.Text = "View results";
            btnResults.UseVisualStyleBackColor = true;
            btnResults.Click += btnResults_Click;
            // 
            // ManageRoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnBack);
            Name = "ManageRoomForm";
            Text = "Room";
            Load += ManageRoomForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
    }
}