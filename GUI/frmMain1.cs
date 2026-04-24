using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BUS;
using DTO;
using FontAwesome.Sharp;

namespace QuanLyQuanTraSua
{
    public partial class frmMain1 : Form
    {
        AccountBUS accountBUS = new AccountBUS();
        private frmLogin parent;
        public Account currentUser;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public frmMain1(frmLogin parent)
        {
            this.parent = parent;
            this.currentUser = parent.currentUser;
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            pnlMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Change color of button
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(197, 190, 250);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(90,90,90);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(75, 75, 75);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitleChildForm.Text = childForm.Text;
            switch (childForm.Name)
            {
                case "frmTongQuan":
                    lblTitleChildForm.Text = "Tổng Quan";
                    break;
                case "frmMatHang":
                    lblTitleChildForm.Text = "Mặt Hàng";
                    break;
                case "frmThongKe":
                    lblTitleChildForm.Text = "Thống Kê";
                    break;
              
            }
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
        //Menu Button_Clicks

        private void btnTongQuan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmTongQuan());

        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmThongKe());
        }
        private void btnMatHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmMatHang());
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            frmSignUp frmSU =new frmSignUp();
            this.Visible = false;
            frmSU.ShowDialog();
            btnHome_Click(sender, e);
            this.Visible = true;
        }

        private void FrmSignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            Account currentAccount = new Account();
            currentAccount = accountBUS.getAccountByUsername(this.parent.currentUser.Username);
            ActivateButton(sender, RGBColors.color1);
            //OpenChildForm(new frmTaiKhoan());
            if (currentAccount.Type == 1)
            {
                this.Hide();
                frmAdmin formAdmin = new frmAdmin();
                formAdmin.ShowDialog();
            }
            else
            {
                this.Hide();
                frmTaiKhoan formTK = new frmTaiKhoan(this);
                formTK.ShowDialog();
            }
            btnHome_Click(sender, e);
            this.Show();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmMain1_Load(object sender, EventArgs e)
        {
            if (parent.currentUser.Type == 0)
            {
                lblName.Text = "NV: " + parent.currentUser.Realname;
            }
            else
            {
                lblName.Text = "Chủ Quán";
            }
        }
        //End of Change color of button

    }
}
    