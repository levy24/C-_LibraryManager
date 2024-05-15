namespace Library_Management
{
    partial class viewBook
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.txtSearchBook = new System.Windows.Forms.TextBox();
            this.lblSearchBook = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(365, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(773, 425);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.BackColor = System.Drawing.Color.Teal;
            this.btnSearchBook.Font = new System.Drawing.Font("Calisto MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchBook.Location = new System.Drawing.Point(949, 144);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(200, 37);
            this.btnSearchBook.TabIndex = 55;
            this.btnSearchBook.Text = "Search Book";
            this.btnSearchBook.UseVisualStyleBackColor = false;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // txtSearchBook
            // 
            this.txtSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBook.Location = new System.Drawing.Point(544, 146);
            this.txtSearchBook.Name = "txtSearchBook";
            this.txtSearchBook.Size = new System.Drawing.Size(363, 27);
            this.txtSearchBook.TabIndex = 54;
            // 
            // lblSearchBook
            // 
            this.lblSearchBook.AutoSize = true;
            this.lblSearchBook.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBook.ForeColor = System.Drawing.Color.Teal;
            this.lblSearchBook.Location = new System.Drawing.Point(383, 150);
            this.lblSearchBook.Name = "lblSearchBook";
            this.lblSearchBook.Size = new System.Drawing.Size(115, 23);
            this.lblSearchBook.TabIndex = 53;
            this.lblSearchBook.Text = "Book Name";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblTitle.Font = new System.Drawing.Font("Cambria", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Teal;
            this.lblTitle.Location = new System.Drawing.Point(420, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(307, 70);
            this.lblTitle.TabIndex = 56;
            this.lblTitle.Text = "View Book";
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnChange.Location = new System.Drawing.Point(7, 404);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(327, 71);
            this.btnChange.TabIndex = 59;
            this.btnChange.Text = "Change Password";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIssue.Location = new System.Drawing.Point(7, 274);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(327, 71);
            this.btnIssue.TabIndex = 58;
            this.btnIssue.Text = "Issue Book";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBooks.Location = new System.Drawing.Point(7, 150);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(327, 71);
            this.btnBooks.TabIndex = 57;
            this.btnBooks.Text = "View Books";
            this.btnBooks.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(7, 531);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(327, 71);
            this.btnExit.TabIndex = 60;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // viewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 723);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnBooks);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.txtSearchBook);
            this.Controls.Add(this.lblSearchBook);
            this.Controls.Add(this.dataGridView1);
            this.Name = "viewBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewBook";
            this.Load += new System.EventHandler(this.viewBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.TextBox txtSearchBook;
        private System.Windows.Forms.Label lblSearchBook;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnExit;
    }
}