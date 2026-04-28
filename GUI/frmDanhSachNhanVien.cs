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
    public partial class frmDanhSachNhanVien : Form
    {
        AccountBUS accountBUS = new AccountBUS();

        public frmDanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void frmDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            LoadEmployeeList();
        }

        private void LoadEmployeeList()
        {
            try
            {
                List<Account> accounts = accountBUS.GetAccountList();
                dgvEmployees.DataSource = null;
                dgvEmployees.DataSource = ConvertAccountListToDataTable(accounts);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách: " + ex.Message);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchEmployees(txtSearch.Text.Trim());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
