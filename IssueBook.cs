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
    public partial class IssueBook : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-EBTTMM8\\MAY1;Initial Catalog=library;Integrated Security=True");
        public IssueBook()
        {
            InitializeComponent();
        }

        private void IssueBook_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("getBooks", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@BookName", SqlDbType.NVarChar).Value = txtSearchBook.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbBookName.Items.Add(reader[0].ToString());
            }
            reader.Close();
            conn.Close();
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("students_view", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = txtSearchStudent.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtName.Text = reader["Student_Name"].ToString();
                txtDepartment.Text = reader["Department"].ToString();
                txtEmail.Text = reader["Email"].ToString();
                txtSemester.Text = reader["Semester"].ToString();
            }
            reader.Close();
            conn.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (txtSearchStudent.Text != "" && cbBookName.Text != "")
            {
                SqlCommand cmd = new SqlCommand("issueBook_add", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@StudentID", SqlDbType.NVarChar).Value = txtSearchStudent.Text;
                cmd.Parameters.Add("@BookName", SqlDbType.NVarChar).Value = cbBookName.Text;
                cmd.Parameters.Add("@IssueDate", SqlDbType.NVarChar).Value = dateTimePicker1.Value.ToShortDateString();
                cmd.Parameters.Add("@ReturnDate", SqlDbType.NVarChar).Value = "";
                cmd.Parameters.Add("@BookID", SqlDbType.Int).Value = txtBookID.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Issue Book Added");
                conn.Close();
                txtSearchStudent.Text = "";
                txtName.Text = "";
                txtEmail.Text = "";
                txtDepartment.Text = "";
                txtSemester.Text = "";
                txtSearchBook.Text = "";
                txtAuthor.Text = "";
                txtQuantity.Text = "";
                cbBookName.Text = "";

            }
            else
            {
                MessageBox.Show("Please fill in all fields before proceeding.");
            }
            conn.Close();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("books_view", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@BookName", SqlDbType.NVarChar).Value = txtSearchBook.Text;
            cbBookName.Items.Clear();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbBookName.Items.Add(reader["BookName"].ToString());
            }
            reader.Close();
            conn.Close();
        }

        private void cbBookName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbBookName.SelectedIndex != -1)
            {
                string selectedBookName = cbBookName.SelectedItem.ToString();
                conn.Open();
                SqlCommand cmd = new SqlCommand("books_view", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@BookName", SqlDbType.NVarChar).Value = selectedBookName;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    txtBookID.Text = reader["BookID"].ToString();
                    txtAuthor.Text = reader["AuthorName"].ToString();
                    txtQuantity.Text = reader["Quantity"].ToString();
                }
                reader.Close();
                conn.Close();
            }
        }
    }
}
