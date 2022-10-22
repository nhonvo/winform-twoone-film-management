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
using MovieWinform.Model;
namespace MovieWinform
{
    public partial class UCStatical : UserControl
    {
        int yearStart = 2002;
        int yearEnd = DateTime.Now.Year;
        int selectedYear;
        List<int> listYear = new List<int>();
        MovieWinformDBcontext db = new MovieWinformDBcontext();
        public UCStatical()
        {
            InitializeComponent();
            
            for(int i = yearEnd; i >= yearStart; i--)
                listYear.Add(i);
            cboChooseYear.DataSource = listYear;
            //tmPlanRevenue.Titles.Add("Doanh thu theo từng gói");
            //  tmPlanRevenueByYear.Titles.Add("Plan Revenue By Year " );
           
        }
        #region loading
        private void LoadPlanRevenueByYear(int year)
        {
            var dataPlanRevenueByYear = db.PhieuDangKies.Where(bill => bill.NgayThanhToan.Year == year).GroupBy(bill => bill.GoiDichVu.TenGoiDV).Select(group => new
            {
                Name = group.Key,
                Value = group.Sum(bill => bill.ThanhTien)
            }).ToList();
            //Chart

            grdPlanRevenueByYear.DataSource = dataPlanRevenueByYear;
            tmPlanRevenueByYear.Titles.Clear();
            tmPlanRevenueByYear.Titles.Add("Plan Revenue By Year " + year);
            tmPlanRevenueByYear.DataSource = dataPlanRevenueByYear;
            tmPlanRevenueByYear.Series["tmPlanRevenueByYear"].Label = "#PERCENT";

        }

        private void LoadNewSubscriptionsByYear(int year)
        {
            var dataNewSubscriptionsMonthly = db.PhieuDangKies.Where(bill => bill.NgayThanhToan.Year == year).GroupBy(bill => bill.GoiDichVu.TenGoiDV).Select(group => new
            {
                Name = group.Key,
                Value = group.Count()
            }).ToList();
            //Chart

            grdNewSubscriptionsByYear.DataSource = dataNewSubscriptionsMonthly;
            tmNewSubscriptionsByYear.Titles.Clear();
            tmNewSubscriptionsByYear.Titles.Add("New subscription in " + year);
            tmNewSubscriptionsByYear.DataSource = dataNewSubscriptionsMonthly;
            tmNewSubscriptionsByYear.Series["tmNewSubscriptionsByYear"].Label = "#PERCENT";

        }
        private void LoadPlanRevenueByMonth(int year)
        {
            var plans = db.PhieuDangKies.Where(bill => bill.NgayThanhToan.Year == year).GroupBy(bill => bill.GoiDichVu.TenGoiDV).Select(bill => bill.Key).ToList();
            var dataPlanRevenueByMonth = db.PhieuDangKies.Where(bill => bill.NgayThanhToan.Year == year).GroupBy(bill => new { bill.GoiDichVu.TenGoiDV, bill.NgayThanhToan.Month }).Select(group => new
            {
                Name = group.Key.TenGoiDV,
                Month = group.Key.Month,
                Value = group.Sum(bill => bill.ThanhTien)
            }).ToList();
            //MessageBox.Show(dataPlanRevenueByMonth.ToString());

            //tmPlanRevenueByMonth.DataSource = dataPlanRevenueByMonth;
           /* List<object> fullData = new List<object>();
            for (int i = 1; i <= 12; i++)
                fullData.Add(new List<float>());*/
            tmPlanRevenueByMonth.Series.Clear();
            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            grdPlanRevenueByMonth.Rows.Clear();
            foreach (var plan in plans)
            {
              //  Series s = new Series();
                List<float> list = new List<float>();
                for (int i = 1; i <= 12; i++)
                {
                    //list.Add(dataPlanRevenueByMonth.(bill => bill.Name == plan && bill.Month == i)); 
                    var data = dataPlanRevenueByMonth.FirstOrDefault(bill => bill.Name == plan && bill.Month == i);
                    if (data != null)
                    list.Add((float)data.Value);
                    else list.Add(0);
                }
                grdPlanRevenueByMonth.Rows.Add(plan, list[0], list[1], list[2], list[3], list[4], list[5], list[6], list[7], list[8], list[9], list[10], list[11]);
                //f;
                tmPlanRevenueByMonth.Series.Add(new Series(plan));
                //tmPlanRevenueByMonth.Series[plan].IsValueShownAsLabel = true;
                tmPlanRevenueByMonth.Series[plan].ChartType = SeriesChartType.Spline;
                tmPlanRevenueByMonth.Series[plan].XValueMember = "Month";
                tmPlanRevenueByMonth.Series[plan].YValueMembers = "Value";
                tmPlanRevenueByMonth.Series[plan].Points.DataBindXY(months,list);
                /*s.ChartType = SeriesChartType.Spline;
                s.LegendText = plan;
                tmPlanRevenueByMonth.Series.Add(s);*/
            }
            tmPlanRevenueByMonth.Titles.Clear();
            tmPlanRevenueByMonth.Titles.Add("Plan Revenue By Month in "+ year);
            //  tmPlanRevenueByMonth.DataSource = data1.ToList() ;
            //grdPlanRevenueByMonth.DataSource = fullData;
        }
        private void LoadNewSubscriptionsByMonth(int year)
        {
            var plans = db.PhieuDangKies.Where(bill => bill.NgayThanhToan.Year == year).GroupBy(bill => bill.GoiDichVu.TenGoiDV).Select(bill => bill.Key).ToList();
            var dataNewSubscriptionsByMonth = db.PhieuDangKies.Where(bill => bill.NgayThanhToan.Year == year).GroupBy(bill => new { bill.GoiDichVu.TenGoiDV, bill.NgayThanhToan.Month }).Select(group => new
            {
                Name = group.Key.TenGoiDV,
                Month = group.Key.Month,
                Value = group.Count()
            }).ToList();
          //  MessageBox.Show("hi");
            tmNewSubscriptionsByMonth.Series.Clear();
            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            grdNewSubscriptionsByMonth.Rows.Clear();
            foreach (var plan in plans)
            {
                List<int> list = new List<int>();
                for (int i = 1; i <= 12; i++)
                {
                    var data = dataNewSubscriptionsByMonth.FirstOrDefault(bill => bill.Name == plan && bill.Month == i);
                    if (data != null)
                        list.Add((int)data.Value);
                    else list.Add(0);
                }
                grdNewSubscriptionsByMonth.Rows.Add(plan, list[0], list[1], list[2], list[3], list[4], list[5], list[6], list[7], list[8], list[9], list[10], list[11]);
              //  MessageBox.Show(list[0].ToString());
                //f;
                tmNewSubscriptionsByMonth.Series.Add(new Series(plan));
                //tmPlanRevenueByMonth.Series[plan].IsValueShownAsLabel = true;
                tmNewSubscriptionsByMonth.Series[plan].ChartType = SeriesChartType.Spline;
                tmNewSubscriptionsByMonth.Series[plan].XValueMember = "Month";
                tmNewSubscriptionsByMonth.Series[plan].YValueMembers = "Value";
                tmNewSubscriptionsByMonth.Series[plan].Points.DataBindXY(months, list);
                /*s.ChartType = SeriesChartType.Spline;
                s.LegendText = plan;
                tmPlanRevenueByMonth.Series.Add(s);*/
            }
            tmNewSubscriptionsByMonth.Titles.Clear();
            tmNewSubscriptionsByMonth.Titles.Add("Plan Revenue By Month in " + year);
            //  tmPlanRevenueByMonth.DataSource = data1.ToList() ;
            //grdPlanRevenueByMonth.DataSource = fullData;
        }
        private void loadForm()
        {
            LoadPlanRevenueByYear(selectedYear);
            LoadNewSubscriptionsByYear(selectedYear);
            LoadPlanRevenueByMonth(selectedYear);
            LoadNewSubscriptionsByMonth(selectedYear);
        }
        #endregion
        private void cboChooseYear_SelectionChangeCommitted(object sender, EventArgs e)
        {
          //  selectedYear = (int)sender;
        }

        private void Statical_Load(object sender, EventArgs e)
        {
            selectedYear = yearEnd;
            loadForm();
        }

        private void cboChooseYear_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            selectedYear = Convert.ToInt32(cb.SelectedItem);
            loadForm();
        }

        private void tblBottom_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
