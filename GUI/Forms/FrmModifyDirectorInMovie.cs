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
    public partial class FrmModifyDirectorInMovie : Form
    {
        public int filmID = 8;
        FilmBUS filmBUS = new FilmBUS();
        DirectorBUS directorBUS = new DirectorBUS();
        public FrmModifyDirectorInMovie()
        {
            InitializeComponent();
        }
        private void AddDirector(int directorID)
        {
            filmBUS.AddDirector(filmID, directorID);
            filmBUS.Save();
        }
        private void AddNewDirector(int directorID)
        {
            DaoDien daoDien = directorBUS.Find(directorID);
            phimDaoDienBindingSource.Add(daoDien);
        }
        private void LoadDirector()
        {
            daoDienBindingSource.Clear();
            daoDienBindingSource.DataSource = directorBUS.DirectorList;
            phimDaoDienBindingSource.DataSource = filmBUS.GetDirectorById(filmID);
        }
        private void RemoveDirector(int directorID)
        {
            DaoDien daoDien = directorBUS.Find(directorID);
            phimDaoDienBindingSource.Remove(daoDien);
            phimDaoDienBindingSource.DataSource = filmBUS.GetDirectorById(filmID);
        }
        private void DeleteDirector(int directorID)
        {
            filmBUS.DeleteDirector(filmID, directorID);
            filmBUS.Save();
        }

        private void btnAddDirector_Click(object sender, EventArgs e)
        {
            int directorID = Convert.ToInt32(lbxExistDirector.SelectedValue);
            if (!filmBUS.ExistDirector(filmID, directorID))
            {
                AddDirector(directorID);
                AddNewDirector(directorID);
            }
            else MessageBox.Show("Exist Director");
        }
        private void FrmModifyDirectorInMovie_Load(object sender, EventArgs e)
        {
            LoadDirector();
        }
        private void btnDeleteDirector_Click(object sender, EventArgs e)
        {
            int directorID = Convert.ToInt32(lbxDirectorMovie.SelectedValue);
            DeleteDirector(directorID);
            RemoveDirector(directorID);
        }
    }
}
