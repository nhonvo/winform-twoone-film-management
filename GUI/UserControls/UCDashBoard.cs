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
    public partial class UCDashBoard : UserControl
    {
        private MovieWinformDBcontext db = new MovieWinformDBcontext();
        public UCDashBoard()
        {
            InitializeComponent();
        }
        #region loading
        private void LoadData()
        {
            lblRevenueMonth.Text = ((decimal)(db.PhieuDangKies.Where(x => x.NgayThanhToan.Year == DateTime.Now.Year && x.NgayThanhToan.Month == DateTime.Now.Month).Sum(x => x.ThanhTien))).ToString("#,##0.00");
            lblRevenueYear.Text = ((decimal)(db.PhieuDangKies.Where(x => x.NgayThanhToan.Year == DateTime.Now.Year).Sum(x => x.ThanhTien))).ToString("#,##0.00");
            lblSubsciption.Text = (((decimal)(db.NguoiDungs.Where(x => x.PhieuDangKies.Any(y => y.MaGoiDV != 3)).Count())) / ((decimal)(db.NguoiDungs.Count())) * 100).ToString("#,##0.00")+ "%";
            var today = (db.PhieuDangKies.Where(x => x.NgayThanhToan.Year == DateTime.Now.Year && x.NgayThanhToan.Month == DateTime.Now.Month && x.NgayThanhToan.Day == DateTime.Now.Day).Sum(x => x.ThanhTien));
            decimal revenueToday = (today == null) ? 0 : (decimal)(today);
            lblRevenueToday.Text = revenueToday.ToString("#,##0.00");
        }
        private void LoadNewSubscriptionsByYear(int year)
        {
            var dataNewSubscriptionsMonthly = db.PhieuDangKies.Where(bill => bill.NgayThanhToan.Year == year).GroupBy(bill => bill.GoiDichVu.TenGoiDV).Select(group => new
            {
                Name = group.Key,
                Value = group.Count()
            }).ToList();
            //Chart

            tmNewSubscriptionsByYear.Titles.Clear();
            tmNewSubscriptionsByYear.Titles.Add("New subscription in " + year);
            tmNewSubscriptionsByYear.DataSource = dataNewSubscriptionsMonthly;
            tmNewSubscriptionsByYear.Series["tmNewSubscriptionsByYear"].Label = "#PERCENT";

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
                //  MessageBox.Show(list[0].ToString());
                //f;
                tmNewSubscriptionsByMonth.Series.Add(new Series(plan));
                //tmPlanRevenueByMonth.Series[plan].IsValueShownAsLabel = true;
                tmNewSubscriptionsByMonth.Series[plan].ChartType = SeriesChartType.Spline;
                tmNewSubscriptionsByMonth.Series[plan].XValueMember = "Month";
                tmNewSubscriptionsByMonth.Series[plan].YValueMembers = "Value";
                tmNewSubscriptionsByMonth.Series[plan].Points.DataBindXY(months, list);
           
            }
            tmNewSubscriptionsByMonth.Titles.Clear();
            tmNewSubscriptionsByMonth.Titles.Add("Plan Revenue By Month in " + year);
            //  tmPlanRevenueByMonth.DataSource = data1.ToList() ;
            //grdPlanRevenueByMonth.DataSource = fullData;
        }
        #endregion
        private void DashBoard_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadNewSubscriptionsByMonth(DateTime.Now.Year);
            LoadNewSubscriptionsByYear(DateTime.Now.Year);
        }
    }
}
