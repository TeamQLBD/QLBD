using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanDay
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn thoát chương trình không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtAccount.Text;
            string passWord = txtPassWord.Text;
            if (Login(userName, passWord))
            {
                fManager f = new fManager();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            MessageBox.Show("Sai tên Tài khoản hoặc Mật khẩu!");
        }

        bool Login(string userName, string passWord)
        {
            return false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
