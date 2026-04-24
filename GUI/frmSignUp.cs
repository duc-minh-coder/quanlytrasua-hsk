using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace QuanLyQuanTraSua
{
    public partial class frmSignUp : Form
    {
        bool flag; //Kiểm tra điều kiện khi nhập thông tin đăng ký (true = hợp lệ)
        public frmSignUp()
        {
            InitializeComponent();
        }

        AccountBUS accountBUS = new AccountBUS();

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Regex usernameRegex = new Regex(@"^[A-z][A-z0-9]{4,12}$");
            Regex passwordRegex = new Regex(@"^[A-z0-9]{5,12}$");
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Regex phoneRegex = new Regex(@"^[0-9]{1,12}$");
            flag = true;
            string errorMessage = null;

            if (txtUsername.TextLength == 0 || txtUsername.Text == "Tên Đăng Nhập") //Kiểm tra điều kiện username
            {
                errorMessage += "- Không thể bỏ trống tên đăng nhập\n";
                flag = false;
            }
            else
            {
                if (!usernameRegex.IsMatch(txtUsername.Text))
                {
                    errorMessage += "- Tên đăng nhập không hợp lệ\n";
                    flag = false;
                }
            }
            if (txtPassword.TextLength == 0 || txtPassword.Text == "Mật Khẩu") //Kiểm tra điều kiện password
            {
                errorMessage += "- Không thể bỏ trống mật khẩu\n";
                flag = false;
            }
            else
            {
                if (!passwordRegex.IsMatch(txtPassword.Text))
                {
                    errorMessage += "- Mật khẩu đăng ký không hợp lệ\n";
                    flag = false;
                }
                else
                {
                    if (!(txtPassword.Text == txtRePassword.Text))
                    {
                        errorMessage += "- Mật khẩu không trùng khớp\n";
                        flag = false;
                    }
                }
            }
            if (txtName.TextLength == 0 || txtName.Text == "Họ Tên") //Kiểm tra điều kiện name
            {
                errorMessage += "- Không thể bỏ trống tên\n";
                flag = false;
            }
            if (txtPhone.TextLength > 0 && txtPhone.Text != "SĐT") //Kiểm tra điều kiện SĐT
            {
                if (!phoneRegex.IsMatch(txtPhone.Text))
                {
                    errorMessage += "- Số điện thoại không hợp lệ\n";
                    flag = false;
                }
            }
            if (txtEmail.TextLength > 0 && txtEmail.Text != "Email") //Kiểm tra điều kiện email
            {
                if (!emailRegex.IsMatch(txtEmail.Text))
                {
                    errorMessage += "- Email không hợp lệ\n";
                    flag = false;
                }
            }
            if (flag)
            {
                if (accountBUS.insertAccount(txtUsername.Text, txtName.Text, txtPassword.Text, txtPhone.Text, txtEmail.Text)) //Đăng ký
                {
                    MessageBox.Show("Đăng ký tài khoản thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng ký tài khoản thất bại");
                }
            }
            else
                MessageBox.Show(errorMessage);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Tên Đăng Nhập")
            {
                txtUsername.Clear();
            }
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

            this.ptrPhone1.Visible = false;
            pnlPhone.ForeColor = Color.White;
            if (txtPhone.Text == "SĐT")
                txtPhone.ForeColor = Color.Gray;
            else
                txtPhone.ForeColor = Color.White;

            this.ptrEmail1.Visible = false;
            pnlEmail.ForeColor = Color.White;
            if (txtEmail.Text == "Email")
                txtEmail.ForeColor = Color.Gray;
            else
                txtEmail.ForeColor = Color.White;

            this.ptrRetypePass1.Visible = false;
            pnlRetypePass.ForeColor = Color.White;
            if (txtRePassword.Text == "Nhập Lại Mật Khẩu")
                txtRePassword.ForeColor = Color.Gray;
            else
                txtRePassword.ForeColor = Color.White;

            this.ptrName1.Visible = false;
            pnlName.ForeColor = Color.White;
            if (txtName.Text == "Họ Tên")
                txtName.ForeColor = Color.Gray;
            else
                txtName.ForeColor = Color.White;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Mật Khẩu")
            {
                txtPassword.Clear();
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

            this.ptrPhone1.Visible = false;
            pnlPhone.ForeColor = Color.White;
            if (txtPhone.Text == "SĐT")
                txtPhone.ForeColor = Color.Gray;
            else
                txtPhone.ForeColor = Color.White;

            this.ptrEmail1.Visible = false;
            pnlEmail.ForeColor = Color.White;
            if (txtEmail.Text == "Email")
                txtEmail.ForeColor = Color.Gray;
            else
                txtEmail.ForeColor = Color.White;

            this.ptrRetypePass1.Visible = false;
            pnlRetypePass.ForeColor = Color.White;
            if (txtRePassword.Text == "Nhập Lại Mật Khẩu")
                txtRePassword.ForeColor = Color.Gray;
            else
                txtRePassword.ForeColor = Color.White;

            this.ptrName1.Visible = false;
            pnlName.ForeColor = Color.White;
            if (txtName.Text == "Họ Tên")
                txtName.ForeColor = Color.Gray;
            else
                txtName.ForeColor = Color.White;
        }

        private void txtRetypePass_Click(object sender, EventArgs e)
        {
            if (txtRePassword.Text == "Nhập Lại Mật Khẩu")
            {
                txtRePassword.Clear();
            }
            //
            this.ptrRetypePass1.Visible = true;
            pnlRetypePass.ForeColor = Color.FromArgb(78, 184, 206);
            txtRePassword.ForeColor = Color.FromArgb(78, 184, 206);
            //
            this.ptrPass1.Visible = false;
            pnlPass.ForeColor = Color.White;
            if (txtPassword.Text == "Mật Khẩu")
                txtPassword.ForeColor = Color.Gray;
            else
                txtPassword.ForeColor = Color.White;

            this.ptrUser1.Visible = false;
            pnlUser.ForeColor = Color.White;
            if (txtUsername.Text == "Tên Đăng Nhập")
                txtUsername.ForeColor = Color.Gray;
            else
                txtUsername.ForeColor = Color.White;

            this.ptrPhone1.Visible = false;
            pnlPhone.ForeColor = Color.White;
            if (txtPhone.Text == "SĐT")
                txtPhone.ForeColor = Color.Gray;
            else
                txtPhone.ForeColor = Color.White;

            this.ptrEmail1.Visible = false;
            pnlEmail.ForeColor = Color.White;
            if (txtEmail.Text == "Email")
                txtEmail.ForeColor = Color.Gray;
            else
                txtEmail.ForeColor = Color.White;

            this.ptrName1.Visible = false;
            pnlName.ForeColor = Color.White;
            if (txtName.Text == "Họ Tên")
                txtName.ForeColor = Color.Gray;
            else
                txtName.ForeColor = Color.White;
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "Họ Tên")
            {
                txtName.Clear();
            }
            //
            this.ptrName1.Visible = true;
            pnlName.ForeColor = Color.FromArgb(78, 184, 206);
            txtName.ForeColor = Color.FromArgb(78, 184, 206);
            //
            this.ptrPass1.Visible = false;
            pnlPass.ForeColor = Color.White;
            if (txtPassword.Text == "Mật Khẩu")
                txtPassword.ForeColor = Color.Gray;
            else
                txtPassword.ForeColor = Color.White;

            this.ptrUser1.Visible = false;
            pnlUser.ForeColor = Color.White;
            if (txtUsername.Text == "Tên Đăng Nhập")
                txtUsername.ForeColor = Color.Gray;
            else
                txtUsername.ForeColor = Color.White;

            this.ptrPhone1.Visible = false;
            pnlPhone.ForeColor = Color.White;
            if (txtPhone.Text == "SĐT")
                txtPhone.ForeColor = Color.Gray;
            else
                txtPhone.ForeColor = Color.White;

            this.ptrEmail1.Visible = false;
            pnlEmail.ForeColor = Color.White;
            if (txtEmail.Text == "Email")
                txtEmail.ForeColor = Color.Gray;
            else
                txtEmail.ForeColor = Color.White;

            this.ptrRetypePass1.Visible = false;
            pnlRetypePass.ForeColor = Color.White;
            if (txtRePassword.Text == "Nhập Lại Mật Khẩu")
                txtRePassword.ForeColor = Color.Gray;
            else
                txtRePassword.ForeColor = Color.White;
        }

        private void txtPhone_Click(object sender, EventArgs e)
        {
            if (txtPhone.Text == "SĐT")
            {
                txtPhone.Clear();
            }
            //
            this.ptrPhone1.Visible = true;
            pnlPhone.ForeColor = Color.FromArgb(78, 184, 206);
            txtPhone.ForeColor = Color.FromArgb(78, 184, 206);
            //
            this.ptrPass1.Visible = false;
            pnlPass.ForeColor = Color.White;
            if (txtPassword.Text == "Mật Khẩu")
                txtPassword.ForeColor = Color.Gray;
            else
                txtPassword.ForeColor = Color.White;

            this.ptrUser1.Visible = false;
            pnlUser.ForeColor = Color.White;
            if (txtUsername.Text == "Tên Đăng Nhập")
                txtUsername.ForeColor = Color.Gray;
            else
                txtUsername.ForeColor = Color.White;

            this.ptrEmail1.Visible = false;
            pnlEmail.ForeColor = Color.White;
            if (txtEmail.Text == "Email")
                txtEmail.ForeColor = Color.Gray;
            else
                txtEmail.ForeColor = Color.White;

            this.ptrRetypePass1.Visible = false;
            pnlRetypePass.ForeColor = Color.White;
            if (txtRePassword.Text == "Nhập Lại Mật Khẩu")
                txtRePassword.ForeColor = Color.Gray;
            else
                txtRePassword.ForeColor = Color.White;

            this.ptrName1.Visible = false;
            pnlName.ForeColor = Color.White;
            if (txtName.Text == "Họ Tên")
                txtName.ForeColor = Color.Gray;
            else
                txtName.ForeColor = Color.White;
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Clear();
            }
            //
            this.ptrEmail1.Visible = true;
            pnlEmail.ForeColor = Color.FromArgb(78, 184, 206);
            txtEmail.ForeColor = Color.FromArgb(78, 184, 206);
            //
            this.ptrPass1.Visible = false;
            pnlPass.ForeColor = Color.White;
            if (txtPassword.Text == "Mật Khẩu")
                txtPassword.ForeColor = Color.Gray;
            else
                txtPassword.ForeColor = Color.White;

            this.ptrUser1.Visible = false;
            pnlUser.ForeColor = Color.White;
            if (txtUsername.Text == "Tên Đăng Nhập")
                txtUsername.ForeColor = Color.Gray;
            else
                txtUsername.ForeColor = Color.White;

            this.ptrPhone1.Visible = false;
            pnlPhone.ForeColor = Color.White;
            if (txtPhone.Text == "SĐT")
                txtPhone.ForeColor = Color.Gray;
            else
                txtPhone.ForeColor = Color.White;

            this.ptrRetypePass1.Visible = false;
            pnlRetypePass.ForeColor = Color.White;
            if (txtRePassword.Text == "Nhập Lại Mật Khẩu")
                txtRePassword.ForeColor = Color.Gray;
            else
                txtRePassword.ForeColor = Color.White;

            this.ptrName1.Visible = false;
            pnlName.ForeColor = Color.White;
            if (txtName.Text == "Họ Tên")
                txtName.ForeColor = Color.Gray;
            else
                txtName.ForeColor = Color.White;
        }



        //=== TextChanged ================
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

            this.ptrPhone1.Visible = false;
            pnlPhone.ForeColor = Color.White;
            if (txtPhone.Text == "SĐT")
                txtPhone.ForeColor = Color.Gray;
            else
                txtPhone.ForeColor = Color.White;

            this.ptrEmail1.Visible = false;
            pnlEmail.ForeColor = Color.White;
            if (txtEmail.Text == "Email")
                txtEmail.ForeColor = Color.Gray;
            else
                txtEmail.ForeColor = Color.White;

            this.ptrRetypePass1.Visible = false;
            pnlRetypePass.ForeColor = Color.White;
            if (txtRePassword.Text == "Nhập Lại Mật Khẩu")
                txtRePassword.ForeColor = Color.Gray;
            else
                txtRePassword.ForeColor = Color.White;

            this.ptrName1.Visible = false;
            pnlName.ForeColor = Color.White;
            if (txtName.Text == "Họ Tên")
                txtName.ForeColor = Color.Gray;
            else
                txtName.ForeColor = Color.White;
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

            this.ptrPhone1.Visible = false;
            pnlPhone.ForeColor = Color.White;
            if (txtPhone.Text == "SĐT")
                txtPhone.ForeColor = Color.Gray;
            else
                txtPhone.ForeColor = Color.White;

            this.ptrEmail1.Visible = false;
            pnlEmail.ForeColor = Color.White;
            if (txtEmail.Text == "Email")
                txtEmail.ForeColor = Color.Gray;
            else
                txtEmail.ForeColor = Color.White;

            this.ptrRetypePass1.Visible = false;
            pnlRetypePass.ForeColor = Color.White;
            if (txtRePassword.Text == "Nhập Lại Mật Khẩu")
                txtRePassword.ForeColor = Color.Gray;
            else
                txtRePassword.ForeColor = Color.White;

            this.ptrName1.Visible = false;
            pnlName.ForeColor = Color.White;
            if (txtName.Text == "Họ Tên")
                txtName.ForeColor = Color.Gray;
            else
                txtName.ForeColor = Color.White;
        }

        private void txtRetypePass_TextChanged(object sender, EventArgs e)
        {
            if (!(txtRePassword.Text == "Nhập Lại Mật Khẩu" || txtRePassword.Text == ""))
            {
                txtRePassword.PasswordChar = '*';
            }
            //
            this.ptrRetypePass1.Visible = true;
            pnlRetypePass.ForeColor = Color.FromArgb(78, 184, 206);
            txtRePassword.ForeColor = Color.FromArgb(78, 184, 206);
            //
            this.ptrPass1.Visible = false;
            pnlPass.ForeColor = Color.White;
            if (txtPassword.Text == "Mật Khẩu")
                txtPassword.ForeColor = Color.Gray;
            else
                txtPassword.ForeColor = Color.White;

            this.ptrUser1.Visible = false;
            pnlUser.ForeColor = Color.White;
            if (txtUsername.Text == "Tên Đăng Nhập")
                txtUsername.ForeColor = Color.Gray;
            else
                txtUsername.ForeColor = Color.White;

            this.ptrName1.Visible = false;
            pnlName.ForeColor = Color.White;
            if (txtName.Text == "Họ Tên")
                txtName.ForeColor = Color.Gray;
            else
                txtName.ForeColor = Color.White;

            this.ptrPhone1.Visible = false;
            pnlPhone.ForeColor = Color.White;
            if (txtPhone.Text == "SĐT")
                txtPhone.ForeColor = Color.Gray;
            else
                txtPhone.ForeColor = Color.White;

            this.ptrEmail1.Visible = false;
            pnlEmail.ForeColor = Color.White;
            if (txtEmail.Text == "Email")
                txtEmail.ForeColor = Color.Gray;
            else
                txtEmail.ForeColor = Color.White;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //
            this.ptrName1.Visible = true;
            pnlName.ForeColor = Color.FromArgb(78, 184, 206);
            txtName.ForeColor = Color.FromArgb(78, 184, 206);
            //
            this.ptrPass1.Visible = false;
            pnlPass.ForeColor = Color.White;
            if (txtPassword.Text == "Mật Khẩu")
                txtPassword.ForeColor = Color.Gray;
            else
                txtPassword.ForeColor = Color.White;

            this.ptrUser1.Visible = false;
            pnlUser.ForeColor = Color.White;
            if (txtUsername.Text == "Tên Đăng Nhập")
                txtUsername.ForeColor = Color.Gray;
            else
                txtUsername.ForeColor = Color.White;

            this.ptrPhone1.Visible = false;
            pnlPhone.ForeColor = Color.White;
            if (txtPhone.Text == "SĐT")
                txtPhone.ForeColor = Color.Gray;
            else
                txtPhone.ForeColor = Color.White;

            this.ptrEmail1.Visible = false;
            pnlEmail.ForeColor = Color.White;
            if (txtEmail.Text == "Email")
                txtEmail.ForeColor = Color.Gray;
            else
                txtEmail.ForeColor = Color.White;

            this.ptrRetypePass1.Visible = false;
            pnlRetypePass.ForeColor = Color.White;
            if (txtRePassword.Text == "Nhập Lại Mật Khẩu")
                txtRePassword.ForeColor = Color.Gray;
            else
                txtRePassword.ForeColor = Color.White;
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            //
            this.ptrPhone1.Visible = true;
            pnlPhone.ForeColor = Color.FromArgb(78, 184, 206);
            txtPhone.ForeColor = Color.FromArgb(78, 184, 206);
            //
            this.ptrPass1.Visible = false;
            pnlPass.ForeColor = Color.White;
            if (txtPassword.Text == "Mật Khẩu")
                txtPassword.ForeColor = Color.Gray;
            else
                txtPassword.ForeColor = Color.White;

            this.ptrUser1.Visible = false;
            pnlUser.ForeColor = Color.White;
            if (txtUsername.Text == "Tên Đăng Nhập")
                txtUsername.ForeColor = Color.Gray;
            else
                txtUsername.ForeColor = Color.White;

            this.ptrEmail1.Visible = false;
            pnlEmail.ForeColor = Color.White;
            if (txtEmail.Text == "Email")
                txtEmail.ForeColor = Color.Gray;
            else
                txtEmail.ForeColor = Color.White;

            this.ptrRetypePass1.Visible = false;
            pnlRetypePass.ForeColor = Color.White;
            if (txtRePassword.Text == "Nhập Lại Mật Khẩu")
                txtRePassword.ForeColor = Color.Gray;
            else
                txtRePassword.ForeColor = Color.White;

            this.ptrName1.Visible = false;
            pnlName.ForeColor = Color.White;
            if (txtName.Text == "Họ Tên")
                txtName.ForeColor = Color.Gray;
            else
                txtName.ForeColor = Color.White;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            //
            this.ptrEmail1.Visible = true;
            pnlEmail.ForeColor = Color.FromArgb(78, 184, 206);
            txtEmail.ForeColor = Color.FromArgb(78, 184, 206);
            //
            this.ptrPass1.Visible = false;
            pnlPass.ForeColor = Color.White;
            if (txtPassword.Text == "Mật Khẩu")
                txtPassword.ForeColor = Color.Gray;
            else
                txtPassword.ForeColor = Color.White;

            this.ptrUser1.Visible = false;
            pnlUser.ForeColor = Color.White;
            if (txtUsername.Text == "Tên Đăng Nhập")
                txtUsername.ForeColor = Color.Gray;
            else
                txtUsername.ForeColor = Color.White;

            this.ptrPhone1.Visible = false;
            pnlPhone.ForeColor = Color.White;
            if (txtPhone.Text == "SĐT")
                txtPhone.ForeColor = Color.Gray;
            else
                txtPhone.ForeColor = Color.White;

            this.ptrRetypePass1.Visible = false;
            pnlRetypePass.ForeColor = Color.White;
            if (txtRePassword.Text == "Nhập Lại Mật Khẩu")
                txtRePassword.ForeColor = Color.Gray;
            else
                txtRePassword.ForeColor = Color.White;

            this.ptrName1.Visible = false;
            pnlName.ForeColor = Color.White;
            if (txtName.Text == "Họ Tên")
                txtName.ForeColor = Color.Gray;
            else
                txtName.ForeColor = Color.White;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void txtRePassword_Leave(object sender, EventArgs e)
        {
            if (txtRePassword.Text == "")
            {
                txtRePassword.Text = "Nhập Lại Mật Khẩu";
                txtRePassword.PasswordChar = default;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Họ Tên";
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                txtPhone.Text = "SĐT";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
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

        private void frmSignUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnSignUp_Click(sender, e);
            }
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            panel2.MouseDown += panelTitleBar_MouseDown;

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
