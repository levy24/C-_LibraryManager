using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library_Management
{
    public partial class IssueBookReport : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-EBTTMM8\\MAY1;Initial Catalog=library;Integrated Security=True");
        public IssueBookReport()
        {
            InitializeComponent();
        }

        private void IssueBookReport_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Reports", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@report", SqlDbType.NVarChar).Value = "Issue";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            int borrowedCount = dt.Rows.Count;
            txtBorrowedCount.Text = borrowedCount.ToString();
            conn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Reports_search", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@report", SqlDbType.NVarChar).Value = "Issue";
            cmd.Parameters.Add("@bookName", SqlDbType.NVarChar).Value = txtName.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            int borrowedCount = dt.Rows.Count;
            txtBorrowedCount.Text = borrowedCount.ToString();
            conn.Close();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            Books book = new Books();
            book.Show();
            this.Hide();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            students.Show();
            this.Hide();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            IssueBook issueBook = new IssueBook();
            issueBook.Show();
            this.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook();
            returnBook.Show();
            this.Hide();
        }


        private void btnReturnReport_Click(object sender, EventArgs e)
        {
            ReturnBookReport returnBookReport = new ReturnBookReport();
            returnBookReport.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
