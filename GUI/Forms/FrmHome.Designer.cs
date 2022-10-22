using System.Drawing;

namespace MovieWinform
{
    partial class FrmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelDropDown = new System.Windows.Forms.Panel();
            this.btnPlan = new System.Windows.Forms.Button();
            this.btnSubscription = new System.Windows.Forms.Button();
            this.btnHashTag = new System.Windows.Forms.Button();
            this.btnGerne = new System.Windows.Forms.Button();
            this.btnNation = new System.Windows.Forms.Button();
            this.btnLanguage = new System.Windows.Forms.Button();
            this.btnDiretor = new System.Windows.Forms.Button();
            this.btnActor = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnFilm = new System.Windows.Forms.Button();
            this.btnManagement = new System.Windows.Forms.Button();
            this.btnStatical = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panelDragBar = new System.Windows.Forms.Panel();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAboutUs_1 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblHeaderName = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelDropDown.SuspendLayout();
            this.panelTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.White;
            this.lblAdmin.Location = new System.Drawing.Point(18, 133);
            this.lblAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(57, 20);
            this.lblAdmin.TabIndex = 3;
            this.lblAdmin.Text = "Movie";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(12, 107);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 23);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Twoone";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.lblAdmin);
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(79, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(148, 176);
            this.panel3.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 782);
            this.panel1.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnHome);
            this.flowLayoutPanel1.Controls.Add(this.panelDropDown);
            this.flowLayoutPanel1.Controls.Add(this.btnStatical);
            this.flowLayoutPanel1.Controls.Add(this.btnSetting);
            this.flowLayoutPanel1.Controls.Add(this.btnAboutUs);
            this.flowLayoutPanel1.Controls.Add(this.btnLogOut);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(42, 160);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(217, 783);
            this.flowLayoutPanel1.TabIndex = 30;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(4, 4);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(190, 66);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "       Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.Enter += new System.EventHandler(this.btnHome_Enter);
            this.btnHome.Leave += new System.EventHandler(this.btnHome_Leave);
            // 
            // panelDropDown
            // 
            this.panelDropDown.Controls.Add(this.btnPlan);
            this.panelDropDown.Controls.Add(this.btnSubscription);
            this.panelDropDown.Controls.Add(this.btnHashTag);
            this.panelDropDown.Controls.Add(this.btnGerne);
            this.panelDropDown.Controls.Add(this.btnNation);
            this.panelDropDown.Controls.Add(this.btnLanguage);
            this.panelDropDown.Controls.Add(this.btnDiretor);
            this.panelDropDown.Controls.Add(this.btnActor);
            this.panelDropDown.Controls.Add(this.btnUser);
            this.panelDropDown.Controls.Add(this.btnFilm);
            this.panelDropDown.Controls.Add(this.btnManagement);
            this.panelDropDown.Location = new System.Drawing.Point(3, 76);
            this.panelDropDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDropDown.MaximumSize = new System.Drawing.Size(190, 424);
            this.panelDropDown.MinimumSize = new System.Drawing.Size(190, 46);
            this.panelDropDown.Name = "panelDropDown";
            this.panelDropDown.Size = new System.Drawing.Size(190, 46);
            this.panelDropDown.TabIndex = 1;
            // 
            // btnPlan
            // 
            this.btnPlan.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnPlan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlan.FlatAppearance.BorderSize = 0;
            this.btnPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlan.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlan.ForeColor = System.Drawing.Color.White;
            this.btnPlan.Location = new System.Drawing.Point(0, 355);
            this.btnPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlan.Name = "btnPlan";
            this.btnPlan.Size = new System.Drawing.Size(190, 37);
            this.btnPlan.TabIndex = 14;
            this.btnPlan.Text = "Plan";
            this.btnPlan.UseVisualStyleBackColor = false;
            this.btnPlan.Click += new System.EventHandler(this.btnPlan_Click);
            // 
            // btnSubscription
            // 
            this.btnSubscription.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnSubscription.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubscription.FlatAppearance.BorderSize = 0;
            this.btnSubscription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubscription.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubscription.ForeColor = System.Drawing.Color.White;
            this.btnSubscription.Location = new System.Drawing.Point(0, 318);
            this.btnSubscription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubscription.Name = "btnSubscription";
            this.btnSubscription.Size = new System.Drawing.Size(190, 37);
            this.btnSubscription.TabIndex = 13;
            this.btnSubscription.Text = "Subscription";
            this.btnSubscription.UseVisualStyleBackColor = false;
            this.btnSubscription.Click += new System.EventHandler(this.btnSubscription_Click);
            // 
            // btnHashTag
            // 
            this.btnHashTag.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnHashTag.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHashTag.FlatAppearance.BorderSize = 0;
            this.btnHashTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHashTag.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHashTag.ForeColor = System.Drawing.Color.White;
            this.btnHashTag.Location = new System.Drawing.Point(0, 281);
            this.btnHashTag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHashTag.Name = "btnHashTag";
            this.btnHashTag.Size = new System.Drawing.Size(190, 37);
            this.btnHashTag.TabIndex = 12;
            this.btnHashTag.Text = "HashTag";
            this.btnHashTag.UseVisualStyleBackColor = false;
            this.btnHashTag.Click += new System.EventHandler(this.btnHashTag_Click);
            // 
            // btnGerne
            // 
            this.btnGerne.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnGerne.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGerne.FlatAppearance.BorderSize = 0;
            this.btnGerne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerne.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerne.ForeColor = System.Drawing.Color.White;
            this.btnGerne.Location = new System.Drawing.Point(0, 244);
            this.btnGerne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGerne.Name = "btnGerne";
            this.btnGerne.Size = new System.Drawing.Size(190, 37);
            this.btnGerne.TabIndex = 11;
            this.btnGerne.Text = "Gerne";
            this.btnGerne.UseVisualStyleBackColor = false;
            this.btnGerne.Click += new System.EventHandler(this.btnGerne_Click);
            // 
            // btnNation
            // 
            this.btnNation.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnNation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNation.FlatAppearance.BorderSize = 0;
            this.btnNation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNation.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNation.ForeColor = System.Drawing.Color.White;
            this.btnNation.Location = new System.Drawing.Point(0, 211);
            this.btnNation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNation.Name = "btnNation";
            this.btnNation.Size = new System.Drawing.Size(190, 33);
            this.btnNation.TabIndex = 10;
            this.btnNation.Text = "Nation";
            this.btnNation.UseVisualStyleBackColor = false;
            this.btnNation.Click += new System.EventHandler(this.btnNation_Click);
            // 
            // btnLanguage
            // 
            this.btnLanguage.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnLanguage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLanguage.FlatAppearance.BorderSize = 0;
            this.btnLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLanguage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLanguage.ForeColor = System.Drawing.Color.White;
            this.btnLanguage.Location = new System.Drawing.Point(0, 178);
            this.btnLanguage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.Size = new System.Drawing.Size(190, 33);
            this.btnLanguage.TabIndex = 9;
            this.btnLanguage.Text = "Language";
            this.btnLanguage.UseVisualStyleBackColor = false;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // btnDiretor
            // 
            this.btnDiretor.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnDiretor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiretor.FlatAppearance.BorderSize = 0;
            this.btnDiretor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiretor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiretor.ForeColor = System.Drawing.Color.White;
            this.btnDiretor.Location = new System.Drawing.Point(0, 145);
            this.btnDiretor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDiretor.Name = "btnDiretor";
            this.btnDiretor.Size = new System.Drawing.Size(190, 33);
            this.btnDiretor.TabIndex = 6;
            this.btnDiretor.Text = "Director";
            this.btnDiretor.UseVisualStyleBackColor = false;
            this.btnDiretor.Click += new System.EventHandler(this.btnDiretor_Click);
            // 
            // btnActor
            // 
            this.btnActor.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnActor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActor.FlatAppearance.BorderSize = 0;
            this.btnActor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActor.ForeColor = System.Drawing.Color.White;
            this.btnActor.Location = new System.Drawing.Point(0, 112);
            this.btnActor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActor.Name = "btnActor";
            this.btnActor.Size = new System.Drawing.Size(190, 33);
            this.btnActor.TabIndex = 5;
            this.btnActor.Text = "Actor";
            this.btnActor.UseVisualStyleBackColor = false;
            this.btnActor.Click += new System.EventHandler(this.btnActor_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Location = new System.Drawing.Point(0, 79);
            this.btnUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(190, 33);
            this.btnUser.TabIndex = 4;
            this.btnUser.Text = "User";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnFilm
            // 
            this.btnFilm.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnFilm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilm.FlatAppearance.BorderSize = 0;
            this.btnFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilm.ForeColor = System.Drawing.Color.White;
            this.btnFilm.Location = new System.Drawing.Point(0, 46);
            this.btnFilm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.Size = new System.Drawing.Size(190, 33);
            this.btnFilm.TabIndex = 3;
            this.btnFilm.Text = "Film";
            this.btnFilm.UseVisualStyleBackColor = false;
            this.btnFilm.Click += new System.EventHandler(this.btnFilm_Click);
            // 
            // btnManagement
            // 
            this.btnManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManagement.FlatAppearance.BorderSize = 0;
            this.btnManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagement.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagement.ForeColor = System.Drawing.Color.White;
            this.btnManagement.Image = global::MovieWinform.Properties.Resources.Expand_Arrow_20px;
            this.btnManagement.Location = new System.Drawing.Point(0, 0);
            this.btnManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Size = new System.Drawing.Size(190, 46);
            this.btnManagement.TabIndex = 2;
            this.btnManagement.Text = "Management";
            this.btnManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManagement.UseVisualStyleBackColor = false;
            this.btnManagement.Click += new System.EventHandler(this.btnManagement_Click);
            this.btnManagement.Enter += new System.EventHandler(this.btnManagement_Enter);
            this.btnManagement.Leave += new System.EventHandler(this.btnManagement_Leave);
            // 
            // btnStatical
            // 
            this.btnStatical.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatical.FlatAppearance.BorderSize = 0;
            this.btnStatical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatical.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatical.ForeColor = System.Drawing.Color.White;
            this.btnStatical.Image = ((System.Drawing.Image)(resources.GetObject("btnStatical.Image")));
            this.btnStatical.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatical.Location = new System.Drawing.Point(4, 128);
            this.btnStatical.Margin = new System.Windows.Forms.Padding(4);
            this.btnStatical.Name = "btnStatical";
            this.btnStatical.Size = new System.Drawing.Size(190, 66);
            this.btnStatical.TabIndex = 7;
            this.btnStatical.Text = "       Statical";
            this.btnStatical.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatical.UseVisualStyleBackColor = true;
            this.btnStatical.Click += new System.EventHandler(this.btnStatical_Click);
            this.btnStatical.Enter += new System.EventHandler(this.btnStatical_Enter);
            this.btnStatical.Leave += new System.EventHandler(this.btnStatical_Leave);
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(4, 202);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(190, 66);
            this.btnSetting.TabIndex = 8;
            this.btnSetting.Text = "       Setting";
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            this.btnSetting.MouseEnter += new System.EventHandler(this.btnSetting_MouseEnter);
            this.btnSetting.MouseLeave += new System.EventHandler(this.btnSetting_MouseLeave);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAboutUs.FlatAppearance.BorderSize = 0;
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs.ForeColor = System.Drawing.Color.White;
            this.btnAboutUs.Image = ((System.Drawing.Image)(resources.GetObject("btnAboutUs.Image")));
            this.btnAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUs.Location = new System.Drawing.Point(4, 276);
            this.btnAboutUs.Margin = new System.Windows.Forms.Padding(4);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(160, 66);
            this.btnAboutUs.TabIndex = 21;
            this.btnAboutUs.Text = "       About us";
            this.btnAboutUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAboutUs.UseVisualStyleBackColor = true;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            this.btnAboutUs.MouseEnter += new System.EventHandler(this.btnAboutUs_MouseEnter);
            this.btnAboutUs.MouseLeave += new System.EventHandler(this.btnAboutUs_MouseLeave);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(4, 350);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(172, 66);
            this.btnLogOut.TabIndex = 22;
            this.btnLogOut.Text = "       Log out";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            this.btnLogOut.Enter += new System.EventHandler(this.btnLogOut_Enter);
            this.btnLogOut.Leave += new System.EventHandler(this.btnLogOut_Leave);
            // 
            // panelDragBar
            // 
            this.panelDragBar.AllowDrop = true;
            this.panelDragBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panelDragBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDragBar.Location = new System.Drawing.Point(0, 0);
            this.panelDragBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelDragBar.Name = "panelDragBar";
            this.panelDragBar.Size = new System.Drawing.Size(1348, 18);
            this.panelDragBar.TabIndex = 6;
            // 
            // pnlHome
            // 
            this.pnlHome.AutoScroll = true;
            this.pnlHome.Location = new System.Drawing.Point(265, 88);
            this.pnlHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(1081, 873);
            this.pnlHome.TabIndex = 19;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(1020, 7);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(43, 43);
            this.btnExit.TabIndex = 9;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAboutUs_1
            // 
            this.btnAboutUs_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAboutUs_1.FlatAppearance.BorderSize = 0;
            this.btnAboutUs_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs_1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs_1.ForeColor = System.Drawing.Color.White;
            this.btnAboutUs_1.Image = ((System.Drawing.Image)(resources.GetObject("btnAboutUs_1.Image")));
            this.btnAboutUs_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUs_1.Location = new System.Drawing.Point(1132, 8);
            this.btnAboutUs_1.Margin = new System.Windows.Forms.Padding(4);
            this.btnAboutUs_1.Name = "btnAboutUs_1";
            this.btnAboutUs_1.Size = new System.Drawing.Size(43, 43);
            this.btnAboutUs_1.TabIndex = 10;
            this.btnAboutUs_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAboutUs_1.UseVisualStyleBackColor = true;
            this.btnAboutUs_1.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(969, 7);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(43, 43);
            this.button11.TabIndex = 11;
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelTopBar.Controls.Add(this.txtSearch);
            this.panelTopBar.Controls.Add(this.lblHeaderName);
            this.panelTopBar.Controls.Add(this.btnExit);
            this.panelTopBar.Controls.Add(this.btnAboutUs_1);
            this.panelTopBar.Controls.Add(this.button11);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(262, 18);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(1086, 65);
            this.panelTopBar.TabIndex = 20;
            this.panelTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseDown);
            this.panelTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseMove);
            this.panelTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseUp);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSearch.Location = new System.Drawing.Point(307, 19);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(482, 32);
            this.txtSearch.TabIndex = 66;
            this.txtSearch.Text = "...Search for something";
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // lblHeaderName
            // 
            this.lblHeaderName.AutoSize = true;
            this.lblHeaderName.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderName.Location = new System.Drawing.Point(38, 11);
            this.lblHeaderName.Name = "lblHeaderName";
            this.lblHeaderName.Size = new System.Drawing.Size(195, 39);
            this.lblHeaderName.TabIndex = 12;
            this.lblHeaderName.Text = "Dashboard";
            // 
            // FrmHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1348, 800);
            this.Controls.Add(this.panelTopBar);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDragBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelDropDown.ResumeLayout(false);
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAboutUs_1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDragBar;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelDropDown;
        private System.Windows.Forms.Button btnNation;
        private System.Windows.Forms.Button btnLanguage;
        private System.Windows.Forms.Button btnDiretor;
        private System.Windows.Forms.Button btnActor;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnFilm;
        private System.Windows.Forms.Button btnManagement;
        private System.Windows.Forms.Button btnStatical;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnHashTag;
        private System.Windows.Forms.Button btnGerne;
        private System.Windows.Forms.Button btnSubscription;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Button btnPlan;
        private System.Windows.Forms.Label lblHeaderName;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

