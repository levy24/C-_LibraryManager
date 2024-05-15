namespace Library_Management
{
    partial class IssueBookReport
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReturnReport = new System.Windows.Forms.Button();
            this.btnIssueReport = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cambria", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Teal;
            this.lblTitle.Location = new System.Drawing.Point(396, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(344, 47);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Issue Book Report";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(389, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(568, 108);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(362, 31);
            this.txtName.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(968, 108);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(148, 36);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search Book";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(367, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(739, 424);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(25, 554);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(286, 69);
            this.btnExit.TabIndex = 35;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReturnReport
            // 
            this.btnReturnReport.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReturnReport.Location = new System.Drawing.Point(25, 477);
            this.btnReturnReport.Name = "btnReturnReport";
            this.btnReturnReport.Size = new System.Drawing.Size(286, 71);
            this.btnReturnReport.TabIndex = 34;
            this.btnReturnReport.Text = "Return Book Report";
            this.btnReturnReport.UseVisualStyleBackColor = true;
            this.btnReturnReport.Click += new System.EventHandler(this.btnReturnReport_Click);
            // 
            // btnIssueReport
            // 
            this.btnIssueReport.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIssueReport.Location = new System.Drawing.Point(25, 400);
            this.btnIssueReport.Name = "btnIssueReport";
            this.btnIssueReport.Size = new System.Drawing.Size(286, 71);
            this.btnIssueReport.TabIndex = 33;
            this.btnIssueReport.Text = "Issue Book Report";
            this.btnIssueReport.UseVisualStyleBackColor = true;
            // 
            // btnIssue
            // 
            this.btnIssue.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIssue.Location = new System.Drawing.Point(25, 246);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(286, 71);
            this.btnIssue.TabIndex = 32;
            this.btnIssue.Text = "Issue Book";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReturn.Location = new System.Drawing.Point(25, 323);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(286, 71);
            this.btnReturn.TabIndex = 31;
            this.btnReturn.Text = "Return Book";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStudents.Location = new System.Drawing.Point(25, 169);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(286, 71);
            this.btnStudents.TabIndex = 30;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBooks.Location = new System.Drawing.Point(25, 92);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(286, 71);
            this.btnBooks.TabIndex = 29;
            this.btnBooks.Text = "Books";
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // IssueBookReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 723);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReturnReport);
            this.Controls.Add(this.btnIssueReport);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.btnBooks);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Name = "IssueBookReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IssueBookReport";
            this.Load += new System.EventHandler(this.IssueBookReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReturnReport;
        private System.Windows.Forms.Button btnIssueReport;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnBooks;
    }
}