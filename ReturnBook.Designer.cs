namespace Library_Management
{
    partial class ReturnBook
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
            this.components = new System.ComponentModel.Container();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReturnReport = new System.Windows.Forms.Button();
            this.btnIssueReport = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.BackColor = System.Drawing.Color.Teal;
            this.btnSearchStudent.Font = new System.Drawing.Font("Calisto MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchStudent.Location = new System.Drawing.Point(924, 125);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(200, 37);
            this.btnSearchStudent.TabIndex = 47;
            this.btnSearchStudent.Text = "Search Student";
            this.btnSearchStudent.UseVisualStyleBackColor = false;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(453, 135);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(321, 27);
            this.txtSearch.TabIndex = 46;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Teal;
            this.lblSearch.Location = new System.Drawing.Point(319, 139);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(106, 23);
            this.lblSearch.TabIndex = 45;
            this.lblSearch.Text = "ID Student";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(296, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(842, 400);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Teal;
            this.lblID.Location = new System.Drawing.Point(319, 603);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(134, 23);
            this.lblID.TabIndex = 49;
            this.lblID.Text = "Issue Book ID";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(323, 646);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(200, 27);
            this.txtID.TabIndex = 51;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDate.ForeColor = System.Drawing.Color.Teal;
            this.lblReturnDate.Location = new System.Drawing.Point(681, 603);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(121, 23);
            this.lblReturnDate.TabIndex = 52;
            this.lblReturnDate.Text = "Return Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(685, 646);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 27);
            this.dateTimePicker1.TabIndex = 53;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Teal;
            this.btnReturn.Font = new System.Drawing.Font("Cambria", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReturn.Location = new System.Drawing.Point(947, 669);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(191, 42);
            this.btnReturn.TabIndex = 54;
            this.btnReturn.Text = "Return Book";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(4, 566);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(286, 69);
            this.btnExit.TabIndex = 62;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnReturnReport
            // 
            this.btnReturnReport.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReturnReport.Location = new System.Drawing.Point(4, 489);
            this.btnReturnReport.Name = "btnReturnReport";
            this.btnReturnReport.Size = new System.Drawing.Size(286, 71);
            this.btnReturnReport.TabIndex = 61;
            this.btnReturnReport.Text = "Return Book Report";
            this.btnReturnReport.UseVisualStyleBackColor = true;
            this.btnReturnReport.Click += new System.EventHandler(this.btnReturnReport_Click);
            // 
            // btnIssueReport
            // 
            this.btnIssueReport.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIssueReport.Location = new System.Drawing.Point(4, 412);
            this.btnIssueReport.Name = "btnIssueReport";
            this.btnIssueReport.Size = new System.Drawing.Size(286, 71);
            this.btnIssueReport.TabIndex = 60;
            this.btnIssueReport.Text = "Issue Book Report";
            this.btnIssueReport.UseVisualStyleBackColor = true;
            this.btnIssueReport.Click += new System.EventHandler(this.btnIssueReport_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIssue.Location = new System.Drawing.Point(4, 258);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(286, 71);
            this.btnIssue.TabIndex = 59;
            this.btnIssue.Text = "Issue Book";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(4, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 71);
            this.button1.TabIndex = 58;
            this.button1.Text = "Return Book";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnStudents
            // 
            this.btnStudents.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStudents.Location = new System.Drawing.Point(4, 181);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(286, 71);
            this.btnStudents.TabIndex = 57;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBooks.Location = new System.Drawing.Point(4, 104);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(286, 71);
            this.btnBooks.TabIndex = 56;
            this.btnBooks.Text = "Books";
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cambria", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Teal;
            this.lblTitle.Location = new System.Drawing.Point(471, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(283, 55);
            this.lblTitle.TabIndex = 63;
            this.lblTitle.Text = "Return Book";
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 723);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReturnReport);
            this.Controls.Add(this.btnIssueReport);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.btnBooks);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblReturnDate);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearchStudent);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Name = "ReturnBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnBook";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReturnReport;
        private System.Windows.Forms.Button btnIssueReport;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Label lblTitle;
    }
}