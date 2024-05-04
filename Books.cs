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
                conn.Close();
                txtName.Text = "";
                txtAuthor.Text = "";
                txtPublication.Text = "";
                txtPrice.Text = "";
                txtQuantity.Text = "";

                Books_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Please fill in all fields before proceeding.");
            }
            conn.Close();

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
    }
}
