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
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());
            }
            reader.Close();
            conn.Close();
        }

        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("students_view", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = txtSearch.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtName.Text = reader[0].ToString();
                txtID.Text = reader[1].ToString();    
                txtDepartment.Text = reader[2].ToString();
                txtEmail.Text = reader[3].ToString();
                txtSemester.Text = reader[4].ToString();
            }
            reader.Close();
            conn.Close();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (txtSearch.Text != "" && comboBox1.Text != "")
            {
                SqlCommand cmd = new SqlCommand("issueBook_add", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@StudentID", SqlDbType.NVarChar).Value = txtSearch.Text;
                cmd.Parameters.Add("@BookName", SqlDbType.NVarChar).Value = comboBox1.Text;
                cmd.Parameters.Add("@IssueDate", SqlDbType.NVarChar).Value = dateTimePicker1.Value.ToShortDateString();
                cmd.Parameters.Add("@ReturnDate", SqlDbType.NVarChar).Value = "";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Issue Book Added");
                conn.Close();
                txtSearch.Text = "";
                txtName.Text = "";
                txtID.Text = "";
                txtEmail.Text = "";
                txtDepartment.Text = "";
                txtSemester.Text = "";

            }
            else
            {
                MessageBox.Show("Please fill in all fields before proceeding.");
            }
            conn.Close();
        }
    }
}
