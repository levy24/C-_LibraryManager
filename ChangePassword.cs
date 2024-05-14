using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class ChangePassword : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-EBTTMM8\\MAY1;Initial Catalog=library;Integrated Security=True");
        private string username;

        public ChangePassword(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string currentPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmNewPassword = txtConfirmNewPassword.Text;

            // Kiểm tra tính hợp lệ của mật khẩu hiện tại và mật khẩu mới
            if (IsValidPassword(newPassword) && newPassword == confirmNewPassword)
            {
                if (IsCurrentPasswordValid(currentPassword))
                {
                    UpdatePassword(newPassword);
                    MessageBox.Show("Mật khẩu đã được thay đổi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu hiện tại không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (newPassword != confirmNewPassword)
                {
                    MessageBox.Show("Mật khẩu mới không khớp với xác nhận mật khẩu mới.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu hợp lệ và đảm bảo mật khẩu mới khớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private bool IsCurrentPasswordValid(string currentPassword)
        {
            string queryString = "SELECT COUNT(*) FROM login WHERE username = @Username AND password = @Password AND permisson = 'student';";

            conn.Open();

            try
            {
                using (SqlCommand command = new SqlCommand(queryString, conn))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", currentPassword);

                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private void UpdatePassword(string newPassword)
        {
            string queryString = "UPDATE login SET password = @NewPassword WHERE username = @Username;";

                conn.Open();

                using (SqlCommand command = new SqlCommand(queryString, conn))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@NewPassword", newPassword);

                    command.ExecuteNonQuery();
                }
                conn.Close() ;
        }

        private bool IsValidPassword(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }

            string specialCharactersPattern = @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]";
            if (!Regex.IsMatch(password, specialCharactersPattern))
            {
                return false;
            }

            return true;
        }
    }
}

