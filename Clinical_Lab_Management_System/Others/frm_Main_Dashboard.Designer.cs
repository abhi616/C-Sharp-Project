namespace Clinical_Lab_Management_System
{
    partial class frm_Main_Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_Earning = new System.Windows.Forms.Label();
            this.lbl_Earning_Status = new System.Windows.Forms.Label();
            this.lbl_Earning_Count = new System.Windows.Forms.Label();
            this.pnl_Earning = new System.Windows.Forms.Panel();
            this.lbl_Todays_Patient_Status = new System.Windows.Forms.Label();
            this.lbl_Todays_Patient = new System.Windows.Forms.Label();
            this.lbl_Todays_Patient_Count = new System.Windows.Forms.Label();
            this.pnl_Todays_Patient = new System.Windows.Forms.Panel();
            this.lbl_Todays_Status = new System.Windows.Forms.Label();
            this.lbl_Todays = new System.Windows.Forms.Label();
            this.lbl_Todays_Count = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_Todays_Test_Status = new System.Windows.Forms.Label();
            this.lbl_Todays_Test = new System.Windows.Forms.Label();
            this.lbl_Todays_Test_Count = new System.Windows.Forms.Label();
            this.pnl_Todays_Test = new System.Windows.Forms.Panel();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnl_Dashboard = new System.Windows.Forms.Panel();
            this.text_Effect1 = new Clinical_Lab_Management_System.Text_Effect();
            this.pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.pnl_Earning.SuspendLayout();
            this.pnl_Todays_Patient.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnl_Todays_Test.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.pnl_Dashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.DimGray;
            this.pnl_Header.Controls.Add(this.lbl_Header);
            this.pnl_Header.Location = new System.Drawing.Point(1, 0);
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1868, 90);
            this.pnl_Header.TabIndex = 12;
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbl_Header.Location = new System.Drawing.Point(177, 7);
            this.lbl_Header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(1058, 76);
            this.lbl_Header.TabIndex = 3;
            this.lbl_Header.Text = "AK Clinical Lab Management System";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(37, 460);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Male";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Female";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(751, 410);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // lbl_Earning
            // 
            this.lbl_Earning.AutoSize = true;
            this.lbl_Earning.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Earning.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_Earning.Location = new System.Drawing.Point(4, 0);
            this.lbl_Earning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Earning.Name = "lbl_Earning";
            this.lbl_Earning.Size = new System.Drawing.Size(154, 40);
            this.lbl_Earning.TabIndex = 3;
            this.lbl_Earning.Text = "Earning";
            this.lbl_Earning.Visible = false;
            // 
            // lbl_Earning_Status
            // 
            this.lbl_Earning_Status.AutoSize = true;
            this.lbl_Earning_Status.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Earning_Status.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_Earning_Status.Location = new System.Drawing.Point(27, 110);
            this.lbl_Earning_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Earning_Status.Name = "lbl_Earning_Status";
            this.lbl_Earning_Status.Size = new System.Drawing.Size(206, 17);
            this.lbl_Earning_Status.TabIndex = 3;
            this.lbl_Earning_Status.Text = "Status Update On last 28 days";
            this.lbl_Earning_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Earning_Status.Visible = false;
            // 
            // lbl_Earning_Count
            // 
            this.lbl_Earning_Count.AutoSize = true;
            this.lbl_Earning_Count.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Earning_Count.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbl_Earning_Count.Location = new System.Drawing.Point(99, 57);
            this.lbl_Earning_Count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Earning_Count.Name = "lbl_Earning_Count";
            this.lbl_Earning_Count.Size = new System.Drawing.Size(67, 40);
            this.lbl_Earning_Count.TabIndex = 3;
            this.lbl_Earning_Count.Text = "0.0";
            this.lbl_Earning_Count.Visible = false;
            // 
            // pnl_Earning
            // 
            this.pnl_Earning.BackColor = System.Drawing.Color.Gold;
            this.pnl_Earning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Earning.Controls.Add(this.lbl_Earning_Count);
            this.pnl_Earning.Controls.Add(this.lbl_Earning_Status);
            this.pnl_Earning.Controls.Add(this.lbl_Earning);
            this.pnl_Earning.Location = new System.Drawing.Point(47, 229);
            this.pnl_Earning.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Earning.Name = "pnl_Earning";
            this.pnl_Earning.Size = new System.Drawing.Size(266, 142);
            this.pnl_Earning.TabIndex = 1;
            this.pnl_Earning.Visible = false;
            // 
            // lbl_Todays_Patient_Status
            // 
            this.lbl_Todays_Patient_Status.AutoSize = true;
            this.lbl_Todays_Patient_Status.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Todays_Patient_Status.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_Todays_Patient_Status.Location = new System.Drawing.Point(32, 110);
            this.lbl_Todays_Patient_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Todays_Patient_Status.Name = "lbl_Todays_Patient_Status";
            this.lbl_Todays_Patient_Status.Size = new System.Drawing.Size(206, 17);
            this.lbl_Todays_Patient_Status.TabIndex = 3;
            this.lbl_Todays_Patient_Status.Text = "Status Update On last 28 days";
            this.lbl_Todays_Patient_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Todays_Patient
            // 
            this.lbl_Todays_Patient.AutoSize = true;
            this.lbl_Todays_Patient.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Todays_Patient.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_Todays_Patient.Location = new System.Drawing.Point(4, 0);
            this.lbl_Todays_Patient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Todays_Patient.Name = "lbl_Todays_Patient";
            this.lbl_Todays_Patient.Size = new System.Drawing.Size(239, 35);
            this.lbl_Todays_Patient.TabIndex = 3;
            this.lbl_Todays_Patient.Text = "Todays Patient";
            // 
            // lbl_Todays_Patient_Count
            // 
            this.lbl_Todays_Patient_Count.AutoSize = true;
            this.lbl_Todays_Patient_Count.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Todays_Patient_Count.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbl_Todays_Patient_Count.Location = new System.Drawing.Point(92, 57);
            this.lbl_Todays_Patient_Count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Todays_Patient_Count.Name = "lbl_Todays_Patient_Count";
            this.lbl_Todays_Patient_Count.Size = new System.Drawing.Size(77, 40);
            this.lbl_Todays_Patient_Count.TabIndex = 3;
            this.lbl_Todays_Patient_Count.Text = "000";
            // 
            // pnl_Todays_Patient
            // 
            this.pnl_Todays_Patient.BackColor = System.Drawing.Color.LawnGreen;
            this.pnl_Todays_Patient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Todays_Patient.Controls.Add(this.lbl_Todays_Patient_Count);
            this.pnl_Todays_Patient.Controls.Add(this.lbl_Todays_Patient);
            this.pnl_Todays_Patient.Controls.Add(this.lbl_Todays_Patient_Status);
            this.pnl_Todays_Patient.Location = new System.Drawing.Point(421, 143);
            this.pnl_Todays_Patient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Todays_Patient.Name = "pnl_Todays_Patient";
            this.pnl_Todays_Patient.Size = new System.Drawing.Size(266, 142);
            this.pnl_Todays_Patient.TabIndex = 2;
            this.pnl_Todays_Patient.Visible = false;
            // 
            // lbl_Todays_Status
            // 
            this.lbl_Todays_Status.AutoSize = true;
            this.lbl_Todays_Status.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Todays_Status.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_Todays_Status.Location = new System.Drawing.Point(28, 110);
            this.lbl_Todays_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Todays_Status.Name = "lbl_Todays_Status";
            this.lbl_Todays_Status.Size = new System.Drawing.Size(206, 17);
            this.lbl_Todays_Status.TabIndex = 3;
            this.lbl_Todays_Status.Text = "Status Update On last 28 days";
            this.lbl_Todays_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Todays_Status.Visible = false;
            // 
            // lbl_Todays
            // 
            this.lbl_Todays.AutoSize = true;
            this.lbl_Todays.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Todays.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_Todays.Location = new System.Drawing.Point(5, 2);
            this.lbl_Todays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Todays.Name = "lbl_Todays";
            this.lbl_Todays.Size = new System.Drawing.Size(129, 35);
            this.lbl_Todays.TabIndex = 3;
            this.lbl_Todays.Text = "Todays ";
            this.lbl_Todays.Visible = false;
            // 
            // lbl_Todays_Count
            // 
            this.lbl_Todays_Count.AutoSize = true;
            this.lbl_Todays_Count.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Todays_Count.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbl_Todays_Count.Location = new System.Drawing.Point(93, 57);
            this.lbl_Todays_Count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Todays_Count.Name = "lbl_Todays_Count";
            this.lbl_Todays_Count.Size = new System.Drawing.Size(77, 40);
            this.lbl_Todays_Count.TabIndex = 3;
            this.lbl_Todays_Count.Text = "000";
            this.lbl_Todays_Count.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lbl_Todays_Count);
            this.panel4.Controls.Add(this.lbl_Todays);
            this.panel4.Controls.Add(this.lbl_Todays_Status);
            this.panel4.Location = new System.Drawing.Point(801, 229);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(266, 142);
            this.panel4.TabIndex = 3;
            this.panel4.Visible = false;
            // 
            // lbl_Todays_Test_Status
            // 
            this.lbl_Todays_Test_Status.AutoSize = true;
            this.lbl_Todays_Test_Status.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Todays_Test_Status.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_Todays_Test_Status.Location = new System.Drawing.Point(32, 110);
            this.lbl_Todays_Test_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Todays_Test_Status.Name = "lbl_Todays_Test_Status";
            this.lbl_Todays_Test_Status.Size = new System.Drawing.Size(206, 17);
            this.lbl_Todays_Test_Status.TabIndex = 3;
            this.lbl_Todays_Test_Status.Text = "Status Update On last 28 days";
            this.lbl_Todays_Test_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Todays_Test_Status.Visible = false;
            // 
            // lbl_Todays_Test
            // 
            this.lbl_Todays_Test.AutoSize = true;
            this.lbl_Todays_Test.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Todays_Test.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lbl_Todays_Test.Location = new System.Drawing.Point(4, 6);
            this.lbl_Todays_Test.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Todays_Test.Name = "lbl_Todays_Test";
            this.lbl_Todays_Test.Size = new System.Drawing.Size(194, 35);
            this.lbl_Todays_Test.TabIndex = 3;
            this.lbl_Todays_Test.Text = "Todays Test";
            this.lbl_Todays_Test.Visible = false;
            // 
            // lbl_Todays_Test_Count
            // 
            this.lbl_Todays_Test_Count.AutoSize = true;
            this.lbl_Todays_Test_Count.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Todays_Test_Count.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbl_Todays_Test_Count.Location = new System.Drawing.Point(99, 57);
            this.lbl_Todays_Test_Count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Todays_Test_Count.Name = "lbl_Todays_Test_Count";
            this.lbl_Todays_Test_Count.Size = new System.Drawing.Size(77, 40);
            this.lbl_Todays_Test_Count.TabIndex = 3;
            this.lbl_Todays_Test_Count.Text = "000";
            this.lbl_Todays_Test_Count.Visible = false;
            // 
            // pnl_Todays_Test
            // 
            this.pnl_Todays_Test.BackColor = System.Drawing.Color.Violet;
            this.pnl_Todays_Test.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Todays_Test.Controls.Add(this.lbl_Todays_Test_Count);
            this.pnl_Todays_Test.Controls.Add(this.lbl_Todays_Test);
            this.pnl_Todays_Test.Controls.Add(this.lbl_Todays_Test_Status);
            this.pnl_Todays_Test.Location = new System.Drawing.Point(1176, 229);
            this.pnl_Todays_Test.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Todays_Test.Name = "pnl_Todays_Test";
            this.pnl_Todays_Test.Size = new System.Drawing.Size(266, 142);
            this.pnl_Todays_Test.TabIndex = 4;
            this.pnl_Todays_Test.Visible = false;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chart2.BackImageTransparentColor = System.Drawing.SystemColors.ActiveCaption;
            this.chart2.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipXY;
            this.chart2.BackSecondaryColor = System.Drawing.SystemColors.ActiveCaption;
            this.chart2.BorderlineColor = System.Drawing.SystemColors.ActiveCaption;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(845, 460);
            this.chart2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(608, 388);
            this.chart2.TabIndex = 13;
            this.chart2.Text = "chart2";
            this.chart2.Visible = false;
            // 
            // pnl_Dashboard
            // 
            this.pnl_Dashboard.BackgroundImage = global::Clinical_Lab_Management_System.Properties.Resources.Screenshot__82_;
            this.pnl_Dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Dashboard.Controls.Add(this.text_Effect1);
            this.pnl_Dashboard.Controls.Add(this.pnl_Todays_Patient);
            this.pnl_Dashboard.Location = new System.Drawing.Point(1, 86);
            this.pnl_Dashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Dashboard.Name = "pnl_Dashboard";
            this.pnl_Dashboard.Size = new System.Drawing.Size(1868, 1029);
            this.pnl_Dashboard.TabIndex = 14;
            // 
            // text_Effect1
            // 
            this.text_Effect1.BackColor = System.Drawing.Color.White;
            this.text_Effect1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Effect1.ForeColor = System.Drawing.Color.Red;
            this.text_Effect1.Location = new System.Drawing.Point(0, 44);
            this.text_Effect1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text_Effect1.Name = "text_Effect1";
            this.text_Effect1.Set_Speed = 5;
            this.text_Effect1.Size = new System.Drawing.Size(1868, 36);
            this.text_Effect1.TabIndex = 3;
            this.text_Effect1.Text = "Welcome To Your \"AK CLINICAL LAB\" Near Fork Infosystem, Karad, Maharashtra Open 2" +
                "4 hours";
            this.text_Effect1.UseCompatibleTextRendering = true;
            // 
            // frm_Main_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1870, 1073);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.pnl_Header);
            this.Controls.Add(this.pnl_Todays_Test);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnl_Earning);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pnl_Dashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Main_Dashboard";
            this.Text = "frm_Main_Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.pnl_Earning.ResumeLayout(false);
            this.pnl_Earning.PerformLayout();
            this.pnl_Todays_Patient.ResumeLayout(false);
            this.pnl_Todays_Patient.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pnl_Todays_Test.ResumeLayout(false);
            this.pnl_Todays_Test.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.pnl_Dashboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbl_Earning;
        private System.Windows.Forms.Label lbl_Earning_Status;
        private System.Windows.Forms.Label lbl_Earning_Count;
        private System.Windows.Forms.Panel pnl_Earning;
        private System.Windows.Forms.Label lbl_Todays_Patient_Status;
        private System.Windows.Forms.Label lbl_Todays_Patient;
        private System.Windows.Forms.Label lbl_Todays_Patient_Count;
        private System.Windows.Forms.Panel pnl_Todays_Patient;
        private System.Windows.Forms.Label lbl_Todays_Status;
        private System.Windows.Forms.Label lbl_Todays;
        private System.Windows.Forms.Label lbl_Todays_Count;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_Todays_Test_Status;
        private System.Windows.Forms.Label lbl_Todays_Test;
        private System.Windows.Forms.Label lbl_Todays_Test_Count;
        private System.Windows.Forms.Panel pnl_Todays_Test;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel pnl_Dashboard;
        private Text_Effect text_Effect1;
    }
}