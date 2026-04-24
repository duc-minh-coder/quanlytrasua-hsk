namespace QuanLyQuanTraSua
{
    partial class frmNhapHang
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel pnlNguyenLieu;
        private System.Windows.Forms.Panel pnlPhieuNhap;
        private System.Windows.Forms.Label lblTitleNguyenLieu;
        private System.Windows.Forms.Label lblTitlePhieuNhap;
        private System.Windows.Forms.Label lblMaNguyenLieu;
        private System.Windows.Forms.Label lblTenNguyenLieu;
        private System.Windows.Forms.Label lblDonViTinh;
        private System.Windows.Forms.Label lblSoLuongTon;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.Label lblNgayNhap;
        private System.Windows.Forms.Label lblNguyenLieu;
        private System.Windows.Forms.Label lblSoLuongNhap;
        private System.Windows.Forms.Label lblDonGiaNhap;
        private System.Windows.Forms.Label lblChiTietTam;
        private System.Windows.Forms.Label lblLichSuPhieuNhap;
        private System.Windows.Forms.TextBox txtMaNguyenLieu;
        private System.Windows.Forms.TextBox txtTenNguyenLieu;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.ComboBox cbbNguyenLieu;
        private System.Windows.Forms.TextBox txtSoLuongNhap;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private FontAwesome.Sharp.IconButton btnThemNguyenLieu;
        private FontAwesome.Sharp.IconButton btnSuaNguyenLieu;
        private FontAwesome.Sharp.IconButton btnXoaNguyenLieu;
        private FontAwesome.Sharp.IconButton btnLamMoiNguyenLieu;
        private FontAwesome.Sharp.IconButton btnThemChiTiet;
        private FontAwesome.Sharp.IconButton btnXoaChiTiet;
        private FontAwesome.Sharp.IconButton btnLuuPhieuNhap;
        private System.Windows.Forms.DataGridView dgvNguyenLieu;
        private System.Windows.Forms.DataGridView dgvChiTietTam;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.pnlNguyenLieu = new System.Windows.Forms.Panel();
            this.lblTitleNguyenLieu = new System.Windows.Forms.Label();
            this.lblMaNguyenLieu = new System.Windows.Forms.Label();
            this.txtMaNguyenLieu = new System.Windows.Forms.TextBox();
            this.lblTenNguyenLieu = new System.Windows.Forms.Label();
            this.txtTenNguyenLieu = new System.Windows.Forms.TextBox();
            this.lblDonViTinh = new System.Windows.Forms.Label();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.lblSoLuongTon = new System.Windows.Forms.Label();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.btnThemNguyenLieu = new FontAwesome.Sharp.IconButton();
            this.btnSuaNguyenLieu = new FontAwesome.Sharp.IconButton();
            this.btnXoaNguyenLieu = new FontAwesome.Sharp.IconButton();
            this.btnLamMoiNguyenLieu = new FontAwesome.Sharp.IconButton();
            this.dgvNguyenLieu = new System.Windows.Forms.DataGridView();
            this.pnlPhieuNhap = new System.Windows.Forms.Panel();
            this.lblTitlePhieuNhap = new System.Windows.Forms.Label();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.lblNgayNhap = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.lblNguyenLieu = new System.Windows.Forms.Label();
            this.cbbNguyenLieu = new System.Windows.Forms.ComboBox();
            this.lblSoLuongNhap = new System.Windows.Forms.Label();
            this.txtSoLuongNhap = new System.Windows.Forms.TextBox();
            this.lblDonGiaNhap = new System.Windows.Forms.Label();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.btnThemChiTiet = new FontAwesome.Sharp.IconButton();
            this.btnXoaChiTiet = new FontAwesome.Sharp.IconButton();
            this.btnLuuPhieuNhap = new FontAwesome.Sharp.IconButton();
            this.lblChiTietTam = new System.Windows.Forms.Label();
            this.dgvChiTietTam = new System.Windows.Forms.DataGridView();
            this.lblLichSuPhieuNhap = new System.Windows.Forms.Label();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.pnlNguyenLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).BeginInit();
            this.pnlPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietTam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.pnlNguyenLieu);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.pnlPhieuNhap);
            this.splitContainer.Size = new System.Drawing.Size(1028, 609);
            this.splitContainer.SplitterDistance = 500;
            this.splitContainer.SplitterWidth = 3;
            this.splitContainer.TabIndex = 0;
            // 
            // pnlNguyenLieu
            // 
            this.pnlNguyenLieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.pnlNguyenLieu.Controls.Add(this.lblTitleNguyenLieu);
            this.pnlNguyenLieu.Controls.Add(this.lblMaNguyenLieu);
            this.pnlNguyenLieu.Controls.Add(this.txtMaNguyenLieu);
            this.pnlNguyenLieu.Controls.Add(this.lblTenNguyenLieu);
            this.pnlNguyenLieu.Controls.Add(this.txtTenNguyenLieu);
            this.pnlNguyenLieu.Controls.Add(this.lblDonViTinh);
            this.pnlNguyenLieu.Controls.Add(this.txtDonViTinh);
            this.pnlNguyenLieu.Controls.Add(this.lblSoLuongTon);
            this.pnlNguyenLieu.Controls.Add(this.txtSoLuongTon);
            this.pnlNguyenLieu.Controls.Add(this.btnThemNguyenLieu);
            this.pnlNguyenLieu.Controls.Add(this.btnSuaNguyenLieu);
            this.pnlNguyenLieu.Controls.Add(this.btnXoaNguyenLieu);
            this.pnlNguyenLieu.Controls.Add(this.btnLamMoiNguyenLieu);
            this.pnlNguyenLieu.Controls.Add(this.dgvNguyenLieu);
            this.pnlNguyenLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNguyenLieu.Location = new System.Drawing.Point(0, 0);
            this.pnlNguyenLieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlNguyenLieu.Name = "pnlNguyenLieu";
            this.pnlNguyenLieu.Padding = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.pnlNguyenLieu.Size = new System.Drawing.Size(500, 609);
            this.pnlNguyenLieu.TabIndex = 0;
            // 
            // lblTitleNguyenLieu
            // 
            this.lblTitleNguyenLieu.AutoSize = true;
            this.lblTitleNguyenLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitleNguyenLieu.ForeColor = System.Drawing.Color.White;
            this.lblTitleNguyenLieu.Location = new System.Drawing.Point(14, 13);
            this.lblTitleNguyenLieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleNguyenLieu.Name = "lblTitleNguyenLieu";
            this.lblTitleNguyenLieu.Size = new System.Drawing.Size(203, 22);
            this.lblTitleNguyenLieu.TabIndex = 0;
            this.lblTitleNguyenLieu.Text = "Quản Lý Nguyên Liệu";
            // 
            // lblMaNguyenLieu
            // 
            this.lblMaNguyenLieu.AutoSize = true;
            this.lblMaNguyenLieu.ForeColor = System.Drawing.Color.White;
            this.lblMaNguyenLieu.Location = new System.Drawing.Point(15, 52);
            this.lblMaNguyenLieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaNguyenLieu.Name = "lblMaNguyenLieu";
            this.lblMaNguyenLieu.Size = new System.Drawing.Size(79, 13);
            this.lblMaNguyenLieu.TabIndex = 1;
            this.lblMaNguyenLieu.Text = "Mã nguyên liệu";
            // 
            // txtMaNguyenLieu
            // 
            this.txtMaNguyenLieu.Location = new System.Drawing.Point(112, 49);
            this.txtMaNguyenLieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaNguyenLieu.Name = "txtMaNguyenLieu";
            this.txtMaNguyenLieu.ReadOnly = true;
            this.txtMaNguyenLieu.Size = new System.Drawing.Size(166, 20);
            this.txtMaNguyenLieu.TabIndex = 2;
            this.txtMaNguyenLieu.Text = "Tự động";
            // 
            // lblTenNguyenLieu
            // 
            this.lblTenNguyenLieu.AutoSize = true;
            this.lblTenNguyenLieu.ForeColor = System.Drawing.Color.White;
            this.lblTenNguyenLieu.Location = new System.Drawing.Point(15, 84);
            this.lblTenNguyenLieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenNguyenLieu.Name = "lblTenNguyenLieu";
            this.lblTenNguyenLieu.Size = new System.Drawing.Size(83, 13);
            this.lblTenNguyenLieu.TabIndex = 3;
            this.lblTenNguyenLieu.Text = "Tên nguyên liệu";
            // 
            // txtTenNguyenLieu
            // 
            this.txtTenNguyenLieu.Location = new System.Drawing.Point(112, 81);
            this.txtTenNguyenLieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenNguyenLieu.Name = "txtTenNguyenLieu";
            this.txtTenNguyenLieu.Size = new System.Drawing.Size(166, 20);
            this.txtTenNguyenLieu.TabIndex = 4;
            // 
            // lblDonViTinh
            // 
            this.lblDonViTinh.AutoSize = true;
            this.lblDonViTinh.ForeColor = System.Drawing.Color.White;
            this.lblDonViTinh.Location = new System.Drawing.Point(15, 117);
            this.lblDonViTinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDonViTinh.Name = "lblDonViTinh";
            this.lblDonViTinh.Size = new System.Drawing.Size(60, 13);
            this.lblDonViTinh.TabIndex = 5;
            this.lblDonViTinh.Text = "Đơn vị tính";
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(112, 114);
            this.txtDonViTinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(166, 20);
            this.txtDonViTinh.TabIndex = 6;
            // 
            // lblSoLuongTon
            // 
            this.lblSoLuongTon.AutoSize = true;
            this.lblSoLuongTon.ForeColor = System.Drawing.Color.White;
            this.lblSoLuongTon.Location = new System.Drawing.Point(15, 150);
            this.lblSoLuongTon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoLuongTon.Name = "lblSoLuongTon";
            this.lblSoLuongTon.Size = new System.Drawing.Size(67, 13);
            this.lblSoLuongTon.TabIndex = 7;
            this.lblSoLuongTon.Text = "Số lượng tồn";
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Location = new System.Drawing.Point(112, 146);
            this.txtSoLuongTon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(114, 20);
            this.txtSoLuongTon.TabIndex = 8;
            this.txtSoLuongTon.Text = "0";
            // 
            // btnThemNguyenLieu
            // 
            this.btnThemNguyenLieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNguyenLieu.ForeColor = System.Drawing.Color.White;
            this.btnThemNguyenLieu.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThemNguyenLieu.IconColor = System.Drawing.Color.White;
            this.btnThemNguyenLieu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemNguyenLieu.Location = new System.Drawing.Point(293, 31);
            this.btnThemNguyenLieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemNguyenLieu.Name = "btnThemNguyenLieu";
            this.btnThemNguyenLieu.Size = new System.Drawing.Size(75, 34);
            this.btnThemNguyenLieu.TabIndex = 9;
            this.btnThemNguyenLieu.Text = "Thêm";
            this.btnThemNguyenLieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemNguyenLieu.UseVisualStyleBackColor = true;
            // 
            // btnSuaNguyenLieu
            // 
            this.btnSuaNguyenLieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaNguyenLieu.ForeColor = System.Drawing.Color.White;
            this.btnSuaNguyenLieu.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnSuaNguyenLieu.IconColor = System.Drawing.Color.White;
            this.btnSuaNguyenLieu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuaNguyenLieu.Location = new System.Drawing.Point(392, 31);
            this.btnSuaNguyenLieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSuaNguyenLieu.Name = "btnSuaNguyenLieu";
            this.btnSuaNguyenLieu.Size = new System.Drawing.Size(75, 34);
            this.btnSuaNguyenLieu.TabIndex = 10;
            this.btnSuaNguyenLieu.Text = "Sửa";
            this.btnSuaNguyenLieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaNguyenLieu.UseVisualStyleBackColor = true;
            // 
            // btnXoaNguyenLieu
            // 
            this.btnXoaNguyenLieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaNguyenLieu.ForeColor = System.Drawing.Color.White;
            this.btnXoaNguyenLieu.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnXoaNguyenLieu.IconColor = System.Drawing.Color.White;
            this.btnXoaNguyenLieu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaNguyenLieu.Location = new System.Drawing.Point(293, 84);
            this.btnXoaNguyenLieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaNguyenLieu.Name = "btnXoaNguyenLieu";
            this.btnXoaNguyenLieu.Size = new System.Drawing.Size(75, 34);
            this.btnXoaNguyenLieu.TabIndex = 11;
            this.btnXoaNguyenLieu.Text = "Xóa";
            this.btnXoaNguyenLieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaNguyenLieu.UseVisualStyleBackColor = true;
            // 
            // btnLamMoiNguyenLieu
            // 
            this.btnLamMoiNguyenLieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiNguyenLieu.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiNguyenLieu.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btnLamMoiNguyenLieu.IconColor = System.Drawing.Color.White;
            this.btnLamMoiNguyenLieu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLamMoiNguyenLieu.Location = new System.Drawing.Point(392, 84);
            this.btnLamMoiNguyenLieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLamMoiNguyenLieu.Name = "btnLamMoiNguyenLieu";
            this.btnLamMoiNguyenLieu.Size = new System.Drawing.Size(75, 34);
            this.btnLamMoiNguyenLieu.TabIndex = 12;
            this.btnLamMoiNguyenLieu.Text = "Làm mới";
            this.btnLamMoiNguyenLieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLamMoiNguyenLieu.UseVisualStyleBackColor = true;
            // 
            // dgvNguyenLieu
            // 
            this.dgvNguyenLieu.AllowUserToAddRows = false;
            this.dgvNguyenLieu.AllowUserToDeleteRows = false;
            this.dgvNguyenLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguyenLieu.BackgroundColor = System.Drawing.Color.White;
            this.dgvNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguyenLieu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNguyenLieu.Location = new System.Drawing.Point(12, 222);
            this.dgvNguyenLieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvNguyenLieu.MultiSelect = false;
            this.dgvNguyenLieu.Name = "dgvNguyenLieu";
            this.dgvNguyenLieu.ReadOnly = true;
            this.dgvNguyenLieu.RowHeadersWidth = 51;
            this.dgvNguyenLieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNguyenLieu.Size = new System.Drawing.Size(476, 374);
            this.dgvNguyenLieu.TabIndex = 13;
            // 
            // pnlPhieuNhap
            // 
            this.pnlPhieuNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.pnlPhieuNhap.Controls.Add(this.lblTitlePhieuNhap);
            this.pnlPhieuNhap.Controls.Add(this.lblMaNhanVien);
            this.pnlPhieuNhap.Controls.Add(this.txtMaNhanVien);
            this.pnlPhieuNhap.Controls.Add(this.lblTenNhanVien);
            this.pnlPhieuNhap.Controls.Add(this.txtTenNhanVien);
            this.pnlPhieuNhap.Controls.Add(this.lblNgayNhap);
            this.pnlPhieuNhap.Controls.Add(this.dtpNgayNhap);
            this.pnlPhieuNhap.Controls.Add(this.lblNguyenLieu);
            this.pnlPhieuNhap.Controls.Add(this.cbbNguyenLieu);
            this.pnlPhieuNhap.Controls.Add(this.lblSoLuongNhap);
            this.pnlPhieuNhap.Controls.Add(this.txtSoLuongNhap);
            this.pnlPhieuNhap.Controls.Add(this.lblDonGiaNhap);
            this.pnlPhieuNhap.Controls.Add(this.txtDonGiaNhap);
            this.pnlPhieuNhap.Controls.Add(this.btnThemChiTiet);
            this.pnlPhieuNhap.Controls.Add(this.btnXoaChiTiet);
            this.pnlPhieuNhap.Controls.Add(this.btnLuuPhieuNhap);
            this.pnlPhieuNhap.Controls.Add(this.lblChiTietTam);
            this.pnlPhieuNhap.Controls.Add(this.dgvChiTietTam);
            this.pnlPhieuNhap.Controls.Add(this.lblLichSuPhieuNhap);
            this.pnlPhieuNhap.Controls.Add(this.dgvPhieuNhap);
            this.pnlPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPhieuNhap.Location = new System.Drawing.Point(0, 0);
            this.pnlPhieuNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlPhieuNhap.Name = "pnlPhieuNhap";
            this.pnlPhieuNhap.Padding = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.pnlPhieuNhap.Size = new System.Drawing.Size(525, 609);
            this.pnlPhieuNhap.TabIndex = 0;
            // 
            // lblTitlePhieuNhap
            // 
            this.lblTitlePhieuNhap.AutoSize = true;
            this.lblTitlePhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitlePhieuNhap.ForeColor = System.Drawing.Color.White;
            this.lblTitlePhieuNhap.Location = new System.Drawing.Point(14, 13);
            this.lblTitlePhieuNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitlePhieuNhap.Name = "lblTitlePhieuNhap";
            this.lblTitlePhieuNhap.Size = new System.Drawing.Size(155, 22);
            this.lblTitlePhieuNhap.TabIndex = 0;
            this.lblTitlePhieuNhap.Text = "Nhập Phiếu Kho";
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.ForeColor = System.Drawing.Color.White;
            this.lblMaNhanVien.Location = new System.Drawing.Point(15, 52);
            this.lblMaNhanVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(72, 13);
            this.lblMaNhanVien.TabIndex = 1;
            this.lblMaNhanVien.Text = "Mã nhân viên";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(101, 49);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.ReadOnly = true;
            this.txtMaNhanVien.Size = new System.Drawing.Size(136, 20);
            this.txtMaNhanVien.TabIndex = 2;
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.ForeColor = System.Drawing.Color.White;
            this.lblTenNhanVien.Location = new System.Drawing.Point(15, 84);
            this.lblTenNhanVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(76, 13);
            this.lblTenNhanVien.TabIndex = 3;
            this.lblTenNhanVien.Text = "Tên nhân viên";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(101, 81);
            this.txtTenNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.ReadOnly = true;
            this.txtTenNhanVien.Size = new System.Drawing.Size(188, 20);
            this.txtTenNhanVien.TabIndex = 4;
            // 
            // lblNgayNhap
            // 
            this.lblNgayNhap.AutoSize = true;
            this.lblNgayNhap.ForeColor = System.Drawing.Color.White;
            this.lblNgayNhap.Location = new System.Drawing.Point(15, 117);
            this.lblNgayNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayNhap.Name = "lblNgayNhap";
            this.lblNgayNhap.Size = new System.Drawing.Size(59, 13);
            this.lblNgayNhap.TabIndex = 5;
            this.lblNgayNhap.Text = "Ngày nhập";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNhap.Location = new System.Drawing.Point(101, 114);
            this.dtpNgayNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(136, 20);
            this.dtpNgayNhap.TabIndex = 6;
            // 
            // lblNguyenLieu
            // 
            this.lblNguyenLieu.AutoSize = true;
            this.lblNguyenLieu.ForeColor = System.Drawing.Color.White;
            this.lblNguyenLieu.Location = new System.Drawing.Point(322, 52);
            this.lblNguyenLieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNguyenLieu.Name = "lblNguyenLieu";
            this.lblNguyenLieu.Size = new System.Drawing.Size(63, 13);
            this.lblNguyenLieu.TabIndex = 7;
            this.lblNguyenLieu.Text = "Nguyên liệu";
            // 
            // cbbNguyenLieu
            // 
            this.cbbNguyenLieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNguyenLieu.FormattingEnabled = true;
            this.cbbNguyenLieu.Location = new System.Drawing.Point(394, 49);
            this.cbbNguyenLieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbNguyenLieu.Name = "cbbNguyenLieu";
            this.cbbNguyenLieu.Size = new System.Drawing.Size(181, 21);
            this.cbbNguyenLieu.TabIndex = 8;
            // 
            // lblSoLuongNhap
            // 
            this.lblSoLuongNhap.AutoSize = true;
            this.lblSoLuongNhap.ForeColor = System.Drawing.Color.White;
            this.lblSoLuongNhap.Location = new System.Drawing.Point(322, 84);
            this.lblSoLuongNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoLuongNhap.Name = "lblSoLuongNhap";
            this.lblSoLuongNhap.Size = new System.Drawing.Size(76, 13);
            this.lblSoLuongNhap.TabIndex = 9;
            this.lblSoLuongNhap.Text = "Số lượng nhập";
            // 
            // txtSoLuongNhap
            // 
            this.txtSoLuongNhap.Location = new System.Drawing.Point(394, 81);
            this.txtSoLuongNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoLuongNhap.Name = "txtSoLuongNhap";
            this.txtSoLuongNhap.Size = new System.Drawing.Size(91, 20);
            this.txtSoLuongNhap.TabIndex = 10;
            // 
            // lblDonGiaNhap
            // 
            this.lblDonGiaNhap.AutoSize = true;
            this.lblDonGiaNhap.ForeColor = System.Drawing.Color.White;
            this.lblDonGiaNhap.Location = new System.Drawing.Point(322, 117);
            this.lblDonGiaNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDonGiaNhap.Name = "lblDonGiaNhap";
            this.lblDonGiaNhap.Size = new System.Drawing.Size(71, 13);
            this.lblDonGiaNhap.TabIndex = 11;
            this.lblDonGiaNhap.Text = "Đơn giá nhập";
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Location = new System.Drawing.Point(394, 114);
            this.txtDonGiaNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(91, 20);
            this.txtDonGiaNhap.TabIndex = 12;
            // 
            // btnThemChiTiet
            // 
            this.btnThemChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnThemChiTiet.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnThemChiTiet.IconColor = System.Drawing.Color.White;
            this.btnThemChiTiet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThemChiTiet.Location = new System.Drawing.Point(518, 78);
            this.btnThemChiTiet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemChiTiet.Name = "btnThemChiTiet";
            this.btnThemChiTiet.Size = new System.Drawing.Size(82, 29);
            this.btnThemChiTiet.TabIndex = 13;
            this.btnThemChiTiet.Text = "Thêm NL";
            this.btnThemChiTiet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemChiTiet.UseVisualStyleBackColor = true;
            // 
            // btnXoaChiTiet
            // 
            this.btnXoaChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnXoaChiTiet.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.btnXoaChiTiet.IconColor = System.Drawing.Color.White;
            this.btnXoaChiTiet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoaChiTiet.Location = new System.Drawing.Point(518, 112);
            this.btnXoaChiTiet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaChiTiet.Name = "btnXoaChiTiet";
            this.btnXoaChiTiet.Size = new System.Drawing.Size(82, 29);
            this.btnXoaChiTiet.TabIndex = 14;
            this.btnXoaChiTiet.Text = "Xóa dòng";
            this.btnXoaChiTiet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaChiTiet.UseVisualStyleBackColor = true;
            // 
            // btnLuuPhieuNhap
            // 
            this.btnLuuPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuPhieuNhap.ForeColor = System.Drawing.Color.White;
            this.btnLuuPhieuNhap.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnLuuPhieuNhap.IconColor = System.Drawing.Color.White;
            this.btnLuuPhieuNhap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLuuPhieuNhap.Location = new System.Drawing.Point(518, 146);
            this.btnLuuPhieuNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuuPhieuNhap.Name = "btnLuuPhieuNhap";
            this.btnLuuPhieuNhap.Size = new System.Drawing.Size(82, 29);
            this.btnLuuPhieuNhap.TabIndex = 15;
            this.btnLuuPhieuNhap.Text = "Lưu phiếu";
            this.btnLuuPhieuNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuuPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // lblChiTietTam
            // 
            this.lblChiTietTam.AutoSize = true;
            this.lblChiTietTam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblChiTietTam.ForeColor = System.Drawing.Color.White;
            this.lblChiTietTam.Location = new System.Drawing.Point(15, 174);
            this.lblChiTietTam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChiTietTam.Name = "lblChiTietTam";
            this.lblChiTietTam.Size = new System.Drawing.Size(204, 17);
            this.lblChiTietTam.TabIndex = 16;
            this.lblChiTietTam.Text = "Chi tiết phiếu nhập hiện tại";
            // 
            // dgvChiTietTam
            // 
            this.dgvChiTietTam.AllowUserToAddRows = false;
            this.dgvChiTietTam.AllowUserToDeleteRows = false;
            this.dgvChiTietTam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietTam.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietTam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietTam.Location = new System.Drawing.Point(15, 197);
            this.dgvChiTietTam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvChiTietTam.MultiSelect = false;
            this.dgvChiTietTam.Name = "dgvChiTietTam";
            this.dgvChiTietTam.ReadOnly = true;
            this.dgvChiTietTam.RowHeadersWidth = 51;
            this.dgvChiTietTam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietTam.Size = new System.Drawing.Size(792, 179);
            this.dgvChiTietTam.TabIndex = 17;
            // 
            // lblLichSuPhieuNhap
            // 
            this.lblLichSuPhieuNhap.AutoSize = true;
            this.lblLichSuPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblLichSuPhieuNhap.ForeColor = System.Drawing.Color.White;
            this.lblLichSuPhieuNhap.Location = new System.Drawing.Point(15, 390);
            this.lblLichSuPhieuNhap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLichSuPhieuNhap.Name = "lblLichSuPhieuNhap";
            this.lblLichSuPhieuNhap.Size = new System.Drawing.Size(146, 17);
            this.lblLichSuPhieuNhap.TabIndex = 18;
            this.lblLichSuPhieuNhap.Text = "Lịch sử phiếu nhập";
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.AllowUserToAddRows = false;
            this.dgvPhieuNhap.AllowUserToDeleteRows = false;
            this.dgvPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuNhap.BackgroundColor = System.Drawing.Color.White;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(15, 413);
            this.dgvPhieuNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.ReadOnly = true;
            this.dgvPhieuNhap.RowHeadersWidth = 51;
            this.dgvPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(792, 289);
            this.dgvPhieuNhap.TabIndex = 19;
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.splitContainer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmNhapHang";
            this.Text = "Nhập Hàng";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.pnlNguyenLieu.ResumeLayout(false);
            this.pnlNguyenLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguyenLieu)).EndInit();
            this.pnlPhieuNhap.ResumeLayout(false);
            this.pnlPhieuNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietTam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.ResumeLayout(false);

        }
    }
}