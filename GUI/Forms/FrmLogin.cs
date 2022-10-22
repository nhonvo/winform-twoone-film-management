using Emgu.CV.Face;
using Emgu.CV.Structure;
using Emgu.CV;
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
using Emgu.CV.CvEnum;
using System.Diagnostics;
using System.IO;
using System.Threading;
using MovieWinform.GUI.Forms;

namespace MovieWinform
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();
        }
        public void Close1()
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        public bool CheckLogin(string userName, string passWord)
        {
            try
            {
                using (var db = new MovieWinformDBcontext())
                {
                    return db.Admins.Any(tk => tk.TaiKhoanAdmin == userName && tk.MatKhauAdmin == passWord);
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public string USER_NAME = "";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MovieWinformDBcontext db = new MovieWinformDBcontext();
            string userName = txtUserName.Text;
            string passWord = txtPassword.Text;
            USER_NAME = userName;
            if(string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(passWord))
            {
                lblNotification.Text = "Please fill all fields!!";
                return;
            }
            if (CheckLogin(userName, passWord))
            {
                // Close login form after open home form
                this.Hide();
                FrmHome home = new FrmHome();
                home.Closed += (s, args) => this.Close();
                home.Show();
            }
            else
            {
                lblNotification.Text = "Fail to login. Please try again!";
            }
        }

        private void checkBoxShow_Hide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow_Hide.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
        // Make the login form can move without border window
        bool drag = false;
        Point start_point = new Point(0, 0);
        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point point = PointToScreen(e.Location);
                this.Location = new Point(point.X - start_point.X, point.Y - start_point.Y);

            }
        }
        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;

        }
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmFaceID f = new FrmFaceID();
            f.Closed +=(s,args) =>this.Close();
            f.Show();
        }
    }
}
