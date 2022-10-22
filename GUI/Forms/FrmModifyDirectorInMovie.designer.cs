namespace MovieWinform.GUI.Forms
{
    partial class FrmModifyDirectorInMovie
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
            this.lbxExistDirector = new System.Windows.Forms.ListBox();
            this.daoDienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phimDaoDienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteDirector = new System.Windows.Forms.Button();
            this.btnAddDirector = new System.Windows.Forms.Button();
            this.lbxDirectorMovie = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.daoDienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phimDaoDienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxExistDirector
            // 
            this.lbxExistDirector.DataSource = this.daoDienBindingSource;
            this.lbxExistDirector.DisplayMember = "TenDaoDien";
            this.lbxExistDirector.FormattingEnabled = true;
            this.lbxExistDirector.ItemHeight = 16;
            this.lbxExistDirector.Location = new System.Drawing.Point(65, 148);
            this.lbxExistDirector.Name = "lbxExistDirector";
            this.lbxExistDirector.Size = new System.Drawing.Size(356, 388);
            this.lbxExistDirector.TabIndex = 6;
            this.lbxExistDirector.ValueMember = "MaDaoDien";
            // 
            // btnDeleteDirector
            // 
            this.btnDeleteDirector.Location = new System.Drawing.Point(545, 328);
            this.btnDeleteDirector.Name = "btnDeleteDirector";
            this.btnDeleteDirector.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteDirector.TabIndex = 10;
            this.btnDeleteDirector.Text = "Delete";
            this.btnDeleteDirector.UseVisualStyleBackColor = true;
            this.btnDeleteDirector.Click += new System.EventHandler(this.btnDeleteDirector_Click);
            // 
            // btnAddDirector
            // 
            this.btnAddDirector.Location = new System.Drawing.Point(545, 282);
            this.btnAddDirector.Name = "btnAddDirector";
            this.btnAddDirector.Size = new System.Drawing.Size(75, 23);
            this.btnAddDirector.TabIndex = 9;
            this.btnAddDirector.Text = "Add";
            this.btnAddDirector.UseVisualStyleBackColor = true;
            this.btnAddDirector.Click += new System.EventHandler(this.btnAddDirector_Click);
            // 
            // lbxDirectorMovie
            // 
            this.lbxDirectorMovie.DataSource = this.phimDaoDienBindingSource;
            this.lbxDirectorMovie.DisplayMember = "TenDaoDien";
            this.lbxDirectorMovie.FormattingEnabled = true;
            this.lbxDirectorMovie.ItemHeight = 16;
            this.lbxDirectorMovie.Location = new System.Drawing.Point(805, 148);
            this.lbxDirectorMovie.Name = "lbxDirectorMovie";
            this.lbxDirectorMovie.Size = new System.Drawing.Size(356, 388);
            this.lbxDirectorMovie.TabIndex = 7;
            this.lbxDirectorMovie.ValueMember = "MaDaoDien";
            // 
            // FrmModifyDirectorInMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 684);
            this.Controls.Add(this.lbxExistDirector);
            this.Controls.Add(this.btnDeleteDirector);
            this.Controls.Add(this.btnAddDirector);
            this.Controls.Add(this.lbxDirectorMovie);
            this.Name = "FrmModifyDirectorInMovie";
            this.Text = "FrmModifyDirectorInMovie";
            this.Load += new System.EventHandler(this.FrmModifyDirectorInMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.daoDienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phimDaoDienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxExistDirector;
        private System.Windows.Forms.BindingSource daoDienBindingSource;
        private System.Windows.Forms.BindingSource phimDaoDienBindingSource;
        private System.Windows.Forms.Button btnDeleteDirector;
        private System.Windows.Forms.Button btnAddDirector;
        private System.Windows.Forms.ListBox lbxDirectorMovie;
    }
}