namespace Clinical_Lab_Management_System
{
    partial class frm_Dash_Board
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
            this.pnl_Load = new System.Windows.Forms.Panel();
            this.pnl_Dashboard = new System.Windows.Forms.Panel();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.btn_Report = new System.Windows.Forms.Button();
            this.btn_History = new System.Windows.Forms.Button();
            this.btn_Test = new System.Windows.Forms.Button();
            this.btn_Staff = new System.Windows.Forms.Button();
            this.btn_Doctor = new System.Windows.Forms.Button();
            this.btn_Patient = new System.Windows.Forms.Button();
            this.btn_Logo = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.pb_Username = new System.Windows.Forms.PictureBox();
            this.pnl_Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Username)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Load
            // 
            this.pnl_Load.Location = new System.Drawing.Point(345, 0);
            this.pnl_Load.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Load.Name = "pnl_Load";
            this.pnl_Load.Size = new System.Drawing.Size(1675, 1254);
            this.pnl_Load.TabIndex = 4;
            this.pnl_Load.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Load_Paint);
            // 
            // pnl_Dashboard
            // 
            this.pnl_Dashboard.BackColor = System.Drawing.Color.DimGray;
            this.pnl_Dashboard.Controls.Add(this.btn_Log_Out);
            this.pnl_Dashboard.Controls.Add(this.btn_Report);
            this.pnl_Dashboard.Controls.Add(this.btn_History);
            this.pnl_Dashboard.Controls.Add(this.btn_Test);
            this.pnl_Dashboard.Controls.Add(this.btn_Staff);
            this.pnl_Dashboard.Controls.Add(this.btn_Doctor);
            this.pnl_Dashboard.Controls.Add(this.btn_Patient);
            this.pnl_Dashboard.Controls.Add(this.btn_Logo);
            this.pnl_Dashboard.Controls.Add(this.btn_Dashboard);
            this.pnl_Dashboard.Controls.Add(this.lbl_Username);
            this.pnl_Dashboard.Controls.Add(this.pb_Username);
            this.pnl_Dashboard.Location = new System.Drawing.Point(0, 0);
            this.pnl_Dashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Dashboard.Name = "pnl_Dashboard";
            this.pnl_Dashboard.Size = new System.Drawing.Size(343, 1238);
            this.pnl_Dashboard.TabIndex = 1;
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Log_Out.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Log_Out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Log_Out.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.Black;
            this.btn_Log_Out.Location = new System.Drawing.Point(53, 809);
            this.btn_Log_Out.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(239, 52);
            this.btn_Log_Out.TabIndex = 8;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // btn_Report
            // 
            this.btn_Report.BackColor = System.Drawing.Color.DimGray;
            this.btn_Report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Report.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Report.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Report.Location = new System.Drawing.Point(-3, 645);
            this.btn_Report.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Report.Name = "btn_Report";
            this.btn_Report.Size = new System.Drawing.Size(344, 52);
            this.btn_Report.TabIndex = 7;
            this.btn_Report.Text = "Report";
            this.btn_Report.UseVisualStyleBackColor = false;
            this.btn_Report.Click += new System.EventHandler(this.btn_Medical_Click);
            // 
            // btn_History
            // 
            this.btn_History.BackColor = System.Drawing.Color.DimGray;
            this.btn_History.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_History.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_History.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_History.ForeColor = System.Drawing.Color.Yellow;
            this.btn_History.Location = new System.Drawing.Point(-1, 714);
            this.btn_History.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_History.Name = "btn_History";
            this.btn_History.Size = new System.Drawing.Size(344, 52);
            this.btn_History.TabIndex = 6;
            this.btn_History.Text = "History";
            this.btn_History.UseVisualStyleBackColor = false;
            this.btn_History.Visible = false;
            this.btn_History.Click += new System.EventHandler(this.btn_Delete_Record_Click);
            // 
            // btn_Test
            // 
            this.btn_Test.BackColor = System.Drawing.Color.DimGray;
            this.btn_Test.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Test.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Test.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Test.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Test.Location = new System.Drawing.Point(-1, 510);
            this.btn_Test.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(344, 48);
            this.btn_Test.TabIndex = 4;
            this.btn_Test.Text = "Test";
            this.btn_Test.UseVisualStyleBackColor = false;
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // btn_Staff
            // 
            this.btn_Staff.BackColor = System.Drawing.Color.DimGray;
            this.btn_Staff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Staff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Staff.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Staff.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Staff.Location = new System.Drawing.Point(-1, 576);
            this.btn_Staff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Staff.Name = "btn_Staff";
            this.btn_Staff.Size = new System.Drawing.Size(344, 50);
            this.btn_Staff.TabIndex = 5;
            this.btn_Staff.Text = "Staff";
            this.btn_Staff.UseVisualStyleBackColor = false;
            this.btn_Staff.Click += new System.EventHandler(this.btn_Staff_Click);
            // 
            // btn_Doctor
            // 
            this.btn_Doctor.BackColor = System.Drawing.Color.DimGray;
            this.btn_Doctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Doctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Doctor.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Doctor.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Doctor.Location = new System.Drawing.Point(-1, 443);
            this.btn_Doctor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Doctor.Name = "btn_Doctor";
            this.btn_Doctor.Size = new System.Drawing.Size(344, 48);
            this.btn_Doctor.TabIndex = 3;
            this.btn_Doctor.Text = "Doctor";
            this.btn_Doctor.UseVisualStyleBackColor = false;
            this.btn_Doctor.Click += new System.EventHandler(this.btn_Doctor_Click);
            // 
            // btn_Patient
            // 
            this.btn_Patient.BackColor = System.Drawing.Color.DimGray;
            this.btn_Patient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Patient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Patient.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Patient.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Patient.Location = new System.Drawing.Point(-1, 378);
            this.btn_Patient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Patient.Name = "btn_Patient";
            this.btn_Patient.Size = new System.Drawing.Size(344, 47);
            this.btn_Patient.TabIndex = 2;
            this.btn_Patient.Text = "Patient";
            this.btn_Patient.UseVisualStyleBackColor = false;
            this.btn_Patient.Click += new System.EventHandler(this.btn_Patient_Click);
            // 
            // btn_Logo
            // 
            this.btn_Logo.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_Logo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_Logo.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logo.ForeColor = System.Drawing.Color.Red;
            this.btn_Logo.Location = new System.Drawing.Point(-1, 0);
            this.btn_Logo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Logo.Name = "btn_Logo";
            this.btn_Logo.Size = new System.Drawing.Size(351, 66);
            this.btn_Logo.TabIndex = 0;
            this.btn_Logo.Text = "AK Laboratory";
            this.btn_Logo.UseVisualStyleBackColor = false;
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.BackColor = System.Drawing.Color.DimGray;
            this.btn_Dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Dashboard.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dashboard.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Dashboard.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_Dashboard.Location = new System.Drawing.Point(-1, 313);
            this.btn_Dashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Size = new System.Drawing.Size(343, 47);
            this.btn_Dashboard.TabIndex = 1;
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.UseVisualStyleBackColor = false;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Username.Location = new System.Drawing.Point(95, 249);
            this.lbl_Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(129, 40);
            this.lbl_Username.TabIndex = 3;
            this.lbl_Username.Text = "Admin";
            // 
            // pb_Username
            // 
            this.pb_Username.Image = global::Clinical_Lab_Management_System.Properties.Resources.pixlr_bg_result;
            this.pb_Username.Location = new System.Drawing.Point(69, 92);
            this.pb_Username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_Username.Name = "pb_Username";
            this.pb_Username.Size = new System.Drawing.Size(197, 133);
            this.pb_Username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Username.TabIndex = 2;
            this.pb_Username.TabStop = false;
            // 
            // frm_Dash_Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.pnl_Dashboard);
            this.Controls.Add(this.pnl_Load);
            this.ForeColor = System.Drawing.Color.Firebrick;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_Dash_Board";
            this.Text = "Dash Board";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Dash_Board_Load);
            this.pnl_Dashboard.ResumeLayout(false);
            this.pnl_Dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Username)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Dashboard;
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.Button btn_Doctor;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.PictureBox pb_Username;
        private System.Windows.Forms.Button btn_History;
        private System.Windows.Forms.Button btn_Staff;
        private System.Windows.Forms.Button btn_Logo;
        private System.Windows.Forms.Button btn_Log_Out;
        public System.Windows.Forms.Panel pnl_Load;
        public System.Windows.Forms.Button btn_Patient;
        private System.Windows.Forms.Button btn_Report;
    }
}