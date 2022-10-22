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

namespace MovieWinform
{
    public partial class FrmModifyActorInMovie : Form
    {
        public int filmID = 8;
        FilmBUS filmBUS = new FilmBUS();
        ActorBUS actorBUS = new ActorBUS();
        public FrmModifyActorInMovie()
        {
            InitializeComponent();
        }
        
        private void AddRole(int actorID)
        {
            
            string role = txtRole.Text;

            filmBUS.AddRole(filmID, actorID, role);
            filmBUS.Save();
        }
        private void LoadActor()
        {
            dienVienBindingSource.Clear();
            dienVienBindingSource.DataSource = actorBUS.Actors;
            phimDienVienBindingSource.DataSource = filmBUS.GetActorsById(filmID);
        }
        private void AddActor_Load(object sender, EventArgs e)
        {
            LoadActor();
        }
        private void AddNewActor(int actorID)
        {
            
            DienVien dienVien = actorBUS.Find(actorID);
            phimDienVienBindingSource.Add(dienVien);
        }
        private void btnAddActor_Click(object sender, EventArgs e)
        {
            int actorID = Convert.ToInt32(lbxExistActor.SelectedValue);
            if (filmBUS.FindActor(filmID, actorID) ==null)
            {
                AddRole(actorID);
                AddNewActor(actorID);
            }
            else MessageBox.Show("Exist Actor");
        }
        
        private void lbxExistActor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRole.Clear();
            txtRole.Focus();
        }
        private void lbxAddActor_MouseClick(object sender, MouseEventArgs e)
        {
            int actorID = Convert.ToInt32(lbxAddActor.SelectedValue);
            DienVienDongPhim actor = filmBUS.FindActor(filmID, actorID);
            txtRole.Text = actor.TenVaiDien;
            txtRole.Focus();
        }
        private void RemoveActor(int actorID)
        {
            DienVien dienVien = actorBUS.Find(actorID);
            phimDienVienBindingSource.Remove(dienVien);
            phimDienVienBindingSource.DataSource = filmBUS.GetActorsById(filmID);
        }
        private void DeleteActor(int actorID)
        {
            filmBUS.DeleteRole(filmID, actorID);
            filmBUS.Save();
        }
        private void btnDeleteActor_Click(object sender, EventArgs e)
        {
            int actorID = Convert.ToInt32(lbxAddActor.SelectedValue);
            DeleteActor(actorID);
            RemoveActor(actorID);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int actorID = Convert.ToInt32(lbxAddActor.SelectedValue);
            DienVienDongPhim dienVien = filmBUS.FindActor(filmID, actorID);
            dienVien.TenVaiDien = txtRole.Text;
            filmBUS.Save();
        }
    }
}
