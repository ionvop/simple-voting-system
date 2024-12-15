namespace _20241008
{
    partial class LoginForm
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
            grpLogin = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtLoginPassword = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            label13 = new Label();
            label10 = new Label();
            btnLogin = new Button();
            txtLoginUsername = new TextBox();
            grpReg = new GroupBox();
            txtRegisterRepassword = new TextBox();
            txtRegisterPassword = new TextBox();
            panel2 = new Panel();
            label2 = new Label();
            label12 = new Label();
            label11 = new Label();
            btnRegister = new Button();
            txtRegisterUsername = new TextBox();
            txtRegisterPhone = new TextBox();
            txtRegisterEmail = new TextBox();
            txtRegisterLastname = new TextBox();
            txtRegisterFirstname = new TextBox();
            panel3 = new Panel();
            btnExit = new Button();
            panel4 = new Panel();
            grpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            grpReg.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // grpLogin
            // 
            grpLogin.BackColor = Color.White;
            grpLogin.Controls.Add(pictureBox2);
            grpLogin.Controls.Add(pictureBox1);
            grpLogin.Controls.Add(txtLoginPassword);
            grpLogin.Controls.Add(panel1);
            grpLogin.Controls.Add(label13);
            grpLogin.Controls.Add(label10);
            grpLogin.Controls.Add(btnLogin);
            grpLogin.Controls.Add(txtLoginUsername);
            grpLogin.Location = new Point(269, 59);
            grpLogin.Name = "grpLogin";
            grpLogin.Size = new Size(240, 315);
            grpLogin.TabIndex = 0;
            grpLogin.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.BackgroundImage = Properties.Resources.user;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(40, 79);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(23, 23);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImage = Properties.Resources.padlock1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(40, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 23);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.ForeColor = Color.Black;
            txtLoginPassword.Location = new Point(62, 128);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.PlaceholderText = "Password";
            txtLoginPassword.Size = new Size(138, 23);
            txtLoginPassword.TabIndex = 8;
            txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 40, 190);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -52);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 93);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(41, 61);
            label1.Name = "label1";
            label1.Size = new Size(159, 27);
            label1.TabIndex = 1;
            label1.Text = "VOTER LOGIN";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Black;
            label13.Location = new Point(62, 272);
            label13.Name = "label13";
            label13.Size = new Size(131, 15);
            label13.TabIndex = 6;
            label13.Text = "Don't have an account?";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Blue;
            label10.Location = new Point(87, 290);
            label10.Name = "label10";
            label10.Size = new Size(75, 15);
            label10.TabIndex = 3;
            label10.Text = "Register now";
            label10.Click += lblRegister;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(15, 110, 251);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(40, 186);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(161, 31);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtLoginUsername
            // 
            txtLoginUsername.ForeColor = Color.Black;
            txtLoginUsername.Location = new Point(62, 79);
            txtLoginUsername.Name = "txtLoginUsername";
            txtLoginUsername.PlaceholderText = "Username";
            txtLoginUsername.Size = new Size(139, 23);
            txtLoginUsername.TabIndex = 2;
            // 
            // grpReg
            // 
            grpReg.BackColor = Color.White;
            grpReg.Controls.Add(txtRegisterRepassword);
            grpReg.Controls.Add(txtRegisterPassword);
            grpReg.Controls.Add(panel2);
            grpReg.Controls.Add(label12);
            grpReg.Controls.Add(label11);
            grpReg.Controls.Add(btnRegister);
            grpReg.Controls.Add(txtRegisterUsername);
            grpReg.Controls.Add(txtRegisterPhone);
            grpReg.Controls.Add(txtRegisterEmail);
            grpReg.Controls.Add(txtRegisterLastname);
            grpReg.Controls.Add(txtRegisterFirstname);
            grpReg.Location = new Point(162, 37);
            grpReg.Name = "grpReg";
            grpReg.Size = new Size(440, 380);
            grpReg.TabIndex = 1;
            grpReg.TabStop = false;
            // 
            // txtRegisterRepassword
            // 
            txtRegisterRepassword.ForeColor = Color.Black;
            txtRegisterRepassword.Location = new Point(240, 183);
            txtRegisterRepassword.Name = "txtRegisterRepassword";
            txtRegisterRepassword.PlaceholderText = "Confirm Password";
            txtRegisterRepassword.Size = new Size(160, 23);
            txtRegisterRepassword.TabIndex = 10;
            txtRegisterRepassword.UseSystemPasswordChar = true;
            // 
            // txtRegisterPassword
            // 
            txtRegisterPassword.ForeColor = Color.Black;
            txtRegisterPassword.Location = new Point(240, 132);
            txtRegisterPassword.Name = "txtRegisterPassword";
            txtRegisterPassword.PlaceholderText = "Password";
            txtRegisterPassword.Size = new Size(160, 23);
            txtRegisterPassword.TabIndex = 9;
            txtRegisterPassword.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 40, 190);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(-25, -46);
            panel2.Name = "panel2";
            panel2.Size = new Size(472, 93);
            panel2.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(158, 59);
            label2.Name = "label2";
            label2.Size = new Size(191, 27);
            label2.TabIndex = 1;
            label2.Text = "REGISTER FORM";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Black;
            label12.Location = new Point(124, 340);
            label12.Name = "label12";
            label12.Size = new Size(142, 15);
            label12.TabIndex = 5;
            label12.Text = "Already have an account?";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Blue;
            label11.Location = new Point(266, 340);
            label11.Name = "label11";
            label11.Size = new Size(65, 15);
            label11.TabIndex = 4;
            label11.Text = "Login Now";
            label11.Click += label11_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(15, 110, 251);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(124, 294);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(204, 28);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtRegisterUsername
            // 
            txtRegisterUsername.ForeColor = Color.Black;
            txtRegisterUsername.Location = new Point(240, 83);
            txtRegisterUsername.Name = "txtRegisterUsername";
            txtRegisterUsername.PlaceholderText = "Username";
            txtRegisterUsername.Size = new Size(160, 23);
            txtRegisterUsername.TabIndex = 2;
            // 
            // txtRegisterPhone
            // 
            txtRegisterPhone.ForeColor = Color.Black;
            txtRegisterPhone.Location = new Point(40, 234);
            txtRegisterPhone.Name = "txtRegisterPhone";
            txtRegisterPhone.PlaceholderText = "Phone";
            txtRegisterPhone.Size = new Size(160, 23);
            txtRegisterPhone.TabIndex = 2;
            // 
            // txtRegisterEmail
            // 
            txtRegisterEmail.ForeColor = Color.Black;
            txtRegisterEmail.Location = new Point(40, 183);
            txtRegisterEmail.Name = "txtRegisterEmail";
            txtRegisterEmail.PlaceholderText = "Email";
            txtRegisterEmail.Size = new Size(160, 23);
            txtRegisterEmail.TabIndex = 2;
            // 
            // txtRegisterLastname
            // 
            txtRegisterLastname.ForeColor = Color.Black;
            txtRegisterLastname.Location = new Point(40, 132);
            txtRegisterLastname.Name = "txtRegisterLastname";
            txtRegisterLastname.PlaceholderText = "Last Name";
            txtRegisterLastname.Size = new Size(160, 23);
            txtRegisterLastname.TabIndex = 2;
            // 
            // txtRegisterFirstname
            // 
            txtRegisterFirstname.ForeColor = Color.Black;
            txtRegisterFirstname.Location = new Point(40, 83);
            txtRegisterFirstname.Name = "txtRegisterFirstname";
            txtRegisterFirstname.PlaceholderText = "First Name";
            txtRegisterFirstname.Size = new Size(160, 23);
            txtRegisterFirstname.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(33, 40, 190);
            panel3.Controls.Add(btnExit);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 22);
            panel3.TabIndex = 35;
            panel3.MouseDown += Status_Down;
            panel3.MouseMove += Status_Move;
            panel3.MouseUp += Status_Up;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.BackgroundImage = Properties.Resources.close;
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Location = new Point(772, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(25, 19);
            btnExit.TabIndex = 36;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.close;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(1293, 17);
            panel4.Name = "panel4";
            panel4.Size = new Size(24, 21);
            panel4.TabIndex = 19;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 6, 79);
            BackgroundImage = Properties.Resources.VOTEROO;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(grpLogin);
            Controls.Add(grpReg);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Login";
            grpLogin.ResumeLayout(false);
            grpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grpReg.ResumeLayout(false);
            grpReg.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpLogin;
        private TextBox txtLoginUsername;
        private Button btnLogin;
        private GroupBox grpReg;
        private TextBox txtRegisterLastname;
        private TextBox txtRegisterFirstname;
        private TextBox txtRegisterUsername;
        private TextBox txtRegisterEmail;
        private Button btnRegister;
        private TextBox txtRegisterPhone;
        private Label label10;
        private Panel panel1;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label1;
        private TextBox txtLoginPassword;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox txtRegisterRepassword;
        private TextBox txtRegisterPassword;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Panel panel4;
        private Button btnExit;
    }
}