namespace _20241008
{
    partial class ResultsForm
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
            gridResult = new DataGridView();
            role = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            total_votes = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridResult).BeginInit();
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
            // gridResult
            // 
            gridResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridResult.Columns.AddRange(new DataGridViewColumn[] { role, name, total_votes });
            gridResult.Location = new Point(20, 60);
            gridResult.Name = "gridResult";
            gridResult.RowTemplate.Height = 25;
            gridResult.Size = new Size(760, 360);
            gridResult.TabIndex = 1;
            // 
            // role
            // 
            role.HeaderText = "Role";
            role.Name = "role";
            role.Width = 230;
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.Name = "name";
            name.Width = 230;
            // 
            // total_votes
            // 
            total_votes.HeaderText = "Total Votes";
            total_votes.Name = "total_votes";
            total_votes.Width = 230;
            // 
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridResult);
            Controls.Add(btnBack);
            Name = "ResultForm";
            Text = "Result";
            Load += ResultForm_Load;
            ((System.ComponentModel.ISupportInitialize)gridResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBack;
        private DataGridView gridResult;
        private DataGridViewTextBoxColumn role;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn total_votes;
    }
}