using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class studentDashboard : Form
    {
        private frmLogin loginForm;

        public studentDashboard()
        {
            InitializeComponent();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            viewBook book = new viewBook();
            book.Show();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            StudentIssueBook issueBook = new StudentIssueBook(frmLogin.GetLoggedInUsername());
            issueBook.Show();
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
        }
    }
}
