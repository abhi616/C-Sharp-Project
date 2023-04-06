namespace Clinical_Lab_Management_System
{
    partial class frm_Patient
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
            this.lbl_Header = new System.Windows.Forms.Label();
            this.pnl_Patient = new System.Windows.Forms.Panel();
            this.btn_Patient_Receipt = new System.Windows.Forms.Button();
            this.btn_Patient_Record = new System.Windows.Forms.Button();
            this.btn_Patient_Registration = new System.Windows.Forms.Button();
            this.pb_Patient_Record = new System.Windows.Forms.PictureBox();
            this.pb_Update_Patient = new System.Windows.Forms.PictureBox();
            this.pb_Patient_Registration = new System.Windows.Forms.PictureBox();
            this.pnl_Patient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Patient_Record)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Update_Patient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Patient_Registration)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.BackColor = System.Drawing.Color.Orange;
            this.lbl_Header.Font = new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Black;
            this.lbl_Header.Location = new System.Drawing.Point(636, 23);
            this.lbl_Header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(195, 65);
            this.lbl_Header.TabIndex = 23;
            this.lbl_Header.Text = "Patient";
            // 
            // pnl_Patient
            // 
            this.pnl_Patient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_Patient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Patient.Controls.Add(this.btn_Patient_Receipt);
            this.pnl_Patient.Controls.Add(this.btn_Patient_Record);
            this.pnl_Patient.Controls.Add(this.btn_Patient_Registration);
            this.pnl_Patient.Controls.Add(this.pb_Patient_Record);
            this.pnl_Patient.Controls.Add(this.pb_Update_Patient);
            this.pnl_Patient.Controls.Add(this.pb_Patient_Registration);
            this.pnl_Patient.Location = new System.Drawing.Point(0, 111);
            this.pnl_Patient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Patient.Name = "pnl_Patient";
            this.pnl_Patient.Size = new System.Drawing.Size(2007, 1019);
            this.pnl_Patient.TabIndex = 0;
            // 
            // btn_Patient_Receipt
            // 
            this.btn_Patient_Receipt.BackColor = System.Drawing.Color.Transparent;
            this.btn_Patient_Receipt.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Patient_Receipt.Location = new System.Drawing.Point(771, 709);
            this.btn_Patient_Receipt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Patient_Receipt.Name = "btn_Patient_Receipt";
            this.btn_Patient_Receipt.Size = new System.Drawing.Size(293, 59);
            this.btn_Patient_Receipt.TabIndex = 3;
            this.btn_Patient_Receipt.Text = "Patient Receipt";
            this.btn_Patient_Receipt.UseVisualStyleBackColor = false;
            this.btn_Patient_Receipt.Click += new System.EventHandler(this.btn_Patient_Receipt_Click);
            // 
            // btn_Patient_Record
            // 
            this.btn_Patient_Record.BackColor = System.Drawing.Color.Transparent;
            this.btn_Patient_Record.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Patient_Record.Location = new System.Drawing.Point(355, 709);
            this.btn_Patient_Record.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Patient_Record.Name = "btn_Patient_Record";
            this.btn_Patient_Record.Size = new System.Drawing.Size(305, 59);
            this.btn_Patient_Record.TabIndex = 2;
            this.btn_Patient_Record.Text = "Patient Record";
            this.btn_Patient_Record.UseVisualStyleBackColor = false;
            this.btn_Patient_Record.Click += new System.EventHandler(this.btn_Patient_Record_Click);
            // 
            // btn_Patient_Registration
            // 
            this.btn_Patient_Registration.BackColor = System.Drawing.Color.Transparent;
            this.btn_Patient_Registration.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Patient_Registration.Location = new System.Drawing.Point(588, 305);
            this.btn_Patient_Registration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Patient_Registration.Name = "btn_Patient_Registration";
            this.btn_Patient_Registration.Size = new System.Drawing.Size(305, 59);
            this.btn_Patient_Registration.TabIndex = 1;
            this.btn_Patient_Registration.Text = "New Patient Registration";
            this.btn_Patient_Registration.UseVisualStyleBackColor = false;
            this.btn_Patient_Registration.Click += new System.EventHandler(this.btn_Patient_Registration_Click);
            // 
            // pb_Patient_Record
            // 
            this.pb_Patient_Record.BackgroundImage = global::Clinical_Lab_Management_System.Properties.Resources.patient_Search;
            this.pb_Patient_Record.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Patient_Record.Location = new System.Drawing.Point(381, 454);
            this.pb_Patient_Record.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_Patient_Record.Name = "pb_Patient_Record";
            this.pb_Patient_Record.Size = new System.Drawing.Size(257, 218);
            this.pb_Patient_Record.TabIndex = 8;
            this.pb_Patient_Record.TabStop = false;
            // 
            // pb_Update_Patient
            // 
            this.pb_Update_Patient.Image = global::Clinical_Lab_Management_System.Properties.Resources.doctor__2_1;
            this.pb_Update_Patient.Location = new System.Drawing.Point(805, 454);
            this.pb_Update_Patient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_Update_Patient.Name = "pb_Update_Patient";
            this.pb_Update_Patient.Size = new System.Drawing.Size(228, 218);
            this.pb_Update_Patient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Update_Patient.TabIndex = 11;
            this.pb_Update_Patient.TabStop = false;
            // 
            // pb_Patient_Registration
            // 
            this.pb_Patient_Registration.BackgroundImage = global::Clinical_Lab_Management_System.Properties.Resources.Add_Patient_removebg_preview;
            this.pb_Patient_Registration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Patient_Registration.Location = new System.Drawing.Point(615, 50);
            this.pb_Patient_Registration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_Patient_Registration.Name = "pb_Patient_Registration";
            this.pb_Patient_Registration.Size = new System.Drawing.Size(257, 218);
            this.pb_Patient_Registration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Patient_Registration.TabIndex = 10;
            this.pb_Patient_Registration.TabStop = false;
            // 
            // frm_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.pnl_Patient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frm_Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Patient";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_Patient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Patient_Record)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Update_Patient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Patient_Registration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Patient_Record;
        private System.Windows.Forms.PictureBox pb_Update_Patient;
        private System.Windows.Forms.PictureBox pb_Patient_Registration;
        private System.Windows.Forms.Button btn_Patient_Record;
        private System.Windows.Forms.Button btn_Patient_Receipt;
        private System.Windows.Forms.Button btn_Patient_Registration;
        private System.Windows.Forms.Panel pnl_Patient;
        private System.Windows.Forms.Label lbl_Header;
    }
}