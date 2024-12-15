namespace _20241008
{
    partial class RoomListForm
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
            listRooms = new ListBox();
            btnCreateRoom = new Button();
            label1 = new Label();
            txtRoomCode = new TextBox();
            btnJoinRoom = new Button();
            grpProfile = new GroupBox();
            btnLogout = new Button();
            btnSave = new Button();
            label3 = new Label();
            txtFirstname = new TextBox();
            label4 = new Label();
            txtVotersId = new TextBox();
            txtUsername = new TextBox();
            label5 = new Label();
            label8 = new Label();
            txtPhone = new TextBox();
            label11 = new Label();
            label6 = new Label();
            txtLastname = new TextBox();
            txtEmail = new TextBox();
            txtRepassword = new TextBox();
            txtOldPassword = new TextBox();
            label9 = new Label();
            label7 = new Label();
            grpPass = new GroupBox();
            btnChangePassword = new Button();
            label2 = new Label();
            txtNewPassword = new TextBox();
            grpRoom = new GroupBox();
            btnRemove = new Button();
            label10 = new Label();
            listCreatedRooms = new ListBox();
            btnOpenCreatedRoom = new Button();
            btnOpen = new Button();
            panel1 = new Panel();
            btnExit = new Button();
            panel2 = new Panel();
            pnlMain = new Panel();
            pictureBox1 = new PictureBox();
            pnlRoomForm = new Panel();
            label14 = new Label();
            pnlRoomList = new Panel();
            label15 = new Label();
            pictureBox2 = new PictureBox();
            pnlManageRoom = new Panel();
            label17 = new Label();
            pictureBox4 = new PictureBox();
            lblStatus = new Label();
            grpProfile.SuspendLayout();
            grpPass.SuspendLayout();
            grpRoom.SuspendLayout();
            panel1.SuspendLayout();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlRoomForm.SuspendLayout();
            pnlRoomList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlManageRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // listRooms
            // 
            listRooms.BackColor = Color.FromArgb(251, 211, 179);
            listRooms.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listRooms.FormattingEnabled = true;
            listRooms.ItemHeight = 14;
            listRooms.Location = new Point(21, 31);
            listRooms.Name = "listRooms";
            listRooms.Size = new Size(269, 186);
            listRooms.TabIndex = 0;
            // 
            // btnCreateRoom
            // 
            btnCreateRoom.BackColor = Color.FromArgb(51, 178, 73);
            btnCreateRoom.FlatStyle = FlatStyle.Popup;
            btnCreateRoom.Font = new Font("Bahnschrift SemiBold SemiConden", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateRoom.ForeColor = Color.White;
            btnCreateRoom.Image = Properties.Resources.square_plus;
            btnCreateRoom.ImageAlign = ContentAlignment.MiddleRight;
            btnCreateRoom.Location = new Point(21, 510);
            btnCreateRoom.Name = "btnCreateRoom";
            btnCreateRoom.Size = new Size(147, 37);
            btnCreateRoom.TabIndex = 1;
            btnCreateRoom.Text = "Create new room";
            btnCreateRoom.TextAlign = ContentAlignment.MiddleLeft;
            btnCreateRoom.UseVisualStyleBackColor = false;
            btnCreateRoom.Click += btnCreateRoom_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 250);
            label1.Name = "label1";
            label1.Size = new Size(61, 14);
            label1.TabIndex = 2;
            label1.Text = "Room code";
            // 
            // txtRoomCode
            // 
            txtRoomCode.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtRoomCode.Location = new Point(21, 267);
            txtRoomCode.Name = "txtRoomCode";
            txtRoomCode.Size = new Size(189, 22);
            txtRoomCode.TabIndex = 3;
            // 
            // btnJoinRoom
            // 
            btnJoinRoom.BackColor = Color.FromArgb(90, 219, 181);
            btnJoinRoom.FlatStyle = FlatStyle.Popup;
            btnJoinRoom.Font = new Font("Bahnschrift SemiBold SemiConden", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnJoinRoom.ForeColor = Color.White;
            btnJoinRoom.Location = new Point(214, 265);
            btnJoinRoom.Name = "btnJoinRoom";
            btnJoinRoom.Size = new Size(75, 23);
            btnJoinRoom.TabIndex = 4;
            btnJoinRoom.Text = "Join room";
            btnJoinRoom.UseVisualStyleBackColor = false;
            btnJoinRoom.Click += btnJoinRoom_Click;
            // 
            // grpProfile
            // 
            grpProfile.BackColor = Color.White;
            grpProfile.Controls.Add(btnLogout);
            grpProfile.Controls.Add(btnSave);
            grpProfile.Controls.Add(lblStatus);
            grpProfile.Controls.Add(label3);
            grpProfile.Controls.Add(txtFirstname);
            grpProfile.Controls.Add(label4);
            grpProfile.Controls.Add(txtVotersId);
            grpProfile.Controls.Add(txtUsername);
            grpProfile.Controls.Add(label5);
            grpProfile.Controls.Add(label8);
            grpProfile.Controls.Add(txtPhone);
            grpProfile.Controls.Add(label11);
            grpProfile.Controls.Add(label6);
            grpProfile.Controls.Add(txtLastname);
            grpProfile.Controls.Add(txtEmail);
            grpProfile.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            grpProfile.Location = new Point(15, 3);
            grpProfile.Name = "grpProfile";
            grpProfile.Size = new Size(260, 565);
            grpProfile.TabIndex = 5;
            grpProfile.TabStop = false;
            grpProfile.Text = "Profile";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(221, 121, 115);
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Bahnschrift SemiBold SemiConden", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = Properties.Resources.log_out;
            btnLogout.ImageAlign = ContentAlignment.MiddleRight;
            btnLogout.Location = new Point(20, 510);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 37);
            btnLogout.TabIndex = 21;
            btnLogout.Text = "Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(51, 178, 73);
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Bahnschrift SemiBold SemiConden", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Image = Properties.Resources.save;
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(140, 510);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 37);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save changes";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(20, 73);
            label3.Name = "label3";
            label3.Size = new Size(59, 14);
            label3.TabIndex = 7;
            label3.Text = "First name";
            // 
            // txtFirstname
            // 
            txtFirstname.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstname.Location = new Point(20, 93);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(220, 22);
            txtFirstname.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 136);
            label4.Name = "label4";
            label4.Size = new Size(58, 14);
            label4.TabIndex = 13;
            label4.Text = "Last name";
            // 
            // txtVotersId
            // 
            txtVotersId.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtVotersId.Location = new Point(20, 388);
            txtVotersId.Name = "txtVotersId";
            txtVotersId.Size = new Size(220, 22);
            txtVotersId.TabIndex = 16;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(20, 332);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(220, 22);
            txtUsername.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(20, 200);
            label5.Name = "label5";
            label5.Size = new Size(34, 14);
            label5.TabIndex = 12;
            label5.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(20, 256);
            label8.Name = "label8";
            label8.Size = new Size(37, 14);
            label8.TabIndex = 11;
            label8.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(20, 276);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(220, 22);
            txtPhone.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(20, 368);
            label11.Name = "label11";
            label11.Size = new Size(50, 14);
            label11.TabIndex = 10;
            label11.Text = "Voters ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(20, 312);
            label6.Name = "label6";
            label6.Size = new Size(55, 14);
            label6.TabIndex = 10;
            label6.Text = "Username";
            // 
            // txtLastname
            // 
            txtLastname.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastname.Location = new Point(20, 156);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(220, 22);
            txtLastname.TabIndex = 19;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(20, 220);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(220, 22);
            txtEmail.TabIndex = 18;
            // 
            // txtRepassword
            // 
            txtRepassword.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtRepassword.Location = new Point(15, 256);
            txtRepassword.Name = "txtRepassword";
            txtRepassword.Size = new Size(220, 22);
            txtRepassword.TabIndex = 14;
            txtRepassword.UseSystemPasswordChar = true;
            // 
            // txtOldPassword
            // 
            txtOldPassword.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtOldPassword.Location = new Point(15, 116);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Size = new Size(220, 22);
            txtOldPassword.TabIndex = 15;
            txtOldPassword.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(15, 235);
            label9.Name = "label9";
            label9.Size = new Size(93, 14);
            label9.TabIndex = 8;
            label9.Text = "Confirm password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(15, 93);
            label7.Name = "label7";
            label7.Size = new Size(53, 14);
            label7.TabIndex = 9;
            label7.Text = "Password";
            // 
            // grpPass
            // 
            grpPass.BackColor = Color.White;
            grpPass.Controls.Add(btnChangePassword);
            grpPass.Controls.Add(label2);
            grpPass.Controls.Add(txtNewPassword);
            grpPass.Controls.Add(txtRepassword);
            grpPass.Controls.Add(label7);
            grpPass.Controls.Add(txtOldPassword);
            grpPass.Controls.Add(label9);
            grpPass.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            grpPass.Location = new Point(280, 3);
            grpPass.Name = "grpPass";
            grpPass.Size = new Size(263, 565);
            grpPass.TabIndex = 16;
            grpPass.TabStop = false;
            grpPass.Text = "Change password";
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.FromArgb(255, 189, 3);
            btnChangePassword.FlatStyle = FlatStyle.Popup;
            btnChangePassword.Font = new Font("Bahnschrift SemiBold SemiConden", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Image = Properties.Resources.edit;
            btnChangePassword.ImageAlign = ContentAlignment.MiddleRight;
            btnChangePassword.Location = new Point(65, 510);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(138, 37);
            btnChangePassword.TabIndex = 6;
            btnChangePassword.Text = "Change password";
            btnChangePassword.TextAlign = ContentAlignment.MiddleLeft;
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 164);
            label2.Name = "label2";
            label2.Size = new Size(77, 14);
            label2.TabIndex = 9;
            label2.Text = "New password";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewPassword.Location = new Point(15, 180);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(220, 22);
            txtNewPassword.TabIndex = 15;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // grpRoom
            // 
            grpRoom.BackColor = Color.White;
            grpRoom.Controls.Add(btnRemove);
            grpRoom.Controls.Add(label10);
            grpRoom.Controls.Add(listCreatedRooms);
            grpRoom.Controls.Add(listRooms);
            grpRoom.Controls.Add(btnCreateRoom);
            grpRoom.Controls.Add(label1);
            grpRoom.Controls.Add(btnOpenCreatedRoom);
            grpRoom.Controls.Add(btnOpen);
            grpRoom.Controls.Add(btnJoinRoom);
            grpRoom.Controls.Add(txtRoomCode);
            grpRoom.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            grpRoom.Location = new Point(549, 3);
            grpRoom.Name = "grpRoom";
            grpRoom.Size = new Size(304, 565);
            grpRoom.TabIndex = 17;
            grpRoom.TabStop = false;
            grpRoom.Text = "Room list";
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(221, 121, 115);
            btnRemove.FlatStyle = FlatStyle.Popup;
            btnRemove.Font = new Font("Bahnschrift SemiBold SemiConden", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(81, 225);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "Leave";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(21, 292);
            label10.Name = "label10";
            label10.Size = new Size(60, 14);
            label10.TabIndex = 6;
            label10.Text = "Your rooms";
            // 
            // listCreatedRooms
            // 
            listCreatedRooms.BackColor = Color.FromArgb(251, 211, 179);
            listCreatedRooms.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listCreatedRooms.FormattingEnabled = true;
            listCreatedRooms.ItemHeight = 14;
            listCreatedRooms.Location = new Point(21, 312);
            listCreatedRooms.Name = "listCreatedRooms";
            listCreatedRooms.Size = new Size(269, 186);
            listCreatedRooms.TabIndex = 5;
            // 
            // btnOpenCreatedRoom
            // 
            btnOpenCreatedRoom.BackColor = Color.FromArgb(90, 219, 181);
            btnOpenCreatedRoom.FlatStyle = FlatStyle.Popup;
            btnOpenCreatedRoom.Font = new Font("Bahnschrift SemiBold SemiConden", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnOpenCreatedRoom.ForeColor = Color.White;
            btnOpenCreatedRoom.Image = Properties.Resources.external_link;
            btnOpenCreatedRoom.ImageAlign = ContentAlignment.MiddleRight;
            btnOpenCreatedRoom.Location = new Point(173, 510);
            btnOpenCreatedRoom.Name = "btnOpenCreatedRoom";
            btnOpenCreatedRoom.Size = new Size(116, 37);
            btnOpenCreatedRoom.TabIndex = 4;
            btnOpenCreatedRoom.Text = "Open";
            btnOpenCreatedRoom.TextAlign = ContentAlignment.MiddleLeft;
            btnOpenCreatedRoom.UseVisualStyleBackColor = false;
            btnOpenCreatedRoom.Click += btnOpenCreatedRoom_Click;
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.FromArgb(90, 219, 181);
            btnOpen.FlatStyle = FlatStyle.Popup;
            btnOpen.Font = new Font("Bahnschrift SemiBold SemiConden", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnOpen.ForeColor = Color.White;
            btnOpen.Location = new Point(161, 225);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 4;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 40, 190);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-19, -15);
            panel1.Name = "panel1";
            panel1.Size = new Size(1456, 38);
            panel1.TabIndex = 18;
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
            btnExit.Location = new Point(1012, 16);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(25, 19);
            btnExit.TabIndex = 37;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.close;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(1293, 17);
            panel2.Name = "panel2";
            panel2.Size = new Size(24, 21);
            panel2.TabIndex = 18;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(235, 244, 253);
            pnlMain.Controls.Add(grpRoom);
            pnlMain.Controls.Add(grpProfile);
            pnlMain.Controls.Add(grpPass);
            pnlMain.Location = new Point(165, 29);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(867, 575);
            pnlMain.TabIndex = 19;
            pnlMain.Paint += pnlMain_Paint;
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
            // pnlRoomForm
            // 
            pnlRoomForm.BackgroundImage = Properties.Resources.inactive;
            pnlRoomForm.BackgroundImageLayout = ImageLayout.Stretch;
            pnlRoomForm.Controls.Add(label14);
            pnlRoomForm.Controls.Add(pictureBox1);
            pnlRoomForm.Location = new Point(-19, 176);
            pnlRoomForm.Name = "pnlRoomForm";
            pnlRoomForm.Size = new Size(179, 78);
            pnlRoomForm.TabIndex = 22;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(57, 53);
            label14.Name = "label14";
            label14.Size = new Size(63, 16);
            label14.TabIndex = 4;
            label14.Text = "Room Form";
            // 
            // pnlRoomList
            // 
            pnlRoomList.BackgroundImage = Properties.Resources.inactive;
            pnlRoomList.Controls.Add(label15);
            pnlRoomList.Controls.Add(pictureBox2);
            pnlRoomList.Location = new Point(-19, 270);
            pnlRoomList.Name = "pnlRoomList";
            pnlRoomList.Size = new Size(179, 78);
            pnlRoomList.TabIndex = 23;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(60, 53);
            label15.Name = "label15";
            label15.Size = new Size(55, 16);
            label15.TabIndex = 5;
            label15.Text = "Room List";
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
            pnlManageRoom.Controls.Add(label17);
            pnlManageRoom.Controls.Add(pictureBox4);
            pnlManageRoom.Location = new Point(-19, 364);
            pnlManageRoom.Name = "pnlManageRoom";
            pnlManageRoom.Size = new Size(179, 78);
            pnlManageRoom.TabIndex = 25;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label17.ForeColor = Color.White;
            label17.Location = new Point(51, 53);
            label17.Name = "label17";
            label17.Size = new Size(73, 16);
            label17.TabIndex = 6;
            label17.Text = "Manage Room";
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
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Bahnschrift SemiLight SemiConde", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.Location = new Point(20, 420);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(158, 14);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Account status: Not yet verified";
            // 
            // RoomListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScrollMargin = new Size(0, 57);
            BackColor = Color.FromArgb(8, 6, 79);
            BackgroundImage = Properties.Resources.BACKGROUND;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1038, 591);
            Controls.Add(panel1);
            Controls.Add(pnlMain);
            Controls.Add(pnlRoomForm);
            Controls.Add(pnlRoomList);
            Controls.Add(pnlManageRoom);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "RoomListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Room List";
            Load += RoomListForm_Load;
            grpProfile.ResumeLayout(false);
            grpProfile.PerformLayout();
            grpPass.ResumeLayout(false);
            grpPass.PerformLayout();
            grpRoom.ResumeLayout(false);
            grpRoom.PerformLayout();
            panel1.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlRoomForm.ResumeLayout(false);
            pnlRoomForm.PerformLayout();
            pnlRoomList.ResumeLayout(false);
            pnlRoomList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlManageRoom.ResumeLayout(false);
            pnlManageRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listRooms;
        private Button btnCreateRoom;
        private Label label1;
        private TextBox txtRoomCode;
        private Button btnJoinRoom;
        private GroupBox grpProfile;
        private GroupBox grpPass;
        private Button btnSave;
        private Label label3;
        private TextBox txtFirstname;
        private Label label4;
        private TextBox txtUsername;
        private Label label5;
        private Label label8;
        private TextBox txtPhone;
        private Label label6;
        private TextBox txtLastname;
        private TextBox txtEmail;
        private TextBox txtRepassword;
        private TextBox txtOldPassword;
        private Label label9;
        private Label label7;
        private Button btnChangePassword;
        private Label label2;
        private TextBox txtNewPassword;
        private GroupBox grpRoom;
        private ListBox listCreatedRooms;
        private Label label10;
        private Button btnLogout;
        private TextBox txtVotersId;
        private Label label11;
        private Button btnOpen;
        private Button btnOpenCreatedRoom;
        private Button btnRemove;
        private Panel panel1;
        private Panel pnlMain;
        private PictureBox pictureBox1;
        private Panel pnlRoomForm;
        private Label label14;
        private Panel pnlRoomList;
        private Label label15;
        private PictureBox pictureBox2;
        private Panel pnlManageRoom;
        private Label label17;
        private PictureBox pictureBox4;
        private Panel panel2;
        private Button btnExit;
        private Label lblStatus;
    }
}