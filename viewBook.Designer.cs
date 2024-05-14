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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1111, 302);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Font = new System.Drawing.Font("Calisto MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBook.Location = new System.Drawing.Point(483, 94);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(200, 37);
            this.btnSearchBook.TabIndex = 55;
            this.btnSearchBook.Text = "Search Book";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // txtSearchBook
            // 
            this.txtSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBook.Location = new System.Drawing.Point(347, 44);
            this.txtSearchBook.Name = "txtSearchBook";
            this.txtSearchBook.Size = new System.Drawing.Size(539, 27);
            this.txtSearchBook.TabIndex = 54;
            // 
            // lblSearchBook
            // 
            this.lblSearchBook.AutoSize = true;
            this.lblSearchBook.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBook.Location = new System.Drawing.Point(194, 44);
            this.lblSearchBook.Name = "lblSearchBook";
            this.lblSearchBook.Size = new System.Drawing.Size(115, 23);
            this.lblSearchBook.TabIndex = 53;
            this.lblSearchBook.Text = "Book Name";
            // 
            // viewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 450);
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
    }
}