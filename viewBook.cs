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
    public partial class viewBook : Form
    {
        public viewBook()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-EBTTMM8\\MAY1;Initial Catalog=library;Integrated Security=True");

        private void viewBook_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("books_view", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@BookName", SqlDbType.NVarChar).Value = "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("books_view", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@BookName", SqlDbType.NVarChar).Value = txtSearchBook.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            StudentIssueBook issueBook = new StudentIssueBook(frmLogin.GetLoggedInUsername());
            issueBook.Show();
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

        private void btnChange_Click(object sender, EventArgs e)
        {
            ChangePassword change = new ChangePassword(frmLogin.GetLoggedInUsername());
            change.Show();
            this.Hide();
        }
    }
}
