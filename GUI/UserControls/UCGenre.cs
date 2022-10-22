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
    public partial class UCGenre : UserControl
    {
        string mode;
        const string ADD = "ADD";
        const string UPDATE = "UPDATE";
        public UCGenre()
        {
            InitializeComponent();
        }

        #region dbMethods
        private static GenreBUS GenreDAO = new GenreBUS();
        public void LoadGenre()
        {
            dataGridViewGenre.DataSource = GenreDAO.GetAll();
        }
        public void CreateGenre()
        {
            TheLoai newGenre = new TheLoai()
            {
                TenTheLoai = txtGenreName.Text
            };

            GenreDAO.Insert(newGenre);
            GenreDAO.Save();
        }
        public void UpdateGenre()
        {
            int genreId = Int32.Parse(txtGenreId.Text);
            string TenTheLoai = txtGenreName.Text;
            TheLoai updateGenre = GenreDAO.Find(genreId);
            updateGenre.TenTheLoai = TenTheLoai;

            GenreDAO.Update(updateGenre);
            GenreDAO.Save();
        }
        public void DeleteGenre()
        {
            int genreId = Int32.Parse(txtGenreId.Text);
            TheLoai deleteGenre = GenreDAO.Find(genreId);

            GenreDAO.Delete(deleteGenre);
            GenreDAO.Save();
        }
        #endregion
        private void Genre_Load(object sender, EventArgs e)
        {
            LoadGenre();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            txtGenreId.Text = "-1";
            txtGenreName.Text = "";
            mode = ADD;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            DeleteGenre();
            LoadGenre();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtGenreName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo");
                return;
            }

            String msg = "";
            if (mode == ADD)
            {
                CreateGenre();
                msg = "Thêm Thành Công";
            }
            else if (mode == UPDATE)
            {
                UpdateGenre();
                msg = "Cập Nhật Thành Công";
            }
            LoadGenre();
            MessageBox.Show(msg, "Thông Báo");
        }

        private void dataGridViewGenre_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewGenre.CurrentRow;
            string genreId = (selectedRow.Cells[0].Value != null) ? selectedRow.Cells[0].Value.ToString() : "";
            string TenTheLoai = (selectedRow.Cells[1].Value != null) ? selectedRow.Cells[1].Value.ToString() : "";
            txtGenreId.Text = genreId;
            txtGenreName.Text = TenTheLoai;
            mode = UPDATE;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
