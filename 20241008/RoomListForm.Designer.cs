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
            groupBox1 = new GroupBox();
            btnSave = new Button();
            label3 = new Label();
            txtFirstname = new TextBox();
            label4 = new Label();
            txtUsername = new TextBox();
            label5 = new Label();
            label8 = new Label();
            txtPhone = new TextBox();
            label6 = new Label();
            txtLastname = new TextBox();
            txtEmail = new TextBox();
            txtRepassword = new TextBox();
            txtOldPassword = new TextBox();
            label9 = new Label();
            label7 = new Label();
            groupBox2 = new GroupBox();
            btnChangePassword = new Button();
            label2 = new Label();
            txtNewPassword = new TextBox();
            groupBox3 = new GroupBox();
            label10 = new Label();
            listCreatedRooms = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // listRooms
            // 
            listRooms.FormattingEnabled = true;
            listRooms.ItemHeight = 15;
            listRooms.Location = new Point(20, 40);
            listRooms.Name = "listRooms";
            listRooms.Size = new Size(220, 109);
            listRooms.TabIndex = 0;
            // 
            // btnCreateRoom
            // 
            btnCreateRoom.Location = new Point(20, 300);
            btnCreateRoom.Name = "btnCreateRoom";
            btnCreateRoom.Size = new Size(220, 23);
            btnCreateRoom.TabIndex = 1;
            btnCreateRoom.Text = "Create new room";
            btnCreateRoom.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 340);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 2;
            label1.Text = "Room code";
            // 
            // txtRoomCode
            // 
            txtRoomCode.Location = new Point(20, 360);
            txtRoomCode.Name = "txtRoomCode";
            txtRoomCode.Size = new Size(120, 23);
            txtRoomCode.TabIndex = 3;
            // 
            // btnJoinRoom
            // 
            btnJoinRoom.Location = new Point(160, 360);
            btnJoinRoom.Name = "btnJoinRoom";
            btnJoinRoom.Size = new Size(75, 23);
            btnJoinRoom.TabIndex = 4;
            btnJoinRoom.Text = "Join room";
            btnJoinRoom.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtFirstname);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtLastname);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Location = new Point(20, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(260, 400);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Profile";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(140, 260);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save changes";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 40);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 7;
            label3.Text = "First name";
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(20, 60);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(100, 23);
            txtFirstname.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(140, 40);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 13;
            label4.Text = "Last name";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(20, 260);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 140);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 12;
            label5.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(140, 140);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 11;
            label8.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(140, 160);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 240);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 10;
            label6.Text = "Username";
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(140, 60);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(100, 23);
            txtLastname.TabIndex = 19;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(20, 160);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 18;
            // 
            // txtRepassword
            // 
            txtRepassword.Location = new Point(40, 260);
            txtRepassword.Name = "txtRepassword";
            txtRepassword.Size = new Size(100, 23);
            txtRepassword.TabIndex = 14;
            txtRepassword.UseSystemPasswordChar = true;
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(40, 60);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Size = new Size(100, 23);
            txtOldPassword.TabIndex = 15;
            txtOldPassword.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(40, 240);
            label9.Name = "label9";
            label9.Size = new Size(104, 15);
            label9.TabIndex = 8;
            label9.Text = "Confirm password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 40);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 9;
            label7.Text = "Password";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnChangePassword);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtNewPassword);
            groupBox2.Controls.Add(txtRepassword);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtOldPassword);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(300, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 400);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Change password";
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(40, 340);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(120, 23);
            btnChangePassword.TabIndex = 6;
            btnChangePassword.Text = "Change password";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 140);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 9;
            label2.Text = "New password";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(40, 160);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(100, 23);
            txtNewPassword.TabIndex = 15;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(listCreatedRooms);
            groupBox3.Controls.Add(listRooms);
            groupBox3.Controls.Add(btnCreateRoom);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(btnJoinRoom);
            groupBox3.Controls.Add(txtRoomCode);
            groupBox3.Location = new Point(520, 20);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(260, 400);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Room list";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 180);
            label10.Name = "label10";
            label10.Size = new Size(68, 15);
            label10.TabIndex = 6;
            label10.Text = "Your rooms";
            // 
            // listCreatedRooms
            // 
            listCreatedRooms.FormattingEnabled = true;
            listCreatedRooms.ItemHeight = 15;
            listCreatedRooms.Location = new Point(20, 200);
            listCreatedRooms.Name = "listCreatedRooms";
            listCreatedRooms.Size = new Size(220, 94);
            listCreatedRooms.TabIndex = 5;
            // 
            // RoomListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "RoomListForm";
            Text = "Room List";
            Load += RoomListForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listRooms;
        private Button btnCreateRoom;
        private Label label1;
        private TextBox txtRoomCode;
        private Button btnJoinRoom;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
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
        private GroupBox groupBox3;
        private ListBox listCreatedRooms;
        private Label label10;
    }
}