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
    public partial class FrmLoading : Form
    {
        public FrmLoading()
        {
            InitializeComponent();
        }
        bool drag = false;
        Point start_point = new Point(0, 0);
        private void FrmLoading_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void FrmLoading_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void FrmLoading_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point point = PointToScreen(e.Location);
                this.Location = new Point(point.X - start_point.X, point.Y - start_point.Y);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(1);
            for(int i = 0; i < progressBar1.Value; i++)
            {
                lblNumber.Text = i.ToString();
            }

            if(progressBar1.Value == 101)
            {
                timer1.Enabled = false;
                this.Hide();
                FrmLogin login = new FrmLogin();
                login.Closed += (s, args) => this.Close();
                login.Show();
            }
        }
    }
}
