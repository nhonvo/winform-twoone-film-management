namespace MovieWinform.GUI.Forms
{
    partial class FrmModifyHashTagInMovie
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
            this.lbxExistHashTag = new System.Windows.Forms.ListBox();
            this.hashTagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phimHashTagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeleteHashTag = new System.Windows.Forms.Button();
            this.btnAddHashTag = new System.Windows.Forms.Button();
            this.lbxHashTagMovie = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.hashTagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phimHashTagBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxExistHashTag
            // 
            this.lbxExistHashTag.DataSource = this.hashTagBindingSource;
            this.lbxExistHashTag.DisplayMember = "TenTag";
            this.lbxExistHashTag.FormattingEnabled = true;
            this.lbxExistHashTag.ItemHeight = 16;
            this.lbxExistHashTag.Location = new System.Drawing.Point(103, 166);
            this.lbxExistHashTag.Name = "lbxExistHashTag";
            this.lbxExistHashTag.Size = new System.Drawing.Size(356, 388);
            this.lbxExistHashTag.TabIndex = 15;
            this.lbxExistHashTag.ValueMember = "MaHashTag";
            // 
            // btnDeleteHashTag
            // 
            this.btnDeleteHashTag.Location = new System.Drawing.Point(583, 346);
            this.btnDeleteHashTag.Name = "btnDeleteHashTag";
            this.btnDeleteHashTag.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteHashTag.TabIndex = 18;
            this.btnDeleteHashTag.Text = "Delete";
            this.btnDeleteHashTag.UseVisualStyleBackColor = true;
            this.btnDeleteHashTag.Click += new System.EventHandler(this.btnDeleteHashTag_Click);
            // 
            // btnAddHashTag
            // 
            this.btnAddHashTag.Location = new System.Drawing.Point(583, 300);
            this.btnAddHashTag.Name = "btnAddHashTag";
            this.btnAddHashTag.Size = new System.Drawing.Size(75, 23);
            this.btnAddHashTag.TabIndex = 17;
            this.btnAddHashTag.Text = "Add";
            this.btnAddHashTag.UseVisualStyleBackColor = true;
            this.btnAddHashTag.Click += new System.EventHandler(this.btnAddHashTag_Click);
            // 
            // lbxHashTagMovie
            // 
            this.lbxHashTagMovie.DataSource = this.phimHashTagBindingSource;
            this.lbxHashTagMovie.DisplayMember = "TenTag";
            this.lbxHashTagMovie.FormattingEnabled = true;
            this.lbxHashTagMovie.ItemHeight = 16;
            this.lbxHashTagMovie.Location = new System.Drawing.Point(843, 166);
            this.lbxHashTagMovie.Name = "lbxHashTagMovie";
            this.lbxHashTagMovie.Size = new System.Drawing.Size(356, 388);
            this.lbxHashTagMovie.TabIndex = 16;
            this.lbxHashTagMovie.ValueMember = "MaHashTag";
            // 
            // FrmModifyHashTagInMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 720);
            this.Controls.Add(this.lbxExistHashTag);
            this.Controls.Add(this.btnDeleteHashTag);
            this.Controls.Add(this.btnAddHashTag);
            this.Controls.Add(this.lbxHashTagMovie);
            this.Name = "FrmModifyHashTagInMovie";
            this.Text = "FrmModifyHashTagInMovie";
            this.Load += new System.EventHandler(this.FrmModifyHashTagInMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hashTagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phimHashTagBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxExistHashTag;
        private System.Windows.Forms.BindingSource hashTagBindingSource;
        private System.Windows.Forms.BindingSource phimHashTagBindingSource;
        private System.Windows.Forms.Button btnDeleteHashTag;
        private System.Windows.Forms.Button btnAddHashTag;
        private System.Windows.Forms.ListBox lbxHashTagMovie;
    }
}