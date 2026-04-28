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
    public partial class frmQuanLyNhanVien : Form
    {
        AccountBUS accountBUS = new AccountBUS();
        private frmMain1 parent;
        private bool isEditMode = false;
        private string currentEditUsername = "";

        public frmQuanLyNhanVien(frmMain1 parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadEmployeeList();
            LoadAccountTypes();
            ClearForm();
        }

        private void LoadEmployeeList()
        {
            try
            {
                List<Account> accounts = accountBUS.GetAccountList();
                dgvEmployees.DataSource = null;
                dgvEmployees.DataSource = ConvertAccountListToDataTable(accounts);
                dgvEmployees.Columns[0].Width = 120;
                dgvEmployees.Columns[1].Width = 150;
                dgvEmployees.Columns[2].Width = 120;
                dgvEmployees.Columns[3].Width = 120;
                dgvEmployees.Columns[4].Width = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách: " + ex.Message);
            }
        }

        private void LoadAccountTypes()
        {
            cmbType.Items.Clear();
            cmbType.Items.Add("Nhân Viên");
            cmbType.Items.Add("Quản Lý");
            cmbType.Items.Add("Admin");
            cmbType.SelectedIndex = 0;
        }

        private DataTable ConvertAccountListToDataTable(List<Account> accounts)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên Đăng Nhập", typeof(string));
            dt.Columns.Add("Tên Nhân Viên", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Số Điện Thoại", typeof(string));
            dt.Columns.Add("Loại Tài Khoản", typeof(string));

            foreach (Account acc in accounts)
            {
                dt.Rows.Add(
                    acc.Username,
                    acc.Realname,
                    acc.Email,
                    acc.PhoneNumber,
                    GetAccountType(acc.Type)
                );
            }
            return dt;
        }

        private string GetAccountType(int type)
        {
            return type == 0 ? "Nhân Viên" : type == 1 ? "Quản Lý" : "Admin";
        }

        private int GetAccountTypeValue(string typeStr)
        {
            return typeStr == "Nhân Viên" ? 0 : typeStr == "Quản Lý" ? 1 : 2;
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                isEditMode = true;
                currentEditUsername = dgvEmployees.Rows[e.RowIndex].Cells[0].Value.ToString();
                Account acc = accountBUS.getAccountByUsername(currentEditUsername);
                
                txtUsername.Text = acc.Username;
                txtUsername.ReadOnly = true;
                txtName.Text = acc.Realname;
                txtEmail.Text = acc.Email;
                txtPhone.Text = acc.PhoneNumber;
                cmbType.SelectedIndex = acc.Type;
                
                btnAdd.Text = "Cập Nhật";
                btnDelete.Enabled = true;
                btnClear.Text = "Hủy";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || 
                string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và tên nhân viên");
                return;
            }

            try
            {
                if (isEditMode)
                {
                    bool success = accountBUS.updateAccount(
                        currentEditUsername,
                        txtName.Text.Trim(),
                        txtPhone.Text.Trim(),
                        txtEmail.Text.Trim()
                    );

                    if (success)
                    {
                        MessageBox.Show("Cập nhật thông tin nhân viên thành công!");
                        LoadEmployeeList();
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi cập nhật thông tin!");
                    }
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(txtPassword.Text))
                    {
                        MessageBox.Show("Vui lòng nhập mật khẩu");
                        return;
                    }

                    bool success = accountBUS.insertAccount(
                        txtUsername.Text.Trim(),
                        txtName.Text.Trim(),
                        txtPassword.Text.Trim(),
                        txtPhone.Text.Trim(),
                        txtEmail.Text.Trim()
                    );

                    if (success)
                    {
                        MessageBox.Show("Thêm nhân viên mới thành công!");
                        LoadEmployeeList();
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi thêm nhân viên!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", 
                "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bool success = accountBUS.deleteAccount(currentEditUsername);
                    if (success)
                    {
                        MessageBox.Show("Xóa nhân viên thành công!");
                        LoadEmployeeList();
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi xóa nhân viên!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            isEditMode = false;
            currentEditUsername = "";
            txtUsername.Clear();
            txtUsername.ReadOnly = false;
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtPassword.Clear();
            cmbType.SelectedIndex = 0;
            btnAdd.Text = "Thêm Mới";
            btnDelete.Enabled = false;
            btnClear.Text = "Xóa Trắng";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim().Length == 0)
            {
                LoadEmployeeList();
            }
            else
            {
                SearchEmployees(txtSearch.Text.Trim());
            }
        }

        private void SearchEmployees(string keyword)
        {
            try
            {
                List<Account> accounts = accountBUS.SearchAccounts(keyword);
                dgvEmployees.DataSource = null;
                dgvEmployees.DataSource = ConvertAccountListToDataTable(accounts);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }
    }
}
