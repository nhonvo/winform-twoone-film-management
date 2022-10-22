using MovieWinform.Forms;
using MovieWinform.Model;
using MovieWinform.Properties;
using MovieWinform.UserControls;
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
    public partial class FrmHome : Form
    {

        public FrmHome()
        {
            InitializeComponent();
            UCDashBoard dashboard = new UCDashBoard();
            ChangeView(dashboard);
        }
        #region
        private void ChangeView(ContainerControl view)
        {
            if (pnlHome.Controls.Count > 0)
            {
                pnlHome.Controls.RemoveAt(pnlHome.Controls.Count - 1);
            }
            view.BringToFront();
            view.Dock = DockStyle.Fill;
            pnlHome.Controls.Add(view);
            lblHeaderName.Text = view.Name;
        }
        #endregion
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close home form after open login form
            this.Hide();
            FrmLogin login = new FrmLogin();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UCDashBoard dashboard = new UCDashBoard();
            ChangeView(dashboard);
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            UCFilm film = new UCFilm();
            ChangeView(film);
        }

        private void btnDiretor_Click(object sender, EventArgs e)
        {
            UCDirector director = new UCDirector();
            ChangeView(director);

        }

        private void btnActor_Click(object sender, EventArgs e)
        {
            UCActor actor = new UCActor();
            ChangeView(actor);

        }

        private void btnLanguage_Click(object sender, EventArgs e)
        {
            UCLanguage language = new UCLanguage();
            ChangeView(language);
        }

        private void btnNation_Click(object sender, EventArgs e)
        {
            UCNation nation = new UCNation();
            ChangeView(nation);
        }
        private void btnGerne_Click(object sender, EventArgs e)
        {
            UCGenre genre = new UCGenre();
            ChangeView(genre);
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            UCPlan plan = new UCPlan();
            ChangeView(plan);
        }
        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            UCAboutUs about = new UCAboutUs();
            ChangeView(about);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            UCProfile profile = new UCProfile();
            ChangeView(profile);
        }

        private void btnHashTag_Click(object sender, EventArgs e)
        {
            UCHashTag hashTag = new UCHashTag();
            ChangeView(hashTag);
        }

        private void btnSubscription_Click(object sender, EventArgs e)
        {
            UCSubscription subscription = new UCSubscription();
            ChangeView(subscription);
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            UCUser user = new UCUser();
            ChangeView(user);
        }
        private void btnStatical_Click(object sender, EventArgs e)
        {
            UCStatical statical = new UCStatical();
            ChangeView(statical);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin login = new FrmLogin();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }
        private bool isCollapsed;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                //button5.Image = Resources.Collapse_Arrow_20px;
                panelDropDown.Height += 100;
                if (panelDropDown.Size == panelDropDown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                //button5.Image = Resources.Expand_Arrow_20px;
                panelDropDown.Height -= 100;
                if (panelDropDown.Size == panelDropDown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }
        bool drag = false;
        Point start_point = new Point(0, 0);
        private void panelTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point point = PointToScreen(e.Location);
                this.Location = new Point(point.X - start_point.X, point.Y - start_point.Y);
            }
        }

        private void panelTopBar_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void panelTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

     

        private void btnHome_Enter(object sender, EventArgs e)
        {
            btnHome.ForeColor = Color.Red;

        }

        private void btnHome_Leave(object sender, EventArgs e)
        {
            btnHome.ForeColor = Color.White;

        }

        private void btnManagement_Enter(object sender, EventArgs e)
        {
            btnManagement.ForeColor = Color.Red;

        }

        private void btnManagement_Leave(object sender, EventArgs e)
        {
            btnManagement.ForeColor = Color.White;

        }

        private void btnStatical_Enter(object sender, EventArgs e)
        {
            btnStatical.ForeColor = Color.Red;

        }

        private void btnStatical_Leave(object sender, EventArgs e)
        {
            btnStatical.ForeColor = Color.White;

        }

        private void btnSetting_MouseEnter(object sender, EventArgs e)
        {
            btnSetting.ForeColor = Color.Red;

        }

        private void btnSetting_MouseLeave(object sender, EventArgs e)
        {
            btnSetting.ForeColor = Color.White;

        }

        private void btnAboutUs_MouseEnter(object sender, EventArgs e)
        {
            btnAboutUs.ForeColor = Color.Red;

        }

        private void btnAboutUs_MouseLeave(object sender, EventArgs e)
        {
            btnAboutUs.ForeColor = Color.White;

        }

        private void btnLogOut_Enter(object sender, EventArgs e)
        {
            btnLogOut.ForeColor = Color.Red;

        }

        private void btnLogOut_Leave(object sender, EventArgs e)
        {
            btnLogOut.ForeColor = Color.White;

        }
    }
}
