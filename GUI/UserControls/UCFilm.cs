using MovieWinform.BUS;
using MovieWinform.GUI.Forms;
using MovieWinform.Model;
using MovieWinform.Properties;
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
using ZedGraph;

namespace MovieWinform
{
    public partial class UCFilm : UserControl
    {
        string mode;
        const string ADD = "ADD";
        const string UPDATE = "UPDATE";
        public UCFilm()
        {
            InitializeComponent();
            txtFilmID.Enabled = false;
        }
        #region dbMethods
        FilmBUS filmBUS = new FilmBUS();
        LanguageBUS languageBUS = new LanguageBUS();
        NationBUS nationBUS = new NationBUS();
        public void LoadMovie()
        {
            phimBindingSource.DataSource = filmBUS.Films;
        }
        private void LoadActor()
        {
            pnlActor.Controls.Clear();
            int id;
            DataGridViewRow selectedRow = movieDataGridView.CurrentRow;
            id = Convert.ToInt32(selectedRow.Cells[0].Value);
            var actors = filmBUS.GetActorsById(id);
            foreach (var actor in actors)
            {
                Button btn = new Button();
                btn.Text = actor.TenDienVien;
                pnlActor.Controls.Add(btn);
            }
        }
        private void LoadDirector()
        {
            pnlDirector.Controls.Clear();
            int id;
            DataGridViewRow selectedRow = movieDataGridView.CurrentRow;
            id = Convert.ToInt32(selectedRow.Cells[0].Value);
            var directors = filmBUS.GetDirectorById(id);
            foreach (var director in directors)
            {
                Button btn = new Button();
                btn.Text = director.TenDaoDien;
                pnlDirector.Controls.Add(btn);
            }
        }
        private void LoadGenre()
        {
            pnlGenre.Controls.Clear();
            int id;
            DataGridViewRow selectedRow = movieDataGridView.CurrentRow;
            id = Convert.ToInt32(selectedRow.Cells[0].Value);
            var genres = filmBUS.GetGenreById(id);
            foreach (var genre in genres)
            {
                Button btn = new Button();
                btn.Text = genre.TenTheLoai;
                pnlGenre.Controls.Add(btn);
            }
        }
        private void LoadHashTag()
        {
            pnlHashTag.Controls.Clear();
            int id;
            DataGridViewRow selectedRow = movieDataGridView.CurrentRow;
            id = Convert.ToInt32(selectedRow.Cells[0].Value);
            var hashTags = filmBUS.GetHashTagById(id);
            foreach (var hashTag in hashTags)
            {
                Button btn = new Button();
                btn.Text = hashTag.TenTag;
                pnlHashTag.Controls.Add(btn);
            }
        }
        public void CreateMovie()
        {
            Phim newMovie = new Phim();
            newMovie.TenPhim = txtName.Text;
            newMovie.NgaySanXuat = dtpReleaseDate.Value;
            newMovie.NoiDungPhim = txtDescription.Text;
            newMovie.NoiDungPhimTomTat = txtSummary.Text;
            newMovie.DiemIMDB = Convert.ToDouble(txtIDMb.Text);
            newMovie.LuotXem = Convert.ToInt32(txtView.Text);
            newMovie.ThoiLuong = Convert.ToInt32(txtLength.Text);
            newMovie.HinhBanner = imageUpload;
            newMovie.LinkPhim = txtLink.Text;
            newMovie.LinkPhimVip = txtVIPLink.Text;
            newMovie.TrailerPhim = txtTrailer.Text;
            newMovie.MaNgonNgu = Convert.ToInt32(cbxLanguage.SelectedValue);
            newMovie.MaNuoc = Convert.ToInt32(cbxNation.SelectedValue);
            filmBUS.Insert(newMovie);
            filmBUS.Save();
        }
        public void UpdateMovie()
        {
            int id = Int32.Parse(txtFilmID.Text);
            Phim updateMovie = filmBUS.Find(id);
            updateMovie.MaPhim = Convert.ToInt32(txtFilmID.Text);
            updateMovie.TenPhim = txtName.Text;
            updateMovie.NgaySanXuat = dtpReleaseDate.Value;
            updateMovie.NoiDungPhim = txtDescription.Text;
            updateMovie.NoiDungPhimTomTat = txtSummary.Text;
            updateMovie.DiemIMDB = Convert.ToDouble(txtIDMb.Text);
            updateMovie.LuotXem = Convert.ToInt32(txtView.Text);
            updateMovie.ThoiLuong = Convert.ToInt32(txtLength.Text);
            updateMovie.HinhBanner = imageUpload;
            updateMovie.LinkPhim = txtLink.Text;
            updateMovie.LinkPhimVip = txtVIPLink.Text;
            updateMovie.TrailerPhim = txtTrailer.Text;
            updateMovie.MaNgonNgu = Convert.ToInt32(cbxLanguage.SelectedValue);
            updateMovie.MaNuoc = Convert.ToInt32(cbxNation.SelectedValue);
            filmBUS.Update(updateMovie);
            filmBUS.Save();
        }
        public void DeleteMovie()
        {
            int id = Int32.Parse(txtFilmID.Text);
            Phim deleteMovie = filmBUS.Find(id);
            filmBUS.Delete(deleteMovie);
            filmBUS.Save();
        }
        public void SearchFilm(string search)
        {
            List<Phim> phim = filmBUS.Search(search);
            phimBindingSource.DataSource = phim;
        }
        #endregion
        String imageUpload;

        private void FrmMovie_Load(object sender, EventArgs e)
        {
            LoadMovie();
            LoadActor();
            LoadDirector();
            LoadGenre();
            LoadHashTag();
            ngonNguBindingSource.DataSource = languageBUS.Languages;
            datNuocBindingSource.DataSource = nationBUS.Nations;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            txtFilmID.Text = "0";
            txtName.Text = "";
            txtDescription.Text = "";
            txtSummary.Text = "";
            txtIDMb.Text = "";
            txtView.Text = "";
            txtLength.Text = "";
            txtLink.Text = "";
            txtVIPLink.Text = "";
            txtTrailer.Text = "";
            mode = ADD;
            pnlActor.Controls.Clear();
            pnlDirector.Controls.Clear();
            pnlGenre.Controls.Clear();
            pnlHashTag.Controls.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteMovie();
            LoadMovie();
            LoadActor();
            LoadDirector();
            LoadGenre();
            LoadHashTag();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            int maNgonNgu = Int32.Parse(txtFilmID.Text);

            String msg = "";
            if (txtName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                return;
            }
            if (mode == ADD)
            {
                msg = "Thêm Thành Công";
                CreateMovie();
            }
            else if (mode == UPDATE)
            {
                msg = "Cập Nhật Thành Công";
                UpdateMovie();
            }
            MessageBox.Show(msg, "Thông Báo");
            LoadMovie();
            LoadActor();
            LoadDirector();
            LoadGenre();
            LoadHashTag();
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

        private void movieDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            mode = UPDATE;
            DataGridViewRow selectedRow = movieDataGridView.CurrentRow;
            string ActorImage = (selectedRow.Cells[8].Value != null) ? selectedRow.Cells[8].Value.ToString() : "";
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            string binPath = Path.GetDirectoryName(startupPath);
            string path = Path.GetDirectoryName(binPath);
            Image image = Image.FromFile(path + @"\Resources\MoviePosters\" + ActorImage);
            pictureBoxActor.Image = image;
            LoadActor();
            LoadDirector();
            LoadGenre();
            LoadHashTag();
        }
        private void label8_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            SearchFilm(search);
        }

        private void txtSearch_MouseEnter(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void btnModifyActor_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtFilmID.Text);
            if(id > 0)
            {
                FrmModifyActorInMovie form = new FrmModifyActorInMovie();
                form.filmID = id;
                form.ShowDialog();
                LoadActor();
            }
        }

        private void btnModifyDirector_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtFilmID.Text);
            if( id > 0)
            {
                FrmModifyDirectorInMovie form = new FrmModifyDirectorInMovie();
                form.filmID = id;
                form.ShowDialog();
                LoadDirector();
            }
        }

        private void btnModifyGenre_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtFilmID.Text);
            if(id > 0)
            {
                FrmModifyGenreInMovie form = new FrmModifyGenreInMovie();
                form.filmID = id;
                form.ShowDialog();
                LoadGenre();
            }
        }

        private void btnModifyHashTag_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(txtFilmID.Text);
            if(id > 0)
            {
                FrmModifyHashTagInMovie form = new FrmModifyHashTagInMovie();
                form.filmID = id;
                form.ShowDialog();
                LoadHashTag();
            }
        }
    }
}
