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
    public partial class UCProfile : UserControl
    {
        Admin admin;
        MovieWinformDBcontext db = new MovieWinformDBcontext();
        public UCProfile()
        {
            InitializeComponent();
            FrmLogin login = new FrmLogin();
            
            //Get Admin's data
            admin = db.Admins.FirstOrDefault(x=> x.TaiKhoanAdmin.Contains(login.USER_NAME));
            lblUserName.Text = admin.TaiKhoanAdmin;
            lblPassword.Text = admin.MatKhauAdmin;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string password = txtNewPassword.Text;
            string paswordAgain = txtPasswordAgain.Text;

            bool isConfirmed = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
            if (isConfirmed)
            {
                if(password == paswordAgain)
                {
                    admin.MatKhauAdmin = password;
                }
                db.Entry(admin).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        String imageUpload;
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pbAvatar.Image = new Bitmap(opnfd.FileName);
            }
            imageUpload = opnfd.SafeFileName;
        }

        private void txtNewPassword_MouseEnter(object sender, EventArgs e)
        {
            txtNewPassword.Text = "";
            txtPasswordAgain.Text = "";
        }

        private void UCProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
