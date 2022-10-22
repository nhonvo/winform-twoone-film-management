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
    public partial class UCActor : UserControl
    {
        string mode;
        const string ADD = "ADD";
        const string UPDATE = "UPDATE";
        private int pageNumber = 1;
        private int numberRecord = 10;
        public UCActor()
        {
            InitializeComponent();
        }

        #region dbMethods
        private ActorBUS actorBUS = new ActorBUS();
        public void LoadActor()
        {
            dataGridViewActor.DataSource = actorBUS.LoadData(pageNumber, numberRecord);
        }
        String imageUpload;

        public void CreateActor()
        {
            DienVien newActor = new DienVien()
            {
                TenDienVien = txtActorName.Text,
                HinhAnhDienVien = imageUpload
            };

            actorBUS.Insert(newActor);
            actorBUS.Save();
        }
        public void UpdateActor()
        {
            int actorId = Int32.Parse(txtActorId.Text);
            string actorName = txtActorName.Text;
            DienVien updateActor = actorBUS.Find(actorId);
            updateActor.TenDienVien = actorName;
            updateActor.HinhAnhDienVien = imageUpload;
            actorBUS.Update(updateActor);
            actorBUS.Save();
        }
        public void DeleteActor()
        {
            int actorId = Int32.Parse(txtActorId.Text);
            DienVien deleteActor = actorBUS.Find(actorId);
            actorBUS.Delete(deleteActor);
            actorBUS.Save();
        }
        #endregion
        private void Actor_Load(object sender, EventArgs e)
        {
            LoadActor();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            txtActorId.Text = "-1";
            txtActorName.Text = "";
            mode = ADD;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            DeleteActor();
            LoadActor();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtActorName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo");
                return;
            }

            String msg = "";
            if (mode == ADD)
            {
                CreateActor();
                msg = "Thêm Thành Công";
            }
            else if (mode == UPDATE)
            {
                UpdateActor();
                msg = "Cập Nhật Thành Công";
            }
            LoadActor();
            MessageBox.Show(msg, "Thông Báo");
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxActor.Image = new Bitmap(opnfd.FileName);
            }
            imageUpload = opnfd.SafeFileName;
        }

        private void dataGridViewActor_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewActor.CurrentRow;
            string actorId = (selectedRow.Cells[0].Value != null) ? selectedRow.Cells[0].Value.ToString() : "";
            string actorName = (selectedRow.Cells[1].Value != null) ? selectedRow.Cells[1].Value.ToString() : "";
            string ActorImage = (selectedRow.Cells[2].Value != null) ? selectedRow.Cells[2].Value.ToString() : "";
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            string binPath = Path.GetDirectoryName(startupPath);
            string path = Path.GetDirectoryName(binPath);
            Image image = Image.FromFile(path + @"\Resources\sample\" + ActorImage);
            pictureBoxActor.Image = image;
            txtActorId.Text = actorId;
            txtActorName.Text = actorName;
            mode = UPDATE;
        }
        
        private void btnNext_Click(object sender, EventArgs e)
        {
            int totalRecord = 0;
            using (MovieWinformDBcontext db = new MovieWinformDBcontext())
            {
                totalRecord = db.DienViens.Count();
            }
            if (pageNumber +1 < totalRecord / numberRecord)
            {
                pageNumber++;
                dataGridViewActor.DataSource = actorBUS.LoadData(pageNumber, numberRecord);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (pageNumber - 1 > 0)
            {
                pageNumber--;
                dataGridViewActor.DataSource = actorBUS.LoadData(pageNumber, numberRecord);
            }
           
        }
    }
}
