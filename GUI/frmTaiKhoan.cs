using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyQuanTraSua
{
    public partial class frmTaiKhoan : Form
    {
        AccountBUS accountBUS = new AccountBUS();
        private frmMain1 parent;
        public frmTaiKhoan(frmMain1 parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            Account currentAccount = new Account();
            currentAccount = accountBUS.getAccountByUsername(this.parent.currentUser.Username);
            txtUsername.Text = currentAccount.Username;
            txtName.Text = currentAccount.Realname;
            txtPhone.Text = currentAccount.PhoneNumber;
            txtEmail.Text = currentAccount.Email;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            btnCancel_Click(sender, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
