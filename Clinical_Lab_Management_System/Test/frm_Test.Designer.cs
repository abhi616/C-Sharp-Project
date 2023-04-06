namespace Clinical_Lab_Management_System
{
    partial class frm_Test
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
            this.btn_Test_Record = new System.Windows.Forms.Button();
            this.btn_Update_Test = new System.Windows.Forms.Button();
            this.btn_Add_New_Test = new System.Windows.Forms.Button();
            this.pnl_Test = new System.Windows.Forms.Panel();
            this.text_Effect1 = new Clinical_Lab_Management_System.Text_Effect();
            this.pb_Test_Record = new System.Windows.Forms.PictureBox();
            this.pb_Update_Test = new System.Windows.Forms.PictureBox();
            this.pb_Add_New_Test = new System.Windows.Forms.PictureBox();
            this.lbl_Test = new System.Windows.Forms.Label();
            this.pnl_Test.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Test_Record)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Update_Test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Add_New_Test)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Test_Record
            // 
            this.btn_Test_Record.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Test_Record.Location = new System.Drawing.Point(811, 416);
            this.btn_Test_Record.Name = "btn_Test_Record";
            this.btn_Test_Record.Size = new System.Drawing.Size(229, 48);
            this.btn_Test_Record.TabIndex = 3;
            this.btn_Test_Record.Text = "Test Record";
            this.btn_Test_Record.UseVisualStyleBackColor = true;
            this.btn_Test_Record.Click += new System.EventHandler(this.btn_Test_Record_Click);
            // 
            // btn_Update_Test
            // 
            this.btn_Update_Test.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Test.Location = new System.Drawing.Point(447, 416);
            this.btn_Update_Test.Name = "btn_Update_Test";
            this.btn_Update_Test.Size = new System.Drawing.Size(229, 48);
            this.btn_Update_Test.TabIndex = 2;
            this.btn_Update_Test.Text = "Update Test";
            this.btn_Update_Test.UseVisualStyleBackColor = true;
            this.btn_Update_Test.Click += new System.EventHandler(this.btn_Update_Test_Click);
            // 
            // btn_Add_New_Test
            // 
            this.btn_Add_New_Test.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Test.Location = new System.Drawing.Point(43, 416);
            this.btn_Add_New_Test.Name = "btn_Add_New_Test";
            this.btn_Add_New_Test.Size = new System.Drawing.Size(229, 48);
            this.btn_Add_New_Test.TabIndex = 1;
            this.btn_Add_New_Test.Text = "Add New Test";
            this.btn_Add_New_Test.UseVisualStyleBackColor = true;
            this.btn_Add_New_Test.Click += new System.EventHandler(this.btn_Add_New_Test_Click);
            // 
            // pnl_Test
            // 
            this.pnl_Test.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_Test.Controls.Add(this.text_Effect1);
            this.pnl_Test.Controls.Add(this.btn_Update_Test);
            this.pnl_Test.Controls.Add(this.btn_Add_New_Test);
            this.pnl_Test.Controls.Add(this.pb_Test_Record);
            this.pnl_Test.Controls.Add(this.btn_Test_Record);
            this.pnl_Test.Controls.Add(this.pb_Update_Test);
            this.pnl_Test.Controls.Add(this.pb_Add_New_Test);
            this.pnl_Test.Location = new System.Drawing.Point(0, 90);
            this.pnl_Test.Name = "pnl_Test";
            this.pnl_Test.Size = new System.Drawing.Size(1114, 710);
            this.pnl_Test.TabIndex = 0;
            // 
            // text_Effect1
            // 
            this.text_Effect1.BackColor = System.Drawing.Color.White;
            this.text_Effect1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Effect1.ForeColor = System.Drawing.Color.Red;
            this.text_Effect1.Location = new System.Drawing.Point(269, 21);
            this.text_Effect1.Name = "text_Effect1";
            this.text_Effect1.Set_Speed = 3;
            this.text_Effect1.Size = new System.Drawing.Size(534, 17);
            this.text_Effect1.TabIndex = 15;
            this.text_Effect1.Text = "Test Dashboard Acces Only Admin";
            this.text_Effect1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.text_Effect1.UseCompatibleTextRendering = true;
            // 
            // pb_Test_Record
            // 
            this.pb_Test_Record.BackgroundImage = global::Clinical_Lab_Management_System.Properties.Resources.result;
            this.pb_Test_Record.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Test_Record.Location = new System.Drawing.Point(842, 211);
            this.pb_Test_Record.Name = "pb_Test_Record";
            this.pb_Test_Record.Size = new System.Drawing.Size(171, 177);
            this.pb_Test_Record.TabIndex = 8;
            this.pb_Test_Record.TabStop = false;
            // 
            // pb_Update_Test
            // 
            this.pb_Update_Test.BackgroundImage = global::Clinical_Lab_Management_System.Properties.Resources.test_results__1_;
            this.pb_Update_Test.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Update_Test.Location = new System.Drawing.Point(478, 211);
            this.pb_Update_Test.Name = "pb_Update_Test";
            this.pb_Update_Test.Size = new System.Drawing.Size(171, 177);
            this.pb_Update_Test.TabIndex = 11;
            this.pb_Update_Test.TabStop = false;
            // 
            // pb_Add_New_Test
            // 
            this.pb_Add_New_Test.BackgroundImage = global::Clinical_Lab_Management_System.Properties.Resources.test__3_;
            this.pb_Add_New_Test.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_Add_New_Test.Location = new System.Drawing.Point(77, 211);
            this.pb_Add_New_Test.Name = "pb_Add_New_Test";
            this.pb_Add_New_Test.Size = new System.Drawing.Size(171, 177);
            this.pb_Add_New_Test.TabIndex = 10;
            this.pb_Add_New_Test.TabStop = false;
            // 
            // lbl_Test
            // 
            this.lbl_Test.AutoSize = true;
            this.lbl_Test.BackColor = System.Drawing.Color.Orange;
            this.lbl_Test.Font = new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Test.ForeColor = System.Drawing.Color.Black;
            this.lbl_Test.Location = new System.Drawing.Point(493, 21);
            this.lbl_Test.Name = "lbl_Test";
            this.lbl_Test.Size = new System.Drawing.Size(101, 51);
            this.lbl_Test.TabIndex = 24;
            this.lbl_Test.Text = "Test";
            // 
            // frm_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1116, 749);
            this.Controls.Add(this.lbl_Test);
            this.Controls.Add(this.pnl_Test);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Test";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_Test.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Test_Record)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Update_Test)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Add_New_Test)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Test_Record;
        private System.Windows.Forms.PictureBox pb_Update_Test;
        private System.Windows.Forms.PictureBox pb_Add_New_Test;
        private System.Windows.Forms.Button btn_Test_Record;
        private System.Windows.Forms.Button btn_Update_Test;
        private System.Windows.Forms.Button btn_Add_New_Test;
        private System.Windows.Forms.Panel pnl_Test;
        private System.Windows.Forms.Label lbl_Test;
        private Text_Effect text_Effect1;
    }
}