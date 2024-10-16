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
            btnEdit = new Button();
            txtCode = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnClear = new Button();
            btnVote = new Button();
            cmbCandidates = new ComboBox();
            cmbPartylists = new ComboBox();
            cmbRoles = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            btnFinalize = new Button();
            txtResult = new TextBox();
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
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(txtCode);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(20, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(220, 360);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Room settings";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(40, 260);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 23);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete Room";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(40, 300);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(140, 23);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit Room";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(20, 140);
            txtCode.Name = "txtCode";
            txtCode.ReadOnly = true;
            txtCode.Size = new Size(180, 23);
            txtCode.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(20, 60);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(180, 23);
            txtName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 120);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 3;
            label2.Text = "Room code:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 40);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 3;
            label1.Text = "Room name:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnVote);
            groupBox2.Controls.Add(cmbCandidates);
            groupBox2.Controls.Add(cmbPartylists);
            groupBox2.Controls.Add(cmbRoles);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(260, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(240, 400);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Vote";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(20, 340);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(80, 23);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear Votes";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnVote
            // 
            btnVote.Location = new Point(140, 340);
            btnVote.Name = "btnVote";
            btnVote.Size = new Size(80, 23);
            btnVote.TabIndex = 2;
            btnVote.Text = "Vote";
            btnVote.UseVisualStyleBackColor = true;
            btnVote.Click += btnVote_Click;
            // 
            // cmbCandidates
            // 
            cmbCandidates.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCandidates.FormattingEnabled = true;
            cmbCandidates.Location = new Point(20, 220);
            cmbCandidates.Name = "cmbCandidates";
            cmbCandidates.Size = new Size(200, 23);
            cmbCandidates.TabIndex = 1;
            // 
            // cmbPartylists
            // 
            cmbPartylists.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPartylists.FormattingEnabled = true;
            cmbPartylists.Location = new Point(20, 140);
            cmbPartylists.Name = "cmbPartylists";
            cmbPartylists.Size = new Size(200, 23);
            cmbPartylists.TabIndex = 1;
            cmbPartylists.SelectionChangeCommitted += cmbPartylists_SelectedIndexChanged;
            // 
            // cmbRoles
            // 
            cmbRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Location = new Point(20, 60);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(200, 23);
            cmbRoles.TabIndex = 1;
            cmbRoles.SelectionChangeCommitted += cmbRoles_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 200);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 0;
            label5.Text = "Candidate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 120);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 0;
            label4.Text = "Partylist";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 40);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 0;
            label3.Text = "Role";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnFinalize);
            groupBox3.Controls.Add(txtResult);
            groupBox3.Location = new Point(520, 20);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(260, 400);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Your votes";
            // 
            // btnFinalize
            // 
            btnFinalize.Location = new Point(140, 360);
            btnFinalize.Name = "btnFinalize";
            btnFinalize.Size = new Size(100, 23);
            btnFinalize.TabIndex = 1;
            btnFinalize.Text = "Finalize Votes";
            btnFinalize.UseVisualStyleBackColor = true;
            btnFinalize.Click += btnFinalize_Click;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(20, 40);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(220, 300);
            txtResult.TabIndex = 0;
            // 
            // RoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnBack);
            Name = "RoomForm";
            Text = "RoomForm";
            Load += RoomForm_Load;
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
    }
}