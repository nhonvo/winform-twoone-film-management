using MovieWinform.BUS;
using MovieWinform.DAO;
using MovieWinform.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieWinform
{
    public partial class UCDirector : UserControl
    {
        string mode;
        const string ADD = "ADD";
        const string UPDATE = "UPDATE";
        String imageUpload;
        private int pageNumber = 1;
        private int numberRecord = 10;

        public UCDirector()
        {
            InitializeComponent();
        }

        #region dbMethods
        private  DirectorBUS directorBUS = new DirectorBUS();
        public void LoadDirector()
        {
            dataGridViewDirector.DataSource = directorBUS.LoadData(pageNumber, numberRecord);
        }

        public void CreateDirector()
        {
            DaoDien newDirector = new DaoDien()
            {
                TenDaoDien = txtDirectorName.Text,
                HinhAnhDaoDien = imageUpload
            };

            directorBUS.Insert(newDirector);
            directorBUS.Save();
        }
        public void UpdateDirector()
        {
            int DirectorId = Int32.Parse(txtDirectorName.Text);
            string DirectorName = txtDirectorName.Text;
            DaoDien updateDirector = directorBUS.Find(DirectorId);
            updateDirector.TenDaoDien = DirectorName;
            updateDirector.HinhAnhDaoDien = imageUpload;
            directorBUS.Update(updateDirector);
            directorBUS.Save();
        }
        public void DeleteDirector()
        {
            int DirectorId = Int32.Parse(txtDirectorName.Text);
            DaoDien deleteDirector = directorBUS.Find(DirectorId);

            directorBUS.Delete(deleteDirector);
            directorBUS.Save();
        }
        #endregion
        private void Director_Load(object sender, EventArgs e)
        {
            LoadDirector();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            txtDirectorId.Text = "-1";
            txtDirectorName.Text = "";
            mode = ADD;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            DeleteDirector();
            LoadDirector();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDirectorName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo");
                return;
            }

            String msg = "";
            if (mode == ADD)
            {
                CreateDirector();
                msg = "Thêm Thành Công";
            }
            else if (mode == UPDATE)
            {
                UpdateDirector();
                msg = "Cập Nhật Thành Công";
            }
            LoadDirector();
            MessageBox.Show(msg, "Thông Báo");
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxDirector.Image = new Bitmap(opnfd.FileName);
            }
            imageUpload = opnfd.SafeFileName;
        }

        private void dataGridViewDirector_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewDirector.CurrentRow;
            string DirectorId = (selectedRow.Cells[0].Value != null) ? selectedRow.Cells[0].Value.ToString() : "";
            string DirectorName = (selectedRow.Cells[1].Value != null) ? selectedRow.Cells[1].Value.ToString() : "";
            string DirectorImage = (selectedRow.Cells[2].Value != null) ? selectedRow.Cells[2].Value.ToString() : "";
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            string binPath = Path.GetDirectoryName(startupPath);
            string path = Path.GetDirectoryName(binPath);
            Image image = Image.FromFile(path + @"\Resources\sample\" + DirectorImage);
            pictureBoxDirector.Image = image;
            txtDirectorName.Text = DirectorId;
            txtDirectorName.Text = DirectorName;
            mode = UPDATE;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int totalRecord = 0;
            using (MovieWinformDBcontext db = new MovieWinformDBcontext())
            {
                totalRecord = db.DienViens.Count();
            }
            if (pageNumber + 1 < totalRecord / numberRecord)
            {
                pageNumber++;
                dataGridViewDirector.DataSource = directorBUS.LoadData(pageNumber, numberRecord);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (pageNumber - 1 > 0)
            {
                pageNumber--;
                dataGridViewDirector.DataSource = directorBUS.LoadData(pageNumber, numberRecord);
            }
        }
    }
}
