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
    public partial class FrmModifyHashTagInMovie : Form
    {
        public int filmID = 8;
        FilmBUS filmBUS = new FilmBUS();
        HashTagBUS hashTagBUS = new HashTagBUS();
        public FrmModifyHashTagInMovie()
        {
            InitializeComponent();
        }
        private void AddHashTag(int hashTagID)
        {
            filmBUS.AddHashTag(filmID, hashTagID);
            filmBUS.Save();
        }
        private void AddNewHashTag(int hashTagID)
        {
            HashTag hashTag = hashTagBUS.Find(hashTagID);
            phimHashTagBindingSource.Add(hashTag);
        }
        private void LoadHashTag()
        {
            hashTagBindingSource.Clear();
            hashTagBindingSource.DataSource = hashTagBUS.HashTagList;
            phimHashTagBindingSource.DataSource = filmBUS.GetHashTagById(filmID);
        }
        private void RemoveHashTag(int hashTagID)
        {
            HashTag hashTag = hashTagBUS.Find(hashTagID);
            phimHashTagBindingSource.Remove(hashTag);
            phimHashTagBindingSource.DataSource = filmBUS.GetHashTagById(filmID);
        }
        private void DeleteHashTag(int hashTagID)
        {
            filmBUS.DeleteHashTag(filmID, hashTagID);
            filmBUS.Save();
        }

        private void btnAddHashTag_Click(object sender, EventArgs e)
        {
            int hashTagID = Convert.ToInt32(lbxExistHashTag.SelectedValue);
            if (!filmBUS.ExistHashTag(filmID, hashTagID))
            {
                AddHashTag(hashTagID);
                AddNewHashTag(hashTagID);
            }
            else MessageBox.Show("Exist HashTag");
        }
        private void FrmModifyHashTagInMovie_Load(object sender, EventArgs e)
        {
            LoadHashTag();
        }
        private void btnDeleteHashTag_Click(object sender, EventArgs e)
        {
            int hashTagID = Convert.ToInt32(lbxHashTagMovie.SelectedValue);
            DeleteHashTag(hashTagID);
            RemoveHashTag(hashTagID);
        }
    }
}
