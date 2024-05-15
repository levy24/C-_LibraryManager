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
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-EBTTMM8\\MAY1;Initial Catalog=library;Integrated Security=True");
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (txtName.Text != "" && txtAuthor.Text != "" && txtPublication.Text != "" && txtPrice.Text != "" && txtQuantity.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("books_create", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@BookName", SqlDbType.NVarChar).Value = txtName.Text;
                    cmd.Parameters.Add("@AuthorName", SqlDbType.NVarChar).Value = txtAuthor.Text;
                    cmd.Parameters.Add("@publication", SqlDbType.NVarChar).Value = txtPublication.Text;
                    cmd.Parameters.Add("@purchaseDate", SqlDbType.NVarChar).Value = dateTimePicker1.Value;
                    cmd.Parameters.Add("@BookPrice", SqlDbType.NVarChar).Value = txtPrice.Text;
                    cmd.Parameters.Add("@Quantity", SqlDbType.NVarChar).Value = txtQuantity.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Added");
                    txtName.Text = "";
                    txtAuthor.Text = "";
                    txtPublication.Text = "";
                    txtPrice.Text = "";
                    txtQuantity.Text = "";
                }
                else
                {
                    MessageBox.Show("Please fill in all fields before proceeding.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            Books_Load(sender, e);
        }

        private void Books_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("books_view", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@BookName", SqlDbType.NVarChar).Value = "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            //conn.Close();
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", dataGridView2.DataSource, "BookID");
            txtName.DataBindings.Clear();
            txtName.DataBindings.Add("Text", dataGridView2.DataSource, "BookName");
            txtAuthor.DataBindings.Clear();
            txtAuthor.DataBindings.Add("Text", dataGridView2.DataSource, "AuthorName");
            txtPublication.DataBindings.Clear();
            txtPublication.DataBindings.Add("Text", dataGridView2.DataSource, "publication");
            dateTimePicker1.DataBindings.Clear();
            dateTimePicker1.DataBindings.Add("Text", dataGridView2.DataSource, "purchaseDate");
            txtPrice.DataBindings.Clear();
            txtPrice.DataBindings.Add("Text", dataGridView2.DataSource, "BookPrice");
            txtQuantity.DataBindings.Clear();
            txtQuantity.DataBindings.Add("Text", dataGridView2.DataSource, "Quantity");
            conn.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("books_view", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@BookName", SqlDbType.NVarChar).Value = txtName.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (txtName.Text != "" && txtAuthor.Text != "" && txtPublication.Text != "" && txtPrice.Text != "" && txtQuantity.Text != "")
            {
                SqlCommand cmd = new SqlCommand("books_update", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@BookName", SqlDbType.NVarChar).Value = txtName.Text;
                cmd.Parameters.Add("@AuthorName", SqlDbType.NVarChar).Value = txtAuthor.Text;
                cmd.Parameters.Add("@publication", SqlDbType.NVarChar).Value = txtPublication.Text;
                cmd.Parameters.Add("@purchaseDate", SqlDbType.NVarChar).Value = dateTimePicker1.Value;
                cmd.Parameters.Add("@BookPrice", SqlDbType.NVarChar).Value = txtPrice.Text;
                cmd.Parameters.Add("@Quantity", SqlDbType.NVarChar).Value = txtQuantity.Text;
                cmd.Parameters.Add("@BookID", SqlDbType.NVarChar).Value = txtID.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Updated");
                conn.Close();
                txtName.Text = "";
                txtAuthor.Text = "";
                txtPublication.Text = "";
                txtPrice.Text = "";
                txtQuantity.Text = "";
            }
            else
            {
                MessageBox.Show("Please fill in all fields before proceeding.");
            }
            conn.Close();
            Books_Load(sender, e);

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Please enter both book name and author name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this book?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("books_delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@BookID", SqlDbType.NVarChar).Value = txtID.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView2.DataSource = dt;
                    conn.Close();
                    Books_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtAuthor.Text = "";
            txtPublication.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
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
