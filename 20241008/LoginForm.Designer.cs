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
            groupBox1 = new GroupBox();
            btnLogin = new Button();
            txtLoginPassword = new TextBox();
            txtLoginUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnRegister = new Button();
            label3 = new Label();
            txtRegisterRepassword = new TextBox();
            txtRegisterPassword = new TextBox();
            txtRegisterUsername = new TextBox();
            txtRegisterPhone = new TextBox();
            txtRegisterEmail = new TextBox();
            label9 = new Label();
            txtRegisterLastname = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtRegisterFirstname = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(txtLoginPassword);
            groupBox1.Controls.Add(txtLoginUsername);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(20, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(240, 380);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Login";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(120, 260);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Location = new Point(40, 180);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.Size = new Size(160, 23);
            txtLoginPassword.TabIndex = 2;
            txtLoginPassword.UseSystemPasswordChar = true;
            // 
            // txtLoginUsername
            // 
            txtLoginUsername.Location = new Point(40, 80);
            txtLoginUsername.Name = "txtLoginUsername";
            txtLoginUsername.Size = new Size(160, 23);
            txtLoginUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 160);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 60);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRegister);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtRegisterRepassword);
            groupBox2.Controls.Add(txtRegisterPassword);
            groupBox2.Controls.Add(txtRegisterUsername);
            groupBox2.Controls.Add(txtRegisterPhone);
            groupBox2.Controls.Add(txtRegisterEmail);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtRegisterLastname);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtRegisterFirstname);
            groupBox2.Location = new Point(300, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(440, 380);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Register";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(320, 300);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 40);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 1;
            label3.Text = "First name";
            // 
            // txtRegisterRepassword
            // 
            txtRegisterRepassword.Location = new Point(240, 220);
            txtRegisterRepassword.Name = "txtRegisterRepassword";
            txtRegisterRepassword.Size = new Size(160, 23);
            txtRegisterRepassword.TabIndex = 2;
            txtRegisterRepassword.UseSystemPasswordChar = true;
            // 
            // txtRegisterPassword
            // 
            txtRegisterPassword.Location = new Point(240, 140);
            txtRegisterPassword.Name = "txtRegisterPassword";
            txtRegisterPassword.Size = new Size(160, 23);
            txtRegisterPassword.TabIndex = 2;
            txtRegisterPassword.UseSystemPasswordChar = true;
            // 
            // txtRegisterUsername
            // 
            txtRegisterUsername.Location = new Point(240, 60);
            txtRegisterUsername.Name = "txtRegisterUsername";
            txtRegisterUsername.Size = new Size(160, 23);
            txtRegisterUsername.TabIndex = 2;
            // 
            // txtRegisterPhone
            // 
            txtRegisterPhone.Location = new Point(40, 300);
            txtRegisterPhone.Name = "txtRegisterPhone";
            txtRegisterPhone.Size = new Size(160, 23);
            txtRegisterPhone.TabIndex = 2;
            // 
            // txtRegisterEmail
            // 
            txtRegisterEmail.Location = new Point(40, 220);
            txtRegisterEmail.Name = "txtRegisterEmail";
            txtRegisterEmail.Size = new Size(160, 23);
            txtRegisterEmail.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(240, 200);
            label9.Name = "label9";
            label9.Size = new Size(104, 15);
            label9.TabIndex = 1;
            label9.Text = "Confirm password";
            // 
            // txtRegisterLastname
            // 
            txtRegisterLastname.Location = new Point(40, 140);
            txtRegisterLastname.Name = "txtRegisterLastname";
            txtRegisterLastname.Size = new Size(160, 23);
            txtRegisterLastname.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(240, 120);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 1;
            label7.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(240, 40);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 1;
            label6.Text = "Username";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(40, 280);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 1;
            label8.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 200);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 1;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 120);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 1;
            label4.Text = "Last name";
            // 
            // txtRegisterFirstname
            // 
            txtRegisterFirstname.Location = new Point(40, 60);
            txtRegisterFirstname.Name = "txtRegisterFirstname";
            txtRegisterFirstname.Size = new Size(160, 23);
            txtRegisterFirstname.TabIndex = 2;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "LoginForm";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtLoginUsername;
        private Button btnLogin;
        private TextBox txtLoginPassword;
        private Label label2;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox txtRegisterLastname;
        private Label label4;
        private TextBox txtRegisterFirstname;
        private TextBox txtRegisterPassword;
        private TextBox txtRegisterUsername;
        private TextBox txtRegisterEmail;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btnRegister;
        private TextBox txtRegisterRepassword;
        private TextBox txtRegisterPhone;
        private Label label9;
        private Label label8;
    }
}