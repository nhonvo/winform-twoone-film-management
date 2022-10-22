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
using MovieWinform.BUS;
using MovieWinform.Model;
namespace MovieWinform
{
    public partial class UCHashTag : UserControl
    {
        string mode;
        const string ADD = "ADD";
        const string UPDATE = "UPDATE";
        public UCHashTag()
        {
            InitializeComponent();
            txtMaHashTag.Enabled = false;
        }

        #region dbMethods
        HashTagBUS hashTagBUS = new HashTagBUS();
        public void LoadHashTag()
        {
            dataGridViewHashTag.DataSource = hashTagBUS.GetAll();
        }
        public void CreateHashTag()
        {
            HashTag newHashTag = new HashTag();
            newHashTag.TenTag = txtTenHashTag.Text;

            hashTagBUS.Insert(newHashTag);
            hashTagBUS.Save();
        }
        public void UpdateHashTag()
        {
            int id = Int32.Parse(txtMaHashTag.Text);
            HashTag updateHashTag = hashTagBUS.Find(id);
            updateHashTag.TenTag = txtTenHashTag.Text;
            hashTagBUS.Update(updateHashTag);
            hashTagBUS.Save();
        }
        public void DeleteHashTag()
        {
            int id = Int32.Parse(txtMaHashTag.Text);
            HashTag deleteHashTag = hashTagBUS.Find(id);

            hashTagBUS.Delete(deleteHashTag);
            hashTagBUS.Save();
        }
        #endregion
        private void btnCreate_Click(object sender, EventArgs e)
        {
            txtTenHashTag.Text = "";
            mode = ADD;
        }

        private void frmHashTag_Load(object sender, EventArgs e)
        {
            LoadHashTag();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String msg = "";
            if (txtTenHashTag.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                return;
            }
            if (mode == ADD)
            {
                msg = "Thêm Thành Công";
                CreateHashTag();
            }
            else if (mode == UPDATE)
            {
                msg = "Cập Nhật Thành Công";
                int id = Int32.Parse(txtMaHashTag.Text);
                UpdateHashTag();
            }
            MessageBox.Show(msg, "Thông Báo");
            LoadHashTag();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int maHashTag = Int32.Parse(txtMaHashTag.Text);
            DeleteHashTag();
            LoadHashTag();
        }

        private void dataGridViewHashTag_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewHashTag.CurrentRow;
            string maNgonNgu = (selectedRow.Cells[0].Value != null) ? selectedRow.Cells[0].Value.ToString() : "";
            string tenNgonNgu = (selectedRow.Cells[1].Value != null) ? selectedRow.Cells[1].Value.ToString() : "";
            txtMaHashTag.Text = maNgonNgu;
            txtTenHashTag.Text = tenNgonNgu;
            mode = UPDATE;
        }
    }
}
