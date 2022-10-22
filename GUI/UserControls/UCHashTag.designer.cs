namespace MovieWinform
{
    partial class UCHashTag
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
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridViewHashTag = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTenHashTag = new System.Windows.Forms.Label();
            this.txtTenHashTag = new System.Windows.Forms.TextBox();
            this.lblHashTag = new System.Windows.Forms.Label();
            this.txtMaHashTag = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHashTag)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(193, 4);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 30);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridViewHashTag
            // 
            this.dataGridViewHashTag.AllowUserToAddRows = false;
            this.dataGridViewHashTag.AllowUserToDeleteRows = false;
            this.dataGridViewHashTag.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHashTag.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewHashTag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHashTag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHashTag.Location = new System.Drawing.Point(3, 159);
            this.dataGridViewHashTag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewHashTag.Name = "dataGridViewHashTag";
            this.dataGridViewHashTag.ReadOnly = true;
            this.dataGridViewHashTag.RowHeadersWidth = 51;
            this.dataGridViewHashTag.RowTemplate.Height = 24;
            this.dataGridViewHashTag.Size = new System.Drawing.Size(1075, 710);
            this.dataGridViewHashTag.TabIndex = 34;
            this.dataGridViewHashTag.SelectionChanged += new System.EventHandler(this.dataGridViewHashTag_SelectionChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Location = new System.Drawing.Point(3, 4);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(71, 30);
            this.btnCreate.TabIndex = 33;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(98, 4);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 30);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTenHashTag
            // 
            this.lblTenHashTag.AutoSize = true;
            this.lblTenHashTag.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHashTag.Location = new System.Drawing.Point(3, 48);
            this.lblTenHashTag.Name = "lblTenHashTag";
            this.lblTenHashTag.Size = new System.Drawing.Size(135, 19);
            this.lblTenHashTag.TabIndex = 31;
            this.lblTenHashTag.Text = "HashTag Name";
            // 
            // txtTenHashTag
            // 
            this.txtTenHashTag.Location = new System.Drawing.Point(174, 52);
            this.txtTenHashTag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenHashTag.Name = "txtTenHashTag";
            this.txtTenHashTag.Size = new System.Drawing.Size(323, 24);
            this.txtTenHashTag.TabIndex = 30;
            // 
            // lblHashTag
            // 
            this.lblHashTag.AutoSize = true;
            this.lblHashTag.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHashTag.Location = new System.Drawing.Point(3, 0);
            this.lblHashTag.Name = "lblHashTag";
            this.lblHashTag.Size = new System.Drawing.Size(100, 19);
            this.lblHashTag.TabIndex = 29;
            this.lblHashTag.Text = "HashTag Id";
            // 
            // txtMaHashTag
            // 
            this.txtMaHashTag.Location = new System.Drawing.Point(174, 4);
            this.txtMaHashTag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaHashTag.Name = "txtMaHashTag";
            this.txtMaHashTag.Size = new System.Drawing.Size(323, 24);
            this.txtMaHashTag.TabIndex = 28;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.98784F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.01216F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtMaHashTag, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTenHashTag, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblHashTag, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTenHashTag, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(658, 147);
            this.tableLayoutPanel1.TabIndex = 38;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(174, 99);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(286, 39);
            this.tableLayoutPanel2.TabIndex = 37;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.dataGridViewHashTag, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.75487F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.24513F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1081, 873);
            this.tableLayoutPanel3.TabIndex = 39;
            // 
            // UCHashTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.Name = "UCHashTag";
            this.Size = new System.Drawing.Size(1081, 873);
            this.Load += new System.EventHandler(this.frmHashTag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHashTag)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridViewHashTag;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTenHashTag;
        private System.Windows.Forms.TextBox txtTenHashTag;
        private System.Windows.Forms.Label lblHashTag;
        private System.Windows.Forms.TextBox txtMaHashTag;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}
