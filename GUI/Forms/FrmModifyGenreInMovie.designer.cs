namespace MovieWinform.GUI.Forms
{
    partial class FrmModifyGenreInMovie
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
            this.lbxExistGenre = new System.Windows.Forms.ListBox();
            this.theLoaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phimTheLoaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteGenre = new System.Windows.Forms.Button();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.lbxGenreMovie = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phimTheLoaiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxExistGenre
            // 
            this.lbxExistGenre.DataSource = this.theLoaiBindingSource;
            this.lbxExistGenre.DisplayMember = "TenTheLoai";
            this.lbxExistGenre.FormattingEnabled = true;
            this.lbxExistGenre.ItemHeight = 16;
            this.lbxExistGenre.Location = new System.Drawing.Point(110, 175);
            this.lbxExistGenre.Name = "lbxExistGenre";
            this.lbxExistGenre.Size = new System.Drawing.Size(356, 388);
            this.lbxExistGenre.TabIndex = 11;
            this.lbxExistGenre.ValueMember = "MaTheLoai";
            // 
            // btnDeleteGenre
            // 
            this.btnDeleteGenre.Location = new System.Drawing.Point(590, 355);
            this.btnDeleteGenre.Name = "btnDeleteGenre";
            this.btnDeleteGenre.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteGenre.TabIndex = 14;
            this.btnDeleteGenre.Text = "Delete";
            this.btnDeleteGenre.UseVisualStyleBackColor = true;
            this.btnDeleteGenre.Click += new System.EventHandler(this.btnDeleteGenre_Click);
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.Location = new System.Drawing.Point(590, 309);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(75, 23);
            this.btnAddGenre.TabIndex = 13;
            this.btnAddGenre.Text = "Add";
            this.btnAddGenre.UseVisualStyleBackColor = true;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // lbxGenreMovie
            // 
            this.lbxGenreMovie.DataSource = this.phimTheLoaiBindingSource;
            this.lbxGenreMovie.DisplayMember = "TenTheLoai";
            this.lbxGenreMovie.FormattingEnabled = true;
            this.lbxGenreMovie.ItemHeight = 16;
            this.lbxGenreMovie.Location = new System.Drawing.Point(850, 175);
            this.lbxGenreMovie.Name = "lbxGenreMovie";
            this.lbxGenreMovie.Size = new System.Drawing.Size(356, 388);
            this.lbxGenreMovie.TabIndex = 12;
            this.lbxGenreMovie.ValueMember = "MaTheLoai";
            // 
            // FrmModifyGenreInMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 739);
            this.Controls.Add(this.lbxExistGenre);
            this.Controls.Add(this.btnDeleteGenre);
            this.Controls.Add(this.btnAddGenre);
            this.Controls.Add(this.lbxGenreMovie);
            this.Name = "FrmModifyGenreInMovie";
            this.Text = "FrmModifyGenreInMovie";
            this.Load += new System.EventHandler(this.FrmModifyGenreInMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phimTheLoaiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxExistGenre;
        private System.Windows.Forms.BindingSource theLoaiBindingSource;
        private System.Windows.Forms.BindingSource phimTheLoaiBindingSource;
        private System.Windows.Forms.Button btnDeleteGenre;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.ListBox lbxGenreMovie;
    }
}