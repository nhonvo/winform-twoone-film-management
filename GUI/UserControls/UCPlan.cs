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
    public partial class UCPlan : UserControl
    {
        string mode;
        const string ADD = "ADD";
        const string UPDATE = "UPDATE";
        public UCPlan()
        {
            InitializeComponent();
        }

        #region dbMethods
        private PlanBUS planBUS = new PlanBUS();
        public void LoadPlan()
        {
            dataGridViewPlan.DataSource = planBUS.GetAll();
        }
        public void CreatePlan()
        {

            GoiDichVu newPlan = new GoiDichVu()
            {
                TenGoiDV= txtPlanName.Text ,
                GiaGoiDV = Int32.Parse(txtPlanPrice.Text) ,
                MoTaGoiDichVu = txtPlanDescription.Text

            };

            planBUS.Insert(newPlan);
            planBUS.Save();
        }
        public void UpdatePlan()
        {
            int PlanID = Int32.Parse(txtPlanId.Text);
            string name = txtPlanName.Text;
            int price = Int32.Parse(txtPlanPrice.Text);
            string description = txtPlanDescription.Text;

            GoiDichVu updatePlan = planBUS.Find(PlanID);
            updatePlan.TenGoiDV = name;
            updatePlan.GiaGoiDV = price;
            updatePlan.MoTaGoiDichVu= description;

            planBUS.Update(updatePlan);
            planBUS.Save();
        }
        public void DeletePlan()
        {
            int PlanID = Int32.Parse(txtPlanId.Text);
            GoiDichVu deletePlan = planBUS.Find(PlanID);

            planBUS.Delete(deletePlan);
            planBUS.Save();
        }
        #endregion
        private void Plan_Load(object sender, EventArgs e)
        {
            LoadPlan();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            txtPlanId.Text = "-1";
            txtPlanName.Text = "";
            txtPlanPrice.Text = "";
            txtPlanDescription.Text = "";
            mode = ADD;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            DeletePlan();
            LoadPlan();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPlanName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo");
                return;
            }

            String msg = "";
            if (mode == ADD)
            {
                CreatePlan();
                msg = "Thêm Thành Công";
            }
            else if (mode == UPDATE)
            {
                UpdatePlan();
                msg = "Cập Nhật Thành Công";
            }
            LoadPlan();
            MessageBox.Show(msg, "Thông Báo");
        }

        private void dataGridViewPlan_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewPlan.CurrentRow;
            string PlanID = (selectedRow.Cells[0].Value != null) ? selectedRow.Cells[0].Value.ToString() : "";
            string name = (selectedRow.Cells[1].Value != null) ? selectedRow.Cells[1].Value.ToString() : "";
            string price = (selectedRow.Cells[2].Value != null) ? selectedRow.Cells[2].Value.ToString() : "";
            string summary = (selectedRow.Cells[3].Value != null) ? selectedRow.Cells[3].Value.ToString() : "";
            txtPlanId.Text = PlanID;
            txtPlanName.Text = name;
            txtPlanPrice.Text = price;
            txtPlanDescription.Text = summary;
            mode = UPDATE;
        }
    }
}
