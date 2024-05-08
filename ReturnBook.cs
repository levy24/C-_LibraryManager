﻿using System;
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
    public partial class ReturnBook : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-EBTTMM8\\MAY1;Initial Catalog=library;Integrated Security=True");
        public ReturnBook()
        {
            InitializeComponent();
        }


        private void btnSearchStudent_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("issueBook_view", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = txtSearch.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("issueBook_update", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IssueID", SqlDbType.Int).Value = int.Parse(txtID.Text);
            cmd.Parameters.Add("@returnDate", SqlDbType.NVarChar).Value = dateTimePicker1.Value.ToShortDateString();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Book Returned");

            //string studentID = "";
            //SqlCommand getStudentIDCmd = new SqlCommand("SELECT StudentID FROM issueBook WHERE IssueID = @IssueID", conn);
            //getStudentIDCmd.Parameters.Add("@IssueID", SqlDbType.NVarChar).Value = txtID.Text;
            //using (SqlDataReader reader = getStudentIDCmd.ExecuteReader())
            //{
            //    if (reader.Read())
            //    {
            //        studentID = reader["StudentID"].ToString();
            //    }
            //}

            SqlCommand updateQuantityCmd = new SqlCommand("UPDATE Books SET Quantity = Quantity + 1 WHERE BookID IN (SELECT BookID FROM issueBook WHERE IssueID = @IssueID)", conn);
            updateQuantityCmd.Parameters.Add("@IssueID", SqlDbType.Int).Value = int.Parse(txtID.Text);
            updateQuantityCmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
