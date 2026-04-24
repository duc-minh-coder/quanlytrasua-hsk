using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using BUS;

namespace QuanLyQuanTraSua
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void chartPie_Click(object sender, EventArgs e)
        {

        }

        BillBUS billBUS = new BillBUS();

        DataTable dt;

        private bool dateReport = false;
        private bool monthReport = false;
        private bool yearReport = false;

        private int _day;
        private int _month;
        private int _year;

        // lay gia tri ngay, thang, nam
        private void getDateTime()
        {
            if (dateReport)
            {
                DateTime date = cldDateTime.Value.Date;
                _day = date.Day;
                _month = date.Month;
                _year = date.Year;
            }
            if (monthReport)
            {
                
                _month = (this.cbbMonth.SelectedIndex) + 1;               
            }
        }

        // ve chart
        private void paintChart()
        {           
            if (dateReport)
            {
                dt = billBUS.getReportByDate(_day, _month, _year);
            } else
            {
                if (monthReport)
                {
                    dt = billBUS.getReportByMonth(_month);
                } else
                {
                    // year report
                }
            }

            // bieu do tron ti le so hang ban ra
            chartPie.DataSource = dt;          
            chartPie.Series["Drink"].XValueMember = "Name";
            chartPie.Series["Drink"].YValueMembers = "PERCENTAGE_DRINK";
            chartPie.Series["Drink"].ChartType = SeriesChartType.Pie;

            // bieu do tron ti le doanh thu   
            chartMoneyPercent.DataSource = dt;
            chartMoneyPercent.Series["Money"].XValueMember = "Name";
            chartMoneyPercent.Series["Money"].YValueMembers = "PERCENTAGE_MONEY";
            chartMoneyPercent.Series["Money"].ChartType = SeriesChartType.Pie;

            // bieu do cot doanh thu va so luong ban ra     
            chartCollum.DataSource = dt;
            chartCollum.Series[0].XValueMember = "Name";
            chartCollum.Series[0].YValueMembers = "SO_LUONG";
            chartCollum.ChartAreas[0].AxisX.Title = "Loại đồ uống";
            chartCollum.ChartAreas[0].AxisY.Title = "Số lượng";

            chartCollum.Series[1].XValueMember = "Name";
            chartCollum.Series[1].YValueMembers = "MONEY";

            chartCollum.Series[1].YAxisType = AxisType.Secondary;
            
            // xoa line truc x bieu do cot
            chartCollum.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartCollum.ChartAreas[0].AxisX.MinorGrid.Enabled = false;

            // xoa line truc y 1 bieu do cot
            chartCollum.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chartCollum.ChartAreas[0].AxisY.MinorGrid.Enabled = false;

            // xoa line truc y 2 bieu do cot
            chartCollum.ChartAreas[0].AxisY2.MajorGrid.Enabled = false;
            chartCollum.ChartAreas[0].AxisY2.MinorGrid.Enabled = false;


            chartCollum.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            // hien thi label tung cot
            chartCollum.Series[0].IsValueShownAsLabel = true;
            chartCollum.Series[1].IsValueShownAsLabel = true;

            chartCollum.Series[0].ChartType = SeriesChartType.Column;
            chartCollum.Series[1].ChartType = SeriesChartType.Column;
        }

        // an chart
        private void hideChart()
        {
            chartPie.Visible = false;
            chartCollum.Visible = false;
            chartMoneyPercent.Visible = false;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            getDateTime();

            chartPie.Update();
            chartMoneyPercent.Update();
            chartCollum.Update();

            chartCollum.Visible = true;
            chartPie.Visible = true;
            chartMoneyPercent.Visible = true;

            paintChart();
        }

        // nut bao cao theo ngay
        private void btnDateReport_Click(object sender, EventArgs e)
        {
            hideChart();

            dateReport = true;
            monthReport = false;
            yearReport = false;

            cldDateTime.Visible = true;
            cbbMonth.Visible = false;
            btnReport.Visible = true;
          
        }

        // nut bao cao theo thang
        private void btnMonthReport_Click(object sender, EventArgs e)
        {
            hideChart();

            dateReport = false;
            monthReport = true;
            yearReport = false;

            cbbMonth.Visible = true;
            btnReport.Visible = true;
            cldDateTime.Visible = false;

            // lay gia tri thang hien tai
            this.cbbMonth.SelectedIndex = DateTime.Now.Month - 1;
        }
        
    }
}
