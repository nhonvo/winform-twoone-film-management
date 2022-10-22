using MovieWinform.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieWinform.UserControls
{
    public partial class UCSubscription : UserControl
    {
        MovieWinformDBcontext db = new MovieWinformDBcontext();
        #region
        public UCSubscription()
        {
            InitializeComponent();
        }

        public void LoadSubsciption()
        {
            try
            {
                var query = from lang in db.PhieuDangKies
                            select new
                            {
                                lang.MaPhieuDangKy,
                                lang.MaGoiDV,
                                lang.MaNguoiDung,
                                lang.NgayThanhToan,
                                lang.NgayHetHan,
                                lang.KhuyenMai,
                                lang.ThanhTien

                            };
                var PhieuDangKies = query.ToList();
                dataGridViewActor.DataSource = PhieuDangKies;
                dataGridViewActor.Columns["MaPhieuDangKy"].HeaderText = "Subsription Id";
                dataGridViewActor.Columns["MaGoiDV"].HeaderText = "Plan Id";
                dataGridViewActor.Columns["MaNguoiDung"].HeaderText = "User id";
                dataGridViewActor.Columns["NgayThanhToan"].HeaderText = "Day payment";
                dataGridViewActor.Columns["NgayHetHan"].HeaderText = "Day Expired";
                dataGridViewActor.Columns["KhuyenMai"].HeaderText = "Sales";
                dataGridViewActor.Columns["ThanhTien"].HeaderText = "Total Money";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        #endregion

        private void dataGridViewActor_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dataGridViewActor.CurrentRow;

                string MaPhieuDangKy = (selectedRow.Cells[0].Value != null) ? selectedRow.Cells[0].Value.ToString() : "";
                string MaGoiDV = (selectedRow.Cells[1].Value != null) ? selectedRow.Cells[1].Value.ToString() : "";
                string MaNguoiDung = (selectedRow.Cells[2].Value != null) ? selectedRow.Cells[2].Value.ToString() : "";
                string NgayThanhToan = (selectedRow.Cells[3].Value != null) ? selectedRow.Cells[3].Value.ToString() : "";
                string NgayHetHan = (selectedRow.Cells[4].Value != null) ? selectedRow.Cells[4].Value.ToString() : "";
                string KhuyenMai = (selectedRow.Cells[5].Value != null) ? selectedRow.Cells[5].Value.ToString() : "";
                string ThanhTien = (selectedRow.Cells[6].Value != null) ? selectedRow.Cells[6].Value.ToString() : "";
                txtSubscriptionId.Text = MaPhieuDangKy;
                txtPlanId.Text = MaGoiDV;
                txtUserId.Text = MaNguoiDung;
                txtPaymentDay.Text = NgayThanhToan;
                txtExpiredDay.Text = NgayHetHan;
                txtSale.Text = KhuyenMai;
                txtTotalMoney.Text = ThanhTien;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Subsciption_Load(object sender, EventArgs e)
        {

            LoadSubsciption();
        }
    }
}
