using System;
using System.Drawing;
using System.Windows.Forms;
using BUS;
using System.Runtime.InteropServices;
using DTO;

namespace QuanLyQuanTraSua
{
    public partial class frmLogin : Form
    {
        AccountBUS accountBus = new AccountBUS();
        public Account currentUser;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (accountBus.logIn(txtUsername.Text, txtPassword.Text))
            {
                this.Hide();
                currentUser = accountBus.getAccountByUsername(txtUsername.Text);
                frmMain1 form = new frmMain1(this);
                form.ShowDialog();
                this.Show();
                //--
                currentUser = null;
                txtUsername.Text = "Username";
                txtPassword.Text = "Password";
                txtPassword.PasswordChar = default;
                txtUsername.Focus();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tài khoản");
                txtPassword.Text = "";
                txtUsername.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnLogin_Click(sender, e);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Tên Đăng Nhập")
            {
                txtUsername.Clear();
            }
            ptrUsername.BackgroundImage = Properties.Resources.user1;
            this.ptrUser1.Visible = true;
            pnlUser.ForeColor = Color.FromArgb(78, 184, 206);
            txtUsername.ForeColor = Color.FromArgb(78, 184, 206);
            //
            ptrPassword.BackgroundImage = Properties.Resources.pass;
            this.ptrPass1.Visible = false;
            pnlPass.ForeColor = Color.White;
            if (txtPassword.Text == "Mật Khẩu")
                txtPassword.ForeColor = Color.Gray;
            else
                txtPassword.ForeColor = Color.White;

        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Mật Khẩu")
            {
                txtPassword.Clear();
            }
            ptrPassword.BackgroundImage = Properties.Resources.pass1;
            this.ptrPass1.Visible = true;
            pnlPass.ForeColor = Color.FromArgb(78, 184, 206);
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);
            //
            ptrUsername.BackgroundImage = Properties.Resources.user;
            this.ptrUser1.Visible = false;
            pnlUser.ForeColor = Color.White;
            if (txtUsername.Text == "Tên Đăng Nhập")
                txtUsername.ForeColor = Color.Gray;
            else
                txtUsername.ForeColor = Color.White;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            //
            this.ptrUser1.Visible = true;
            pnlUser.ForeColor = Color.FromArgb(78, 184, 206);
            txtUsername.ForeColor = Color.FromArgb(78, 184, 206);
            //
            this.ptrPass1.Visible = false;
            pnlPass.ForeColor = Color.White;
            if (txtPassword.Text == "Mật Khẩu")
                txtPassword.ForeColor = Color.Gray;
            else
                txtPassword.ForeColor = Color.White;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!(txtPassword.Text == "Mật Khẩu" || txtPassword.Text == ""))
            {
                txtPassword.PasswordChar = '*';
            }
            //
            this.ptrPass1.Visible = true;
            pnlPass.ForeColor = Color.FromArgb(78, 184, 206);
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);
            //
            this.ptrUser1.Visible = false;
            pnlUser.ForeColor = Color.White;
            if (txtUsername.Text == "Tên Đăng Nhập")
                txtUsername.ForeColor = Color.Gray;
            else
                txtUsername.ForeColor = Color.White;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void pnlMove_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Tên Đăng Nhập";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Mật Khẩu";
                txtPassword.PasswordChar = default;
            }
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && txtPassword.Text != "Mật Khẩu")
            {
                if (txtPassword.PasswordChar == '*')
                    txtPassword.PasswordChar = default;
                else
                    txtPassword.PasswordChar = '*';
            }
        }

        private void signup_Click(object sender, EventArgs e) {
            this.Hide(); // Ẩn form login

            frmSignUp signupForm = new frmSignUp();
            signupForm.ShowDialog(); // mở form signup dạng modal

            this.Show(); // quay lại login sau khi signup xong
        }
    }
}
