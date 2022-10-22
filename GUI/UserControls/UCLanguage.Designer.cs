namespace MovieWinform
{
    partial class UCLanguage
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTenNgonNgu = new System.Windows.Forms.Label();
            this.txtLanguageName = new System.Windows.Forms.TextBox();
            this.lblMaNgonNgu = new System.Windows.Forms.Label();
            this.txtLanguageID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridViewLanguage = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLanguage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Location = new System.Drawing.Point(3, 4);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(71, 26);
            this.btnCreate.TabIndex = 23;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(101, 4);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 26);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTenNgonNgu
            // 
            this.lblTenNgonNgu.AutoSize = true;
            this.lblTenNgonNgu.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNgonNgu.Location = new System.Drawing.Point(3, 40);
            this.lblTenNgonNgu.Name = "lblTenNgonNgu";
            this.lblTenNgonNgu.Size = new System.Drawing.Size(147, 19);
            this.lblTenNgonNgu.TabIndex = 21;
            this.lblTenNgonNgu.Text = "Language Name";
            // 
            // txtLanguageName
            // 
            this.txtLanguageName.Location = new System.Drawing.Point(199, 44);
            this.txtLanguageName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLanguageName.Name = "txtLanguageName";
            this.txtLanguageName.Size = new System.Drawing.Size(252, 24);
            this.txtLanguageName.TabIndex = 20;
            this.txtLanguageName.Text = "0";
            // 
            // lblMaNgonNgu
            // 
            this.lblMaNgonNgu.AutoSize = true;
            this.lblMaNgonNgu.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNgonNgu.Location = new System.Drawing.Point(3, 0);
            this.lblMaNgonNgu.Name = "lblMaNgonNgu";
            this.lblMaNgonNgu.Size = new System.Drawing.Size(112, 19);
            this.lblMaNgonNgu.TabIndex = 19;
            this.lblMaNgonNgu.Text = "Language Id";
            // 
            // txtLanguageID
            // 
            this.txtLanguageID.Enabled = false;
            this.txtLanguageID.Location = new System.Drawing.Point(199, 4);
            this.txtLanguageID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLanguageID.Name = "txtLanguageID";
            this.txtLanguageID.Size = new System.Drawing.Size(252, 24);
            this.txtLanguageID.TabIndex = 18;
            this.txtLanguageID.Text = "0";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(199, 4);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 26);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridViewLanguage
            // 
            this.dataGridViewLanguage.AllowUserToAddRows = false;
            this.dataGridViewLanguage.AllowUserToDeleteRows = false;
            this.dataGridViewLanguage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLanguage.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewLanguage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLanguage.Location = new System.Drawing.Point(3, 135);
            this.dataGridViewLanguage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewLanguage.Name = "dataGridViewLanguage";
            this.dataGridViewLanguage.ReadOnly = true;
            this.dataGridViewLanguage.RowHeadersWidth = 51;
            this.dataGridViewLanguage.RowTemplate.Height = 24;
            this.dataGridViewLanguage.Size = new System.Drawing.Size(1075, 734);
            this.dataGridViewLanguage.TabIndex = 24;
            this.dataGridViewLanguage.SelectionChanged += new System.EventHandler(this.dataGridViewLanguage_SelectionChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.12333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.87667F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblMaNgonNgu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTenNgonNgu, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtLanguageID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtLanguageName, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(673, 120);
            this.tableLayoutPanel1.TabIndex = 37;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnCreate, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSave, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDelete, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(199, 83);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(295, 34);
            this.tableLayoutPanel2.TabIndex = 37;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.dataGridViewLanguage, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.12027F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.87972F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1081, 873);
            this.tableLayoutPanel3.TabIndex = 38;
            // 
            // UCLanguage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UCLanguage";
            this.Size = new System.Drawing.Size(1081, 873);
            this.Load += new System.EventHandler(this.LanguageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLanguage)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTenNgonNgu;
        private System.Windows.Forms.TextBox txtLanguageName;
        private System.Windows.Forms.Label lblMaNgonNgu;
        private System.Windows.Forms.TextBox txtLanguageID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridViewLanguage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}