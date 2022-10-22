namespace MovieWinform
{
    partial class Actor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewActor = new System.Windows.Forms.DataGridView();
            this.lblNationName = new System.Windows.Forms.Label();
            this.txtActorName = new System.Windows.Forms.TextBox();
            this.lblNationId = new System.Windows.Forms.Label();
            this.txtActorId = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxActor = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewActor
            // 
            this.dataGridViewActor.AllowUserToAddRows = false;
            this.dataGridViewActor.AllowUserToDeleteRows = false;
            this.dataGridViewActor.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewActor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActor.Location = new System.Drawing.Point(30, 178);
            this.dataGridViewActor.Name = "dataGridViewActor";
            this.dataGridViewActor.ReadOnly = true;
            this.dataGridViewActor.RowHeadersWidth = 51;
            this.dataGridViewActor.RowTemplate.Height = 24;
            this.dataGridViewActor.Size = new System.Drawing.Size(508, 121);
            this.dataGridViewActor.TabIndex = 42;
            this.dataGridViewActor.SelectionChanged += new System.EventHandler(this.dataGridViewActor_SelectionChanged);
            // 
            // lblNationName
            // 
            this.lblNationName.AutoSize = true;
            this.lblNationName.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationName.Location = new System.Drawing.Point(27, 62);
            this.lblNationName.Name = "lblNationName";
            this.lblNationName.Size = new System.Drawing.Size(109, 19);
            this.lblNationName.TabIndex = 39;
            this.lblNationName.Text = "Actor Name";
            // 
            // txtActorName
            // 
            this.txtActorName.Location = new System.Drawing.Point(189, 62);
            this.txtActorName.Name = "txtActorName";
            this.txtActorName.Size = new System.Drawing.Size(345, 22);
            this.txtActorName.TabIndex = 38;
            this.txtActorName.Text = "0";
            // 
            // lblNationId
            // 
            this.lblNationId.AutoSize = true;
            this.lblNationId.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationId.Location = new System.Drawing.Point(27, 22);
            this.lblNationId.Name = "lblNationId";
            this.lblNationId.Size = new System.Drawing.Size(74, 19);
            this.lblNationId.TabIndex = 37;
            this.lblNationId.Text = "Actor Id";
            // 
            // txtActorId
            // 
            this.txtActorId.Location = new System.Drawing.Point(189, 16);
            this.txtActorId.Name = "txtActorId";
            this.txtActorId.Size = new System.Drawing.Size(345, 22);
            this.txtActorId.TabIndex = 36;
            this.txtActorId.Text = "0";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(455, 130);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 24);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(197, 130);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(83, 24);
            this.btnCreate.TabIndex = 44;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(330, 130);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 24);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(677, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 47;
            this.label1.Text = "Actor Image";
            // 
            // pictureBoxActor
            // 
            this.pictureBoxActor.Image = global::MovieWinform.Properties.Resources.a;
            this.pictureBoxActor.Location = new System.Drawing.Point(681, 62);
            this.pictureBoxActor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxActor.Name = "pictureBoxActor";
            this.pictureBoxActor.Size = new System.Drawing.Size(178, 130);
            this.pictureBoxActor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxActor.TabIndex = 48;
            this.pictureBoxActor.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpload.Location = new System.Drawing.Point(681, 215);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(83, 24);
            this.btnUpload.TabIndex = 49;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // Actor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.pictureBoxActor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridViewActor);
            this.Controls.Add(this.lblNationName);
            this.Controls.Add(this.txtActorName);
            this.Controls.Add(this.lblNationId);
            this.Controls.Add(this.txtActorId);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Actor";
            this.Size = new System.Drawing.Size(1039, 505);
            this.Load += new System.EventHandler(this.Actor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxActor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewActor;
        private System.Windows.Forms.Label lblNationName;
        private System.Windows.Forms.TextBox txtActorName;
        private System.Windows.Forms.Label lblNationId;
        private System.Windows.Forms.TextBox txtActorId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxActor;
        private System.Windows.Forms.Button btnUpload;
    }
}
