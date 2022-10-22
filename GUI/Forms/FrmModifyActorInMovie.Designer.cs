namespace MovieWinform
{
    partial class FrmModifyActorInMovie
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
            this.lbxExistActor = new System.Windows.Forms.ListBox();
            this.dienVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phimDienVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbxAddActor = new System.Windows.Forms.ListBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.btnAddActor = new System.Windows.Forms.Button();
            this.btnDeleteActor = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dienVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phimDienVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxExistActor
            // 
            this.lbxExistActor.DataSource = this.dienVienBindingSource;
            this.lbxExistActor.DisplayMember = "TenDienVien";
            this.lbxExistActor.FormattingEnabled = true;
            this.lbxExistActor.ItemHeight = 16;
            this.lbxExistActor.Location = new System.Drawing.Point(12, 55);
            this.lbxExistActor.Name = "lbxExistActor";
            this.lbxExistActor.Size = new System.Drawing.Size(356, 388);
            this.lbxExistActor.TabIndex = 0;
            this.lbxExistActor.ValueMember = "MaDienVien";
            this.lbxExistActor.SelectedIndexChanged += new System.EventHandler(this.lbxExistActor_SelectedIndexChanged);
            // 
            // lbxAddActor
            // 
            this.lbxAddActor.DataSource = this.phimDienVienBindingSource;
            this.lbxAddActor.DisplayMember = "TenDienVien";
            this.lbxAddActor.FormattingEnabled = true;
            this.lbxAddActor.ItemHeight = 16;
            this.lbxAddActor.Location = new System.Drawing.Point(752, 55);
            this.lbxAddActor.Name = "lbxAddActor";
            this.lbxAddActor.Size = new System.Drawing.Size(356, 388);
            this.lbxAddActor.TabIndex = 1;
            this.lbxAddActor.ValueMember = "MaDienVien";
            this.lbxAddActor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbxAddActor_MouseClick);
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(477, 139);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(100, 22);
            this.txtRole.TabIndex = 2;
            // 
            // btnAddActor
            // 
            this.btnAddActor.Location = new System.Drawing.Point(492, 189);
            this.btnAddActor.Name = "btnAddActor";
            this.btnAddActor.Size = new System.Drawing.Size(75, 23);
            this.btnAddActor.TabIndex = 3;
            this.btnAddActor.Text = "Add";
            this.btnAddActor.UseVisualStyleBackColor = true;
            this.btnAddActor.Click += new System.EventHandler(this.btnAddActor_Click);
            // 
            // btnDeleteActor
            // 
            this.btnDeleteActor.Location = new System.Drawing.Point(492, 235);
            this.btnDeleteActor.Name = "btnDeleteActor";
            this.btnDeleteActor.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteActor.TabIndex = 4;
            this.btnDeleteActor.Text = "Delete";
            this.btnDeleteActor.UseVisualStyleBackColor = true;
            this.btnDeleteActor.Click += new System.EventHandler(this.btnDeleteActor_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(492, 278);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddActor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 481);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDeleteActor);
            this.Controls.Add(this.btnAddActor);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.lbxAddActor);
            this.Controls.Add(this.lbxExistActor);
            this.Name = "AddActor";
            this.Text = "AddActor";
            this.Load += new System.EventHandler(this.AddActor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dienVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phimDienVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxExistActor;
        private System.Windows.Forms.ListBox lbxAddActor;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Button btnAddActor;
        private System.Windows.Forms.Button btnDeleteActor;
        private System.Windows.Forms.BindingSource phimDienVienBindingSource;
        private System.Windows.Forms.BindingSource dienVienBindingSource;
        private System.Windows.Forms.Button btnSave;
    }
}