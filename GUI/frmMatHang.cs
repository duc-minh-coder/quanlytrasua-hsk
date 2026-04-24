using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanTraSua
{
    public partial class frmMatHang : Form
    {
        DrinkBUS drinkBUS = new DrinkBUS();
        DrinkCategoryBUS drinkCategoryBUS = new DrinkCategoryBUS();
        public frmMatHang()
        {
            InitializeComponent();
        }

        private void frmMatHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = drinkBUS.GetAllDrinksDetailed();
            dataGridView1.Columns["Loại"].Width = 150;
            dataGridView1.Columns["Giá"].Width = 100;
            dataGridView1.Columns["idDrink"].Visible = false;
            dataGridView1.Columns["idCategory"].Visible = false;

            cbbLoai.DisplayMember = "Name";
            cbbLoai.DataSource = drinkCategoryBUS.GetDrinkCategories();
            /*
            cbbLoai.DataBindings.Add(new Binding("SelectedIndex", dataGridView1.DataSource, "idCategory"));
            txtTenMatHang.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Tên"));
            txtGia.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Giá"));
            */
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtTenMatHang.Text = dataGridView1.SelectedRows[0].Cells["Tên"].Value.ToString();
                txtGia.Text = dataGridView1.SelectedRows[0].Cells["Giá"].Value.ToString();
                cbbLoai.SelectedIndex = cbbLoai.FindStringExact(dataGridView1.SelectedRows[0].Cells["Loại"].Value.ToString());
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenMatHang.Text == "" || txtGia.Text == "")
            {
                MessageBox.Show("Điền đủ thông tin trước khi thêm món");
            }
            else
            {
                if (drinkBUS.InsertDrink(txtTenMatHang.Text, txtGia.Text, (cbbLoai.SelectedItem as DrinkCategory).idCategory))
                {
                    MessageBox.Show("Đã thêm thành công");
                    dataGridView1.DataSource = drinkBUS.GetAllDrinksDetailed();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    if (drinkBUS.DeleteDrink(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idDrink"].Value)))
                    {
                        MessageBox.Show("Đã xóa thành công");
                        dataGridView1.DataSource = drinkBUS.GetAllDrinksDetailed();
                    }
                }
                else
                    MessageBox.Show("Chọn một món để xóa");
            }
            catch (NullReferenceException)
            {

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    if (drinkBUS.UpdateDrink(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idDrink"].Value), txtTenMatHang.Text, txtGia.Text, (cbbLoai.SelectedItem as DrinkCategory).idCategory))
                    {
                        MessageBox.Show("Đã sửa thành công");
                        dataGridView1.DataSource = drinkBUS.GetAllDrinksDetailed();
                    }
                }
                else
                    MessageBox.Show("Chọn một món để sửa");
            }
            catch (NullReferenceException)
            {

            }
        }
    }
}
