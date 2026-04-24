
namespace QuanLyQuanTraSua
{
    partial class frmThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btnDateReport = new System.Windows.Forms.Button();
            this.btnMonthReport = new System.Windows.Forms.Button();
            this.btnYearReport = new System.Windows.Forms.Button();
            this.chartCollum = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnReport = new System.Windows.Forms.Button();
            this.cldDateTime = new System.Windows.Forms.DateTimePicker();
            this.cbbMonth = new System.Windows.Forms.ComboBox();
            this.chartMoneyPercent = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartCollum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMoneyPercent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDateReport
            // 
            this.btnDateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnDateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDateReport.ForeColor = System.Drawing.Color.White;
            this.btnDateReport.Location = new System.Drawing.Point(0, 1);
            this.btnDateReport.Name = "btnDateReport";
            this.btnDateReport.Size = new System.Drawing.Size(111, 52);
            this.btnDateReport.TabIndex = 2;
            this.btnDateReport.Text = "Theo ngày";
            this.btnDateReport.UseVisualStyleBackColor = false;
            this.btnDateReport.Click += new System.EventHandler(this.btnDateReport_Click);
            // 
            // btnMonthReport
            // 
            this.btnMonthReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnMonthReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonthReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMonthReport.ForeColor = System.Drawing.Color.White;
            this.btnMonthReport.Location = new System.Drawing.Point(0, 50);
            this.btnMonthReport.Name = "btnMonthReport";
            this.btnMonthReport.Size = new System.Drawing.Size(111, 52);
            this.btnMonthReport.TabIndex = 3;
            this.btnMonthReport.Text = "Theo tháng";
            this.btnMonthReport.UseVisualStyleBackColor = false;
            this.btnMonthReport.Click += new System.EventHandler(this.btnMonthReport_Click);
            // 
            // btnYearReport
            // 
            this.btnYearReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnYearReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYearReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnYearReport.ForeColor = System.Drawing.Color.White;
            this.btnYearReport.Location = new System.Drawing.Point(0, 98);
            this.btnYearReport.Name = "btnYearReport";
            this.btnYearReport.Size = new System.Drawing.Size(111, 52);
            this.btnYearReport.TabIndex = 4;
            this.btnYearReport.Text = "Theo năm";
            this.btnYearReport.UseVisualStyleBackColor = false;
            // 
            // chartCollum
            // 
            chartArea1.Name = "Sell Number";
            this.chartCollum.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCollum.Legends.Add(legend1);
            this.chartCollum.Location = new System.Drawing.Point(551, 50);
            this.chartCollum.Name = "chartCollum";
            series1.ChartArea = "Sell Number";
            series1.Legend = "Legend1";
            series1.Name = "Số lượng";
            series2.ChartArea = "Sell Number";
            series2.Legend = "Legend1";
            series2.Name = "Doanh thu";
            this.chartCollum.Series.Add(series1);
            this.chartCollum.Series.Add(series2);
            this.chartCollum.Size = new System.Drawing.Size(809, 671);
            this.chartCollum.TabIndex = 5;
            this.chartCollum.Text = "Collum chart";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            title1.Name = "Title1";
            title1.Text = "Số lượng bán và doanh thu";
            this.chartCollum.Titles.Add(title1);
            this.chartCollum.Visible = false;
            // 
            // chartPie
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPie.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            legend2.Title = "Thức uống";
            this.chartPie.Legends.Add(legend2);
            this.chartPie.Location = new System.Drawing.Point(135, 50);
            this.chartPie.Name = "chartPie";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.IsValueShownAsLabel = true;
            series3.LabelFormat = "#,##%";
            series3.Legend = "Legend1";
            series3.Name = "Drink";
            this.chartPie.Series.Add(series3);
            this.chartPie.Size = new System.Drawing.Size(392, 332);
            this.chartPie.TabIndex = 4;
            this.chartPie.Text = "Pie Chart";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            title2.Name = "Title1";
            title2.Text = "Tỉ lệ số sản phẩm bán ra";
            this.chartPie.Titles.Add(title2);
            this.chartPie.Visible = false;
            this.chartPie.Click += new System.EventHandler(this.chartPie_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReport.Location = new System.Drawing.Point(383, 12);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(94, 26);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Visible = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // cldDateTime
            // 
            this.cldDateTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cldDateTime.CalendarForeColor = System.Drawing.Color.Gray;
            this.cldDateTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cldDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cldDateTime.Location = new System.Drawing.Point(117, 12);
            this.cldDateTime.Name = "cldDateTime";
            this.cldDateTime.Size = new System.Drawing.Size(251, 27);
            this.cldDateTime.TabIndex = 0;
            this.cldDateTime.Visible = false;
            // 
            // cbbMonth
            // 
            this.cbbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbMonth.FormattingEnabled = true;
            this.cbbMonth.Items.AddRange(new object[] {
            "Tháng Một",
            "Tháng Hai",
            "Tháng Ba",
            "Tháng Bốn ",
            "Tháng Năm",
            "Tháng Sáu",
            "Tháng Bảy",
            "Tháng Tám",
            "Tháng Chín",
            "Tháng Mười",
            "Tháng Mười Một",
            "Tháng Mười Hai"});
            this.cbbMonth.Location = new System.Drawing.Point(135, 10);
            this.cbbMonth.Name = "cbbMonth";
            this.cbbMonth.Size = new System.Drawing.Size(208, 28);
            this.cbbMonth.TabIndex = 6;
            this.cbbMonth.Visible = false;
            // 
            // chartMoneyPercent
            // 
            chartArea3.Name = "ChartArea1";
            this.chartMoneyPercent.ChartAreas.Add(chartArea3);
            legend3.Name = "Money";
            legend3.Title = "Thức uống";
            this.chartMoneyPercent.Legends.Add(legend3);
            this.chartMoneyPercent.Location = new System.Drawing.Point(135, 389);
            this.chartMoneyPercent.Name = "chartMoneyPercent";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.IsValueShownAsLabel = true;
            series4.LabelFormat = "#,##%";
            series4.Legend = "Money";
            series4.Name = "Money";
            this.chartMoneyPercent.Series.Add(series4);
            this.chartMoneyPercent.Size = new System.Drawing.Size(392, 332);
            this.chartMoneyPercent.TabIndex = 7;
            this.chartMoneyPercent.Text = "Pie Chart";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            title3.Name = "MoneyPercent";
            title3.Text = "Tỉ lệ doanh thu từng loại";
            this.chartMoneyPercent.Titles.Add(title3);
            this.chartMoneyPercent.Visible = false;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.chartMoneyPercent);
            this.Controls.Add(this.cbbMonth);
            this.Controls.Add(this.chartCollum);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.chartPie);
            this.Controls.Add(this.btnYearReport);
            this.Controls.Add(this.btnMonthReport);
            this.Controls.Add(this.cldDateTime);
            this.Controls.Add(this.btnDateReport);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.chartCollum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMoneyPercent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDateReport;
        private System.Windows.Forms.Button btnMonthReport;
        private System.Windows.Forms.Button btnYearReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPie;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.DateTimePicker cldDateTime;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCollum;
        private System.Windows.Forms.ComboBox cbbMonth;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMoneyPercent;
    }
}