using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyQuanTraSua
{
    public partial class frmNhapHang : Form
    {
        private readonly NguyenLieuBUS nguyenLieuBUS = new NguyenLieuBUS();
        private readonly NhapHangBUS nhapHangBUS = new NhapHangBUS();
        private readonly AccountBUS accountBUS = new AccountBUS();
        private Account currentUser;
        private readonly BindingList<ChiTietNhapTam> chiTietTamList = new BindingList<ChiTietNhapTam>();

        public frmNhapHang()
        {
            InitializeComponent();
            WireEvents();
        }

        public frmNhapHang(Account currentUser) : this()
        {
            this.currentUser = currentUser;
        }

        private bool IsDesignTime()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime;
        }

        private void WireEvents()
        {
            if (IsDesignTime())
            {
                return;
            }

            Load += FrmNhapHang_Load;
            dgvNguyenLieu.SelectionChanged += DgvNguyenLieu_SelectionChanged;
            btnThemNguyenLieu.Click += btnThemNguyenLieu_Click;
            btnSuaNguyenLieu.Click += btnSuaNguyenLieu_Click;
            btnXoaNguyenLieu.Click += btnXoaNguyenLieu_Click;
            btnLamMoiNguyenLieu.Click += btnLamMoiNguyenLieu_Click;
            btnThemChiTiet.Click += btnThemChiTiet_Click;
            btnXoaChiTiet.Click += btnXoaChiTiet_Click;
            btnLuuPhieuNhap.Click += btnLuuPhieuNhap_Click;
            dgvChiTietTam.DataSource = chiTietTamList;
        }

        private void FrmNhapHang_Load(object sender, EventArgs e)
        {
            BindNhanVienInfo();
            ReloadAllData();
            ClearNguyenLieuFields();
            ClearChiTietFields();
        }

        private void BindNhanVienInfo()
        {
            txtMaNhanVien.Text = "";
            txtTenNhanVien.Text = "";

            if (currentUser == null)
            {
                return;
            }

            txtMaNhanVien.Text = currentUser.Username;
            txtTenNhanVien.Text = currentUser.Realname;

            if (txtTenNhanVien.Text == "" && txtMaNhanVien.Text != "")
            {
                Account dbAccount = accountBUS.getAccountByUsername(txtMaNhanVien.Text);
                if (dbAccount != null)
                {
                    txtTenNhanVien.Text = dbAccount.Realname;
                }
            }
        }

        private void ReloadAllData()
        {
            dgvNguyenLieu.DataSource = nguyenLieuBUS.GetNguyenLieuDetailed();
            FormatNguyenLieuGrid();

            List<NguyenLieu> nguyenLieuList = nguyenLieuBUS.GetNguyenLieuList();
            cbbNguyenLieu.DataSource = nguyenLieuList;
            cbbNguyenLieu.DisplayMember = "TenNguyenLieu";
            cbbNguyenLieu.ValueMember = "MaNguyenLieu";

            dgvPhieuNhap.DataSource = nhapHangBUS.GetPhieuNhapSummary();
            FormatPhieuNhapGrid();

            dgvChiTietTam.DataSource = null;
            dgvChiTietTam.DataSource = chiTietTamList;
            FormatChiTietGrid();
        }

        private void btnThemNguyenLieu_Click(object sender, EventArgs e)
        {
            if (!TryReadNguyenLieuForm(out string tenNguyenLieu, out string donViTinh, out int soLuongTon))
            {
                return;
            }

            if (nguyenLieuBUS.InsertNguyenLieu(tenNguyenLieu, donViTinh, soLuongTon))
            {
                MessageBox.Show("Đã thêm nguyên liệu");
                ReloadAllData();
                ClearNguyenLieuFields();
            }
            else
            {
                MessageBox.Show("Thêm nguyên liệu thất bại");
            }
        }

        private void btnSuaNguyenLieu_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaNguyenLieu.Text, out int maNguyenLieu))
            {
                MessageBox.Show("Chọn nguyên liệu cần sửa");
                return;
            }

            if (!TryReadNguyenLieuForm(out string tenNguyenLieu, out string donViTinh, out int soLuongTon))
            {
                return;
            }

            if (nguyenLieuBUS.UpdateNguyenLieu(maNguyenLieu, tenNguyenLieu, donViTinh, soLuongTon))
            {
                MessageBox.Show("Đã sửa nguyên liệu");
                ReloadAllData();
            }
            else
            {
                MessageBox.Show("Sửa nguyên liệu thất bại");
            }
        }

        private void btnXoaNguyenLieu_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaNguyenLieu.Text, out int maNguyenLieu))
            {
                MessageBox.Show("Chọn nguyên liệu cần xóa");
                return;
            }

            if (nguyenLieuBUS.DeleteNguyenLieu(maNguyenLieu))
            {
                MessageBox.Show("Đã xóa nguyên liệu");
                ReloadAllData();
                ClearNguyenLieuFields();
            }
            else
            {
                MessageBox.Show("Xóa nguyên liệu thất bại");
            }
        }

        private void btnLamMoiNguyenLieu_Click(object sender, EventArgs e)
        {
            ClearNguyenLieuFields();
        }

        private void btnThemChiTiet_Click(object sender, EventArgs e)
        {
            if (cbbNguyenLieu.SelectedItem == null)
            {
                MessageBox.Show("Chọn nguyên liệu");
                return;
            }

            if (!int.TryParse(txtSoLuongNhap.Text, out int soLuongNhap) || soLuongNhap <= 0)
            {
                MessageBox.Show("Số lượng nhập không hợp lệ");
                return;
            }

            if (!decimal.TryParse(txtDonGiaNhap.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal donGiaNhap) || donGiaNhap < 0)
            {
                MessageBox.Show("Đơn giá nhập không hợp lệ");
                return;
            }

            NguyenLieu nguyenLieu = cbbNguyenLieu.SelectedItem as NguyenLieu;
            if (nguyenLieu == null)
            {
                MessageBox.Show("Không thể đọc thông tin nguyên liệu");
                return;
            }

            ChiTietNhapTam existing = chiTietTamList.FirstOrDefault(item => item.MaNguyenLieu == nguyenLieu.MaNguyenLieu);
            if (existing != null)
            {
                existing.SoLuongNhap += soLuongNhap;
                existing.DonGiaNhap = donGiaNhap;
                dgvChiTietTam.Refresh();
            }
            else
            {
                chiTietTamList.Add(new ChiTietNhapTam
                {
                    MaNguyenLieu = nguyenLieu.MaNguyenLieu,
                    TenNguyenLieu = nguyenLieu.TenNguyenLieu,
                    DonViTinh = nguyenLieu.DonViTinh,
                    SoLuongNhap = soLuongNhap,
                    DonGiaNhap = donGiaNhap
                });
            }

            FormatChiTietGrid();
            ClearChiTietFields();
        }

        private void btnXoaChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvChiTietTam.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn một dòng để xóa");
                return;
            }

            ChiTietNhapTam selected = dgvChiTietTam.SelectedRows[0].DataBoundItem as ChiTietNhapTam;
            if (selected != null)
            {
                chiTietTamList.Remove(selected);
                FormatChiTietGrid();
            }
        }

        private void btnLuuPhieuNhap_Click(object sender, EventArgs e)
        {
            if (chiTietTamList.Count == 0)
            {
                MessageBox.Show("Thêm ít nhất một chi tiết trước khi lưu phiếu nhập");
                return;
            }

            string maNhanVien = txtMaNhanVien.Text.Trim();
            if (maNhanVien == "")
            {
                MessageBox.Show("Không xác định được nhân viên thực hiện");
                return;
            }

            List<ChiTietPhieuNhap> chiTietPhieuNhap = chiTietTamList
                .Select(item => new ChiTietPhieuNhap(0, item.MaNguyenLieu, item.SoLuongNhap, item.DonGiaNhap))
                .ToList();

            if (nhapHangBUS.SavePhieuNhap(dtpNgayNhap.Value.Date, maNhanVien, chiTietPhieuNhap))
            {
                MessageBox.Show("Đã lưu phiếu nhập và cập nhật tồn kho");
                chiTietTamList.Clear();
                ReloadAllData();
                ClearChiTietFields();
            }
            else
            {
                MessageBox.Show("Lưu phiếu nhập thất bại");
            }
        }

        private void DgvNguyenLieu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNguyenLieu.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow row = dgvNguyenLieu.SelectedRows[0];
            txtMaNguyenLieu.Text = row.Cells["MaNguyenLieu"].Value.ToString();
            txtTenNguyenLieu.Text = row.Cells["TenNguyenLieu"].Value.ToString();
            txtDonViTinh.Text = row.Cells["DonViTinh"].Value.ToString();
            txtSoLuongTon.Text = row.Cells["SoLuongTon"].Value.ToString();

            int maNguyenLieu = Convert.ToInt32(row.Cells["MaNguyenLieu"].Value);
            foreach (NguyenLieu nguyenLieu in cbbNguyenLieu.Items)
            {
                if (nguyenLieu.MaNguyenLieu == maNguyenLieu)
                {
                    cbbNguyenLieu.SelectedItem = nguyenLieu;
                    break;
                }
            }
        }

        private void FormatNguyenLieuGrid()
        {
            if (dgvNguyenLieu.Columns.Count == 0)
            {
                return;
            }

            dgvNguyenLieu.Columns["MaNguyenLieu"].HeaderText = "Mã NL";
            dgvNguyenLieu.Columns["TenNguyenLieu"].HeaderText = "Tên nguyên liệu";
            dgvNguyenLieu.Columns["DonViTinh"].HeaderText = "Đơn vị tính";
            dgvNguyenLieu.Columns["SoLuongTon"].HeaderText = "Số lượng tồn";
            dgvNguyenLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNguyenLieu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNguyenLieu.ReadOnly = true;
            dgvNguyenLieu.AllowUserToAddRows = false;
        }

        private void FormatChiTietGrid()
        {
            if (dgvChiTietTam.Columns.Count == 0)
            {
                return;
            }

            dgvChiTietTam.Columns["MaNguyenLieu"].HeaderText = "Mã NL";
            dgvChiTietTam.Columns["TenNguyenLieu"].HeaderText = "Tên nguyên liệu";
            dgvChiTietTam.Columns["DonViTinh"].HeaderText = "ĐVT";
            dgvChiTietTam.Columns["SoLuongNhap"].HeaderText = "Số lượng nhập";
            dgvChiTietTam.Columns["DonGiaNhap"].HeaderText = "Đơn giá nhập";
            dgvChiTietTam.Columns["ThanhTien"].HeaderText = "Thành tiền";
            dgvChiTietTam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietTam.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietTam.ReadOnly = true;
            dgvChiTietTam.AllowUserToAddRows = false;
        }

        private void FormatPhieuNhapGrid()
        {
            if (dgvPhieuNhap.Columns.Count == 0)
            {
                return;
            }

            dgvPhieuNhap.Columns["MaPhieuNhap"].HeaderText = "Mã phiếu nhập";
            dgvPhieuNhap.Columns["NgayNhap"].HeaderText = "Ngày nhập";
            dgvPhieuNhap.Columns["MaNhanVien"].HeaderText = "Mã nhân viên";
            if (dgvPhieuNhap.Columns.Contains("TenNhanVien"))
            {
                dgvPhieuNhap.Columns["TenNhanVien"].HeaderText = "Tên nhân viên";
            }
            if (dgvPhieuNhap.Columns.Contains("SoLoaiNguyenLieu"))
            {
                dgvPhieuNhap.Columns["SoLoaiNguyenLieu"].HeaderText = "Số loại NL";
            }
            if (dgvPhieuNhap.Columns.Contains("TongTien"))
            {
                dgvPhieuNhap.Columns["TongTien"].HeaderText = "Tổng tiền";
            }
            dgvPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuNhap.ReadOnly = true;
            dgvPhieuNhap.AllowUserToAddRows = false;
        }

        private bool TryReadNguyenLieuForm(out string tenNguyenLieu, out string donViTinh, out int soLuongTon)
        {
            tenNguyenLieu = txtTenNguyenLieu.Text.Trim();
            donViTinh = txtDonViTinh.Text.Trim();
            soLuongTon = 0;

            if (tenNguyenLieu == "" || donViTinh == "")
            {
                MessageBox.Show("Điền đủ tên nguyên liệu và đơn vị tính");
                return false;
            }

            if (!int.TryParse(txtSoLuongTon.Text, out soLuongTon) || soLuongTon < 0)
            {
                MessageBox.Show("Số lượng tồn không hợp lệ");
                return false;
            }

            return true;
        }

        private void ClearNguyenLieuFields()
        {
            txtMaNguyenLieu.Text = "Tự động";
            txtTenNguyenLieu.Clear();
            txtDonViTinh.Clear();
            txtSoLuongTon.Text = "0";
            if (dgvNguyenLieu.Rows.Count > 0)
            {
                dgvNguyenLieu.ClearSelection();
            }
        }

        private void ClearChiTietFields()
        {
            txtSoLuongNhap.Clear();
            txtDonGiaNhap.Clear();
            if (cbbNguyenLieu.Items.Count > 0)
            {
                cbbNguyenLieu.SelectedIndex = 0;
            }
        }

        private class ChiTietNhapTam : INotifyPropertyChanged
        {
            private int maNguyenLieu;
            private string tenNguyenLieu;
            private string donViTinh;
            private int soLuongNhap;
            private decimal donGiaNhap;

            public int MaNguyenLieu
            {
                get { return maNguyenLieu; }
                set { maNguyenLieu = value; OnPropertyChanged("MaNguyenLieu"); }
            }

            public string TenNguyenLieu
            {
                get { return tenNguyenLieu; }
                set { tenNguyenLieu = value; OnPropertyChanged("TenNguyenLieu"); }
            }

            public string DonViTinh
            {
                get { return donViTinh; }
                set { donViTinh = value; OnPropertyChanged("DonViTinh"); }
            }

            public int SoLuongNhap
            {
                get { return soLuongNhap; }
                set { soLuongNhap = value; OnPropertyChanged("SoLuongNhap"); OnPropertyChanged("ThanhTien"); }
            }

            public decimal DonGiaNhap
            {
                get { return donGiaNhap; }
                set { donGiaNhap = value; OnPropertyChanged("DonGiaNhap"); OnPropertyChanged("ThanhTien"); }
            }

            public decimal ThanhTien
            {
                get { return SoLuongNhap * DonGiaNhap; }
            }

            public event PropertyChangedEventHandler PropertyChanged;

            private void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}