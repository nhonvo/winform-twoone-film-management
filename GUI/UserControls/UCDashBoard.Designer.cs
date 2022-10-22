namespace MovieWinform
{
    partial class UCDashBoard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblRevenueMonth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblRevenueYear = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblSubsciption = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblRevenueToday = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tmNewSubscriptionsByYear = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tmNewSubscriptionsByMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tmNewSubscriptionsByYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmNewSubscriptionsByMonth)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1075, 100);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lblRevenueMonth);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(262, 94);
            this.panel4.TabIndex = 1;
            // 
            // lblRevenueMonth
            // 
            this.lblRevenueMonth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRevenueMonth.AutoSize = true;
            this.lblRevenueMonth.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueMonth.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRevenueMonth.Location = new System.Drawing.Point(32, 46);
            this.lblRevenueMonth.Name = "lblRevenueMonth";
            this.lblRevenueMonth.Size = new System.Drawing.Size(59, 32);
            this.lblRevenueMonth.TabIndex = 2;
            this.lblRevenueMonth.Text = "100";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Revenue this month";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(214)))), ((int)(((byte)(156)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.lblRevenueYear);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(271, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(262, 94);
            this.panel5.TabIndex = 1;
            // 
            // lblRevenueYear
            // 
            this.lblRevenueYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRevenueYear.AutoSize = true;
            this.lblRevenueYear.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueYear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRevenueYear.Location = new System.Drawing.Point(33, 46);
            this.lblRevenueYear.Name = "lblRevenueYear";
            this.lblRevenueYear.Size = new System.Drawing.Size(59, 32);
            this.lblRevenueYear.TabIndex = 6;
            this.lblRevenueYear.Text = "100";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(36, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Revenue this year";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.lblSubsciption);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(539, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(262, 94);
            this.panel6.TabIndex = 1;
            // 
            // lblSubsciption
            // 
            this.lblSubsciption.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubsciption.AutoSize = true;
            this.lblSubsciption.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubsciption.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSubsciption.Location = new System.Drawing.Point(32, 46);
            this.lblSubsciption.Name = "lblSubsciption";
            this.lblSubsciption.Size = new System.Drawing.Size(59, 32);
            this.lblSubsciption.TabIndex = 10;
            this.lblSubsciption.Text = "100";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(35, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(146, 17);
            this.label14.TabIndex = 9;
            this.label14.Text = "Subscription per user";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightCoral;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.lblRevenueToday);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(807, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(265, 94);
            this.panel7.TabIndex = 1;
            // 
            // lblRevenueToday
            // 
            this.lblRevenueToday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRevenueToday.AutoSize = true;
            this.lblRevenueToday.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueToday.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRevenueToday.Location = new System.Drawing.Point(33, 46);
            this.lblRevenueToday.Name = "lblRevenueToday";
            this.lblRevenueToday.Size = new System.Drawing.Size(59, 32);
            this.lblRevenueToday.TabIndex = 14;
            this.lblRevenueToday.Text = "100";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(36, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 17);
            this.label17.TabIndex = 13;
            this.label17.Text = "Revenue today";
            // 
            // tmNewSubscriptionsByYear
            // 
            chartArea1.Name = "ChartArea1";
            this.tmNewSubscriptionsByYear.ChartAreas.Add(chartArea1);
            this.tmNewSubscriptionsByYear.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.tmNewSubscriptionsByYear.Legends.Add(legend1);
            this.tmNewSubscriptionsByYear.Location = new System.Drawing.Point(3, 114);
            this.tmNewSubscriptionsByYear.Name = "tmNewSubscriptionsByYear";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "tmNewSubscriptionsByYear";
            series1.XValueMember = "Name";
            series1.YValueMembers = "Value";
            this.tmNewSubscriptionsByYear.Series.Add(series1);
            this.tmNewSubscriptionsByYear.Size = new System.Drawing.Size(1075, 365);
            this.tmNewSubscriptionsByYear.TabIndex = 18;
            this.tmNewSubscriptionsByYear.Text = "chart1";
            // 
            // tmNewSubscriptionsByMonth
            // 
            chartArea2.Name = "ChartArea1";
            this.tmNewSubscriptionsByMonth.ChartAreas.Add(chartArea2);
            this.tmNewSubscriptionsByMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.tmNewSubscriptionsByMonth.Legends.Add(legend2);
            this.tmNewSubscriptionsByMonth.Location = new System.Drawing.Point(3, 485);
            this.tmNewSubscriptionsByMonth.Name = "tmNewSubscriptionsByMonth";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.tmNewSubscriptionsByMonth.Series.Add(series2);
            this.tmNewSubscriptionsByMonth.Size = new System.Drawing.Size(1075, 367);
            this.tmNewSubscriptionsByMonth.TabIndex = 19;
            this.tmNewSubscriptionsByMonth.Text = "chart1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tmNewSubscriptionsByMonth, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tmNewSubscriptionsByYear, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.47826F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.47826F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1081, 855);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // UCDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCDashBoard";
            this.Size = new System.Drawing.Size(1081, 873);
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tmNewSubscriptionsByYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmNewSubscriptionsByMonth)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblRevenueMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblRevenueYear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblSubsciption;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblRevenueToday;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataVisualization.Charting.Chart tmNewSubscriptionsByYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart tmNewSubscriptionsByMonth;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
