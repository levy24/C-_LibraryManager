using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management
{
    public partial class frmLogin : Form
    {
        private static string loggedInUsername;

        public frmLogin()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-EBTTMM8\\MAY1;Initial Catalog=library;Integrated Security=True");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_login", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = txtUser.Text;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = txtPass.Text;
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {

               string permisson = rdr["permisson"].ToString();
                if(permisson == "admin")
                {
                    //MessageBox.Show("Login Success", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dashboard dashboard = new Dashboard();
                    this.Hide();
                    dashboard.Show();
                }
                else if(permisson == "student")
                {
                    loggedInUsername = rdr["username"].ToString();
                    //MessageBox.Show("Login Success", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    studentDashboard dashboard = new studentDashboard();
                    this.Hide();
                    dashboard.Show();
                }
            }
            else
            {
                MessageBox.Show("Login failed","Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public static string GetLoggedInUsername()
        {
            return loggedInUsername;
        }
    }
    
}
