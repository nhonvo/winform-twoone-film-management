using MovieWinform.BUS;
using MovieWinform.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieWinform.GUI.Forms
{
    public partial class FrmModifyGenreInMovie : Form
    {
        public int filmID = 8;
        FilmBUS filmBUS = new FilmBUS();
        GenreBUS genreBUS = new GenreBUS();
        public FrmModifyGenreInMovie()
        {
            InitializeComponent();
        }
        private void AddGenre(int genreID)
        {
            filmBUS.AddGenre(filmID, genreID);
            filmBUS.Save();
        }
        private void AddNewGenre(int genreID)
        {
            TheLoai theLoai = genreBUS.Find(genreID);
            phimTheLoaiBindingSource.Add(theLoai);
        }
        private void LoadGenre()
        {
            theLoaiBindingSource.Clear();
            theLoaiBindingSource.DataSource = genreBUS.GenreList;
            phimTheLoaiBindingSource.DataSource = filmBUS.GetGenreById(filmID);
        }
        private void RemoveGenre(int genreID)
        {
            TheLoai theLoai = genreBUS.Find(genreID);
            phimTheLoaiBindingSource.Remove(theLoai);
            phimTheLoaiBindingSource.DataSource = filmBUS.GetGenreById(filmID);
        }
        private void DeleteGenre(int genreID)
        {
            filmBUS.DeleteGenre(filmID, genreID);
            filmBUS.Save();
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            int genreID = Convert.ToInt32(lbxExistGenre.SelectedValue);
            if (!filmBUS.ExistGenre(filmID, genreID))
            {
                AddGenre(genreID);
                AddNewGenre(genreID);
            }
            else MessageBox.Show("Exist Genre");
        }
        private void FrmModifyGenreInMovie_Load(object sender, EventArgs e)
        {
            LoadGenre();
        }
        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            int genreID = Convert.ToInt32(lbxGenreMovie.SelectedValue);
            DeleteGenre(genreID);
            RemoveGenre(genreID);
        }
    }
}
