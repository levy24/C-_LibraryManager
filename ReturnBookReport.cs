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
    public partial class ReturnBookReport : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-EBTTMM8\\MAY1;Initial Catalog=library;Integrated Security=True");
        public ReturnBookReport()
        {
            InitializeComponent();
        }

        private void ReturnBookReport_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Reports", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@report", SqlDbType.NVarChar).Value = "Return";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Reports_search", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@report", SqlDbType.NVarChar).Value = "Return";
            cmd.Parameters.Add("@bookName", SqlDbType.NVarChar).Value = txtName.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
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

        private void btnIssueReport_Click(object sender, EventArgs e)
        {
            IssueBookReport issueBookReport = new IssueBookReport();
            issueBookReport.Show();
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
