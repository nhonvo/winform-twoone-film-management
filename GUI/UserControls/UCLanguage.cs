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
    public partial class UCLanguage : UserControl
    {
        string mode;
        const string ADD = "ADD";
        const string UPDATE = "UPDATE";
        public UCLanguage()
        {
            InitializeComponent();
        }

        #region dbMethods
        private static LanguageBUS languageBUS = new LanguageBUS();
        public void LoadLang()
        {
            dataGridViewLanguage.DataSource = languageBUS.GetAll();
        }
        public void CreateLang()
        {
            NgonNgu newLanguage = new NgonNgu()
            {
                TenNgonNgu = txtLanguageName.Text
            };

            languageBUS.Insert(newLanguage);
            languageBUS.Save();
        }
        public void UpdateLang()
        {
            int LanguageID = Int32.Parse(txtLanguageID.Text);
            string LanguageName = txtLanguageName.Text;
            NgonNgu updateLanguage = languageBUS.Find(LanguageID);
            updateLanguage.TenNgonNgu = LanguageName;

            languageBUS.Update(updateLanguage);
            languageBUS.Save();
        }
        public void DeleteLang()
        {
            int LanguageID = Int32.Parse(txtLanguageID.Text);
            NgonNgu deleteLanguage = languageBUS.Find(LanguageID);

            languageBUS.Delete(deleteLanguage);
            languageBUS.Save();
        }
        #endregion
        private void LanguageForm_Load(object sender, EventArgs e)
        {
            LoadLang();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            txtLanguageID.Text = "-1";
            txtLanguageName.Text = "";
            mode = ADD;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            DeleteLang();
            LoadLang();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtLanguageName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo");
                return;
            }

            String msg = "";
            if (mode == ADD)
            {
                CreateLang();
                msg = "Thêm Thành Công";
            }
            else if (mode == UPDATE)
            {
                UpdateLang();
                msg = "Cập Nhật Thành Công";
            }
            LoadLang();
            MessageBox.Show(msg, "Thông Báo");
        }

        private void dataGridViewLanguage_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewLanguage.CurrentRow;
            string LanguageID = (selectedRow.Cells[0].Value != null) ? selectedRow.Cells[0].Value.ToString() : "";
            string LanguageName = (selectedRow.Cells[1].Value != null) ? selectedRow.Cells[1].Value.ToString() : "";
            txtLanguageID.Text = LanguageID;
            txtLanguageName.Text = LanguageName;
            mode = UPDATE;
        }
    }
}
