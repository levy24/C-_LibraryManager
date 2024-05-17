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

namespace Library_Management
{
    public partial class StudentIssueBook : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-EBTTMM8\\MAY1;Initial Catalog=library;Integrated Security=True");
        private string loggedInUsername;
        public StudentIssueBook(string username)
        {
            InitializeComponent();
            loggedInUsername = username;
        }

        private void StudentIssueBook_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("studentsIssueReport", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            frmLogin loginForm = new frmLogin();
            cmd.Parameters.Add("@studentID", SqlDbType.NVarChar).Value = loggedInUsername;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Columns.Contains("IssueID"))
                dt.Columns.Remove("IssueID");
            if (dt.Columns.Contains("BookID"))
                dt.Columns.Remove("BookID");
            if (dt.Columns.Contains("StudentID"))
                dt.Columns.Remove("StudentID");
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            conn.Close();   
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            viewBook book = new viewBook();
            book.Show();
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
