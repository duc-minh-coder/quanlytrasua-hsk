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
    public partial class frmTongQuan : Form
    {
        DrinkBUS drinkBUS = new DrinkBUS();
        BillBUS billBUS = new BillBUS();
        public frmTongQuan()
        {
            InitializeComponent();
        }

        private void frmTongQuan_Load(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = panel3.Width + 95;
            List<Drink> listDrink = drinkBUS.GetDrinkList();
            foreach (Drink drink in listDrink)
            {
                Button btn = new Button() { Width = 100, Height = 100, Text = drink.Name, Tag = drink, ForeColor = Color.Black, BackColor = Color.FromArgb(150, 150, 150) };
                Button btn2 = new Button() { Width = 100, Height = 100, Text = drink.Name, Tag = drink, ForeColor = Color.Black, BackColor = Color.FromArgb(150, 150, 150) };
                btn.MouseDown += Btn_MouseDown;
                btn2.MouseDown += Btn_MouseDown;
                btn.Click += Btn_Click;
                btn2.Click += Btn_Click;
                flpTatCa.Controls.Add(btn);
                switch (drink.idCategory)
                {
                    case 0:
                        flpTraSua.Controls.Add(btn2);
                        break;
                    case 1:
                        flpHongTra.Controls.Add(btn2);
                        break;
                    case 2:
                        flpSinhTo.Controls.Add(btn2);
                        break;
                    case 3:
                        flpNuocEp.Controls.Add(btn2);
                        break;
                    default:
                        break;
                }
            }
        }

        private void Btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Btn_Click(sender, e);
                btnThem_Click(sender, e);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            txtTenMatHang.Text = ((sender as Button).Tag as Drink).Name;
            txtGia.Text = ((sender as Button).Tag as Drink).Price.ToString();
            txtID.Text = ((sender as Button).Tag as Drink).idDrink.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString() == txtID.Text)
                {
                    row.Cells["columnSoLuong"].Value = Convert.ToInt32(row.Cells["columnSoLuong"].Value) + Convert.ToInt32(numericUpDown1.Value);
                    row.Cells["columnThanhTien"].Value = Convert.ToInt32(row.Cells["columnSoLuong"].Value) * Convert.ToInt32(row.Cells["columnGia"].Value);
                    return;
                }
            }
            dataGridView1.Rows.Add(txtID.Text, txtTenMatHang.Text, txtGia.Text, numericUpDown1.Value, Convert.ToInt32(txtGia.Text) * (int)numericUpDown1.Value);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtTenMatHang.Text = dataGridView1.SelectedRows[0].Cells["columnTen"].Value.ToString();
                txtGia.Text = dataGridView1.SelectedRows[0].Cells["columnGia"].Value.ToString();
                txtID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {          
            string date = (DateTime.Now.Month + "/" +DateTime.Now.Day  + "/" + DateTime.Now.Year).ToString();
            int totalprice = 0;
            foreach( DataGridViewRow row in dataGridView1.Rows)
            {
                totalprice += Convert.ToInt32(row.Cells["columnThanhTien"].Value);
            }

            billBUS.insertBill(date, totalprice);

            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                billBUS.insertBillInfo( Convert.ToInt32(row.Cells["columnID"].Value), Convert.ToInt32(row.Cells["columnSoLuong"].Value));
                //dataGridView1.Rows.Remove(row);
            }
            dataGridView1.Rows.Clear();

        }

    }
}
