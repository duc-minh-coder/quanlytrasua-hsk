using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyQuanTraSua
{
    public partial class frmUpdateTK : Form
    {
        AccountBUS accountBUS = new AccountBUS();
        frmAdmin parent = new frmAdmin();
        public frmUpdateTK(frmAdmin parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
        private void frmUpdateTK_Load(object sender, EventArgs e)
        {
            panel2.MouseDown += panelTitleBar_MouseDown;
            txtUsername.Text = this.parent.selectedAccount.Username;
            txtName.Text = this.parent.selectedAccount.Realname;
            txtPhone.Text = this.parent.selectedAccount.PhoneNumber;
            txtEmail.Text = this.parent.selectedAccount.Email;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (accountBUS.updateAccount(txtUsername.Text, txtName.Text, txtPhone.Text, txtEmail.Text))
            {
                MessageBox.Show("Cập nhật thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }
    }
}
