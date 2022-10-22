using MovieWinform.BUS;
using MovieWinform.DAO;
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

namespace MovieWinform
{
    public partial class UCNation : UserControl
    {
        string mode;
        const string ADD = "ADD";
        const string UPDATE = "UPDATE";
        public UCNation()
        {
            InitializeComponent();
        }

        #region dbMethods
        private static NationBUS NationDAO = new NationBUS();
        public void LoadNation()
        {
            dataGridViewNation.DataSource = NationDAO.GetAll();
        }
        public void CreateNation()
        {
            DatNuoc newNation = new DatNuoc()
            {
                TenNuoc = txtNationName.Text
            };

            NationDAO.Insert(newNation);
            NationDAO.Save();
        }
        public void UpdateNation()
        {
            int maDatNuoc = Int32.Parse(txtNationId.Text);
            string tenNuoc = txtNationName.Text;
            DatNuoc updateNation = NationDAO.Find(maDatNuoc);
            updateNation.TenNuoc = tenNuoc;

            NationDAO.Update(updateNation);
            NationDAO.Save();
        }
        public void DeleteNation()
        {
            int maDatNuoc = Int32.Parse(txtNationId.Text);
            DatNuoc deleteNation = NationDAO.Find(maDatNuoc);

            NationDAO.Delete(deleteNation);
            NationDAO.Save();
        }
        #endregion
        private void Nation_Load(object sender, EventArgs e)
        {
            LoadNation();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            txtNationId.Text = "-1";
            txtNationName.Text = "";
            mode = ADD;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            DeleteNation();
            LoadNation();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNationName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo");
                return;
            }

            String msg = "";
            if (mode == ADD)
            {
                CreateNation();
                msg = "Thêm Thành Công";
            }
            else if (mode == UPDATE)
            {
                UpdateNation();
                msg = "Cập Nhật Thành Công";
            }
            LoadNation();
            MessageBox.Show(msg, "Thông Báo");
        }

        private void dataGridViewNation_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewNation.CurrentRow;
            string maDatNuoc = (selectedRow.Cells[0].Value != null) ? selectedRow.Cells[0].Value.ToString() : "";
            string tenNuoc = (selectedRow.Cells[1].Value != null) ? selectedRow.Cells[1].Value.ToString() : "";
            txtNationId.Text = maDatNuoc;
            txtNationName.Text = tenNuoc;
            mode = UPDATE;
        }
    }
}
