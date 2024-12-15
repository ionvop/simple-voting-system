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
            btnBack.BackColor = Color.White;
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ImageAlign = ContentAlignment.TopLeft;
            btnBack.Location = new Point(23, 27);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 31);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // gridResult
            // 
            gridResult.BackgroundColor = Color.White;
            gridResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridResult.Columns.AddRange(new DataGridViewColumn[] { role, name, total_votes });
            gridResult.GridColor = Color.Black;
            gridResult.Location = new Point(23, 80);
            gridResult.Margin = new Padding(3, 4, 3, 4);
            gridResult.Name = "gridResult";
            gridResult.RowHeadersWidth = 51;
            gridResult.RowTemplate.Height = 25;
            gridResult.Size = new Size(743, 680);
            gridResult.TabIndex = 1;
            // 
            // role
            // 
            role.HeaderText = "Role";
            role.MinimumWidth = 6;
            role.Name = "role";
            role.Width = 230;
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.Width = 230;
            // 
            // total_votes
            // 
            total_votes.HeaderText = "Total Votes";
            total_votes.MinimumWidth = 6;
            total_votes.Name = "total_votes";
            total_votes.Width = 230;
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 6, 79);
            ClientSize = new Size(791, 785);
            Controls.Add(gridResult);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ResultsForm";
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