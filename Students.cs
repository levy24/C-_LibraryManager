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
    public partial class Students : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-EBTTMM8\\MAY1;Initial Catalog=library;Integrated Security=True");
        public Students()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (txtName.Text != "" && txtID.Text != "" && txtDepartment.Text != "" && txtContact.Text != "" && txtEmail.Text != "" && txtSemester.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("students_create", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Student_Name", SqlDbType.NVarChar).Value = txtName.Text;
                    cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = txtID.Text;
                    cmd.Parameters.Add("@Department", SqlDbType.NVarChar).Value = txtDepartment.Text;
                    cmd.Parameters.Add("@contact", SqlDbType.NVarChar).Value = txtContact.Text;
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = txtEmail.Text;
                    cmd.Parameters.Add("@Semester", SqlDbType.NVarChar).Value = txtSemester.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Detail Added");

                    SqlCommand cmdLogin = new SqlCommand("user_add", conn);
                    cmdLogin.CommandType = CommandType.StoredProcedure;
                    cmdLogin.Parameters.Add("@username", SqlDbType.NVarChar).Value=txtName.Text;
                    cmdLogin.Parameters.Add("password", SqlDbType.NVarChar).Value = txtID.Text;
                    cmdLogin.ExecuteNonQuery();
                    txtName.Text = "";
                    txtID.Text = "";
                    txtDepartment.Text = "";
                    txtContact.Text = "";
                    txtEmail.Text = "";
                    txtSemester.Text = "";
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
                Students_Load(sender, e);
            }
        }


        private void Students_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("students_view", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("Text", dataGridView2.DataSource, "ID");
            txtName.DataBindings.Clear();
            txtName.DataBindings.Add("Text", dataGridView2.DataSource, "Student_Name");
            txtDepartment.DataBindings.Clear();
            txtDepartment.DataBindings.Add("Text", dataGridView2.DataSource, "Department");
            txtContact.DataBindings.Clear();
            txtContact.DataBindings.Add("Text", dataGridView2.DataSource, "contact");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dataGridView2.DataSource, "Email");
            txtSemester.DataBindings.Clear();
            txtSemester.DataBindings.Add("Text", dataGridView2.DataSource, "Semester");
            conn.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("students_view", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = txtID.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (txtName.Text != "" && txtID.Text != "" && txtDepartment.Text != "" && txtContact.Text != "" && txtEmail.Text != "" && txtSemester.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("students_update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Student_Name", SqlDbType.NVarChar).Value = txtName.Text;
                    cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = txtID.Text;
                    cmd.Parameters.Add("@Department", SqlDbType.NVarChar).Value = txtDepartment.Text;
                    cmd.Parameters.Add("@contact", SqlDbType.NVarChar).Value = txtContact.Text;
                    cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = txtEmail.Text;
                    cmd.Parameters.Add("@Semester", SqlDbType.NVarChar).Value = txtSemester.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Update Added");
                    txtName.Text = "";
                    txtID.Text = "";
                    txtDepartment.Text = "";
                    txtContact.Text = "";
                    txtEmail.Text = "";
                    txtSemester.Text = "";
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
                Students_Load(sender, e);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Please enter the ID of the student you want to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this student?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("students_delete", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = txtID.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Deleted");
                    txtID.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                    Students_Load(sender, e);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtID.Text = "";
            txtDepartment.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtSemester.Text = "";
        }
    }
}
