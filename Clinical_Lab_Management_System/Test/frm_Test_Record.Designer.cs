namespace Clinical_Lab_Management_System
{
    partial class frm_Test_Record
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
            this.dtp_Time = new System.Windows.Forms.DateTimePicker();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_Back = new System.Windows.Forms.Button();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.clinical_Lab_Management_System_DBDataSet4 = new Clinical_Lab_Management_System.Clinical_Lab_Management_System_DBDataSet4();
            this.doctorDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_Test_Record = new System.Windows.Forms.Label();
            this.lbl_Test_ID = new System.Windows.Forms.Label();
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.lbl_Unit = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.tb_Test_ID = new System.Windows.Forms.TextBox();
            this.lbl_Up_Range = new System.Windows.Forms.Label();
            this.lbl_Lo_Range = new System.Windows.Forms.Label();
            this.tb_Test_Name = new System.Windows.Forms.TextBox();
            this.tb_Unit = new System.Windows.Forms.TextBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.tb_Test_Category = new System.Windows.Forms.TextBox();
            this.tb_Upper_Range = new System.Windows.Forms.TextBox();
            this.tb_Lower_Range = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tLoRangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tUpRangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRegDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinical_Lab_Management_System_DBDataSet12 = new Clinical_Lab_Management_System.Clinical_Lab_Management_System_DBDataSet12();
            this.test_DetailTableAdapter = new Clinical_Lab_Management_System.Clinical_Lab_Management_System_DBDataSet12TableAdapters.Test_DetailTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clinical_Lab_Management_System_DBDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinical_Lab_Management_System_DBDataSet12)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_Time
            // 
            this.dtp_Time.CustomFormat = "";
            this.dtp_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_Time.Location = new System.Drawing.Point(1212, 28);
            this.dtp_Time.Name = "dtp_Time";
            this.dtp_Time.Size = new System.Drawing.Size(81, 20);
            this.dtp_Time.TabIndex = 9;
            this.dtp_Time.Value = new System.DateTime(2021, 10, 29, 12, 44, 8, 0);
            // 
            // dtp_Date
            // 
            this.dtp_Date.CustomFormat = "";
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(1095, 28);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(100, 20);
            this.dtp_Date.TabIndex = 9;
            this.dtp_Date.Value = new System.DateTime(2021, 10, 29, 12, 42, 13, 0);
            // 
            // btn_Back
            // 
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Back.Location = new System.Drawing.Point(48, 15);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(95, 41);
            this.btn_Back.TabIndex = 22;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_Header.Controls.Add(this.btn_Back);
            this.pnl_Header.Controls.Add(this.dtp_Date);
            this.pnl_Header.Controls.Add(this.dtp_Time);
            this.pnl_Header.Location = new System.Drawing.Point(-5, -2);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1377, 74);
            this.pnl_Header.TabIndex = 77;
            // 
            // clinical_Lab_Management_System_DBDataSet4
            // 
            this.clinical_Lab_Management_System_DBDataSet4.DataSetName = "Clinical_Lab_Management_System_DBDataSet4";
            this.clinical_Lab_Management_System_DBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorDetailBindingSource
            // 
            this.doctorDetailBindingSource.DataMember = "Doctor_Detail";
            this.doctorDetailBindingSource.DataSource = this.clinical_Lab_Management_System_DBDataSet4;
            // 
            // lbl_Test_Record
            // 
            this.lbl_Test_Record.AutoSize = true;
            this.lbl_Test_Record.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Test_Record.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Test_Record.ForeColor = System.Drawing.Color.Red;
            this.lbl_Test_Record.Location = new System.Drawing.Point(541, 16);
            this.lbl_Test_Record.Name = "lbl_Test_Record";
            this.lbl_Test_Record.Size = new System.Drawing.Size(215, 45);
            this.lbl_Test_Record.TabIndex = 72;
            this.lbl_Test_Record.Text = "Test Record";
            // 
            // lbl_Test_ID
            // 
            this.lbl_Test_ID.AutoSize = true;
            this.lbl_Test_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Test_ID.Location = new System.Drawing.Point(400, 97);
            this.lbl_Test_ID.Name = "lbl_Test_ID";
            this.lbl_Test_ID.Size = new System.Drawing.Size(71, 23);
            this.lbl_Test_ID.TabIndex = 79;
            this.lbl_Test_ID.Text = "Test ID";
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FullName.Location = new System.Drawing.Point(453, 28);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(103, 23);
            this.lbl_FullName.TabIndex = 80;
            this.lbl_FullName.Text = "Test Name";
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.AutoSize = true;
            this.lbl_Unit.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unit.Location = new System.Drawing.Point(14, 111);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(48, 23);
            this.lbl_Unit.TabIndex = 87;
            this.lbl_Unit.Text = "Unit";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(453, 113);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(54, 23);
            this.lbl_Price.TabIndex = 86;
            this.lbl_Price.Text = "Price";
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category.Location = new System.Drawing.Point(14, 28);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(91, 23);
            this.lbl_Category.TabIndex = 83;
            this.lbl_Category.Text = "Category";
            // 
            // tb_Test_ID
            // 
            this.tb_Test_ID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Test_ID.Location = new System.Drawing.Point(495, 95);
            this.tb_Test_ID.Name = "tb_Test_ID";
            this.tb_Test_ID.Size = new System.Drawing.Size(114, 22);
            this.tb_Test_ID.TabIndex = 74;
            // 
            // lbl_Up_Range
            // 
            this.lbl_Up_Range.AutoSize = true;
            this.lbl_Up_Range.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Up_Range.Location = new System.Drawing.Point(14, 70);
            this.lbl_Up_Range.Name = "lbl_Up_Range";
            this.lbl_Up_Range.Size = new System.Drawing.Size(127, 23);
            this.lbl_Up_Range.TabIndex = 82;
            this.lbl_Up_Range.Text = "Upper Range";
            // 
            // lbl_Lo_Range
            // 
            this.lbl_Lo_Range.AutoSize = true;
            this.lbl_Lo_Range.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lo_Range.Location = new System.Drawing.Point(453, 70);
            this.lbl_Lo_Range.Name = "lbl_Lo_Range";
            this.lbl_Lo_Range.Size = new System.Drawing.Size(126, 23);
            this.lbl_Lo_Range.TabIndex = 78;
            this.lbl_Lo_Range.Text = "Lower Range";
            // 
            // tb_Test_Name
            // 
            this.tb_Test_Name.Enabled = false;
            this.tb_Test_Name.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Test_Name.Location = new System.Drawing.Point(601, 28);
            this.tb_Test_Name.Name = "tb_Test_Name";
            this.tb_Test_Name.Size = new System.Drawing.Size(228, 22);
            this.tb_Test_Name.TabIndex = 90;
            // 
            // tb_Unit
            // 
            this.tb_Unit.Enabled = false;
            this.tb_Unit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Unit.Location = new System.Drawing.Point(146, 113);
            this.tb_Unit.Name = "tb_Unit";
            this.tb_Unit.Size = new System.Drawing.Size(228, 22);
            this.tb_Unit.TabIndex = 91;
            // 
            // tb_Price
            // 
            this.tb_Price.Enabled = false;
            this.tb_Price.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Price.Location = new System.Drawing.Point(601, 112);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(228, 22);
            this.tb_Price.TabIndex = 92;
            // 
            // tb_Test_Category
            // 
            this.tb_Test_Category.Enabled = false;
            this.tb_Test_Category.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Test_Category.Location = new System.Drawing.Point(146, 28);
            this.tb_Test_Category.Name = "tb_Test_Category";
            this.tb_Test_Category.Size = new System.Drawing.Size(228, 22);
            this.tb_Test_Category.TabIndex = 97;
            // 
            // tb_Upper_Range
            // 
            this.tb_Upper_Range.Enabled = false;
            this.tb_Upper_Range.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Upper_Range.Location = new System.Drawing.Point(146, 72);
            this.tb_Upper_Range.Name = "tb_Upper_Range";
            this.tb_Upper_Range.Size = new System.Drawing.Size(228, 22);
            this.tb_Upper_Range.TabIndex = 96;
            // 
            // tb_Lower_Range
            // 
            this.tb_Lower_Range.Enabled = false;
            this.tb_Lower_Range.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Lower_Range.Location = new System.Drawing.Point(601, 72);
            this.tb_Lower_Range.Name = "tb_Lower_Range";
            this.tb_Lower_Range.Size = new System.Drawing.Size(228, 22);
            this.tb_Lower_Range.TabIndex = 95;
            // 
            // btn_Search
            // 
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Search.Location = new System.Drawing.Point(627, 86);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(87, 34);
            this.btn_Search.TabIndex = 75;
            this.btn_Search.Text = "Search";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Clear.Location = new System.Drawing.Point(749, 86);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(89, 34);
            this.btn_Clear.TabIndex = 76;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tIDDataGridViewTextBoxColumn,
            this.tCategoryDataGridViewTextBoxColumn,
            this.tNameDataGridViewTextBoxColumn,
            this.tLoRangeDataGridViewTextBoxColumn,
            this.tUpRangeDataGridViewTextBoxColumn,
            this.tUnitDataGridViewTextBoxColumn,
            this.tPriceDataGridViewTextBoxColumn,
            this.tDescriptionDataGridViewTextBoxColumn,
            this.tRegDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.testDetailBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-5, 328);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1377, 426);
            this.dataGridView1.TabIndex = 100;
            // 
            // tIDDataGridViewTextBoxColumn
            // 
            this.tIDDataGridViewTextBoxColumn.DataPropertyName = "T_ID";
            this.tIDDataGridViewTextBoxColumn.HeaderText = "T_ID";
            this.tIDDataGridViewTextBoxColumn.Name = "tIDDataGridViewTextBoxColumn";
            // 
            // tCategoryDataGridViewTextBoxColumn
            // 
            this.tCategoryDataGridViewTextBoxColumn.DataPropertyName = "T_Category";
            this.tCategoryDataGridViewTextBoxColumn.HeaderText = "T_Category";
            this.tCategoryDataGridViewTextBoxColumn.Name = "tCategoryDataGridViewTextBoxColumn";
            // 
            // tNameDataGridViewTextBoxColumn
            // 
            this.tNameDataGridViewTextBoxColumn.DataPropertyName = "T_Name";
            this.tNameDataGridViewTextBoxColumn.HeaderText = "T_Name";
            this.tNameDataGridViewTextBoxColumn.Name = "tNameDataGridViewTextBoxColumn";
            // 
            // tLoRangeDataGridViewTextBoxColumn
            // 
            this.tLoRangeDataGridViewTextBoxColumn.DataPropertyName = "T_Lo_Range";
            this.tLoRangeDataGridViewTextBoxColumn.HeaderText = "T_Lo_Range";
            this.tLoRangeDataGridViewTextBoxColumn.Name = "tLoRangeDataGridViewTextBoxColumn";
            // 
            // tUpRangeDataGridViewTextBoxColumn
            // 
            this.tUpRangeDataGridViewTextBoxColumn.DataPropertyName = "T_Up_Range";
            this.tUpRangeDataGridViewTextBoxColumn.HeaderText = "T_Up_Range";
            this.tUpRangeDataGridViewTextBoxColumn.Name = "tUpRangeDataGridViewTextBoxColumn";
            // 
            // tUnitDataGridViewTextBoxColumn
            // 
            this.tUnitDataGridViewTextBoxColumn.DataPropertyName = "T_Unit";
            this.tUnitDataGridViewTextBoxColumn.HeaderText = "T_Unit";
            this.tUnitDataGridViewTextBoxColumn.Name = "tUnitDataGridViewTextBoxColumn";
            // 
            // tPriceDataGridViewTextBoxColumn
            // 
            this.tPriceDataGridViewTextBoxColumn.DataPropertyName = "T_Price";
            this.tPriceDataGridViewTextBoxColumn.HeaderText = "T_Price";
            this.tPriceDataGridViewTextBoxColumn.Name = "tPriceDataGridViewTextBoxColumn";
            // 
            // tDescriptionDataGridViewTextBoxColumn
            // 
            this.tDescriptionDataGridViewTextBoxColumn.DataPropertyName = "T_Description";
            this.tDescriptionDataGridViewTextBoxColumn.HeaderText = "T_Description";
            this.tDescriptionDataGridViewTextBoxColumn.Name = "tDescriptionDataGridViewTextBoxColumn";
            // 
            // tRegDateDataGridViewTextBoxColumn
            // 
            this.tRegDateDataGridViewTextBoxColumn.DataPropertyName = "T_Reg_Date";
            this.tRegDateDataGridViewTextBoxColumn.HeaderText = "T_Reg_Date";
            this.tRegDateDataGridViewTextBoxColumn.Name = "tRegDateDataGridViewTextBoxColumn";
            // 
            // testDetailBindingSource
            // 
            this.testDetailBindingSource.DataMember = "Test_Detail";
            this.testDetailBindingSource.DataSource = this.clinical_Lab_Management_System_DBDataSet12;
            // 
            // clinical_Lab_Management_System_DBDataSet12
            // 
            this.clinical_Lab_Management_System_DBDataSet12.DataSetName = "Clinical_Lab_Management_System_DBDataSet12";
            this.clinical_Lab_Management_System_DBDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // test_DetailTableAdapter
            // 
            this.test_DetailTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_Test_Name);
            this.groupBox1.Controls.Add(this.lbl_FullName);
            this.groupBox1.Controls.Add(this.lbl_Unit);
            this.groupBox1.Controls.Add(this.lbl_Price);
            this.groupBox1.Controls.Add(this.tb_Lower_Range);
            this.groupBox1.Controls.Add(this.lbl_Category);
            this.groupBox1.Controls.Add(this.tb_Upper_Range);
            this.groupBox1.Controls.Add(this.lbl_Up_Range);
            this.groupBox1.Controls.Add(this.tb_Test_Category);
            this.groupBox1.Controls.Add(this.lbl_Lo_Range);
            this.groupBox1.Controls.Add(this.tb_Price);
            this.groupBox1.Controls.Add(this.tb_Unit);
            this.groupBox1.Location = new System.Drawing.Point(225, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 159);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            // 
            // frm_Test_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Test_ID);
            this.Controls.Add(this.lbl_Test_ID);
            this.Controls.Add(this.lbl_Test_Record);
            this.Controls.Add(this.pnl_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(77, 439);
            this.Name = "frm_Test_Record";
            this.Text = "Test_Record";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Test_Record_Load);
            this.pnl_Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clinical_Lab_Management_System_DBDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinical_Lab_Management_System_DBDataSet12)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_Time;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel pnl_Header;
        private Clinical_Lab_Management_System_DBDataSet4 clinical_Lab_Management_System_DBDataSet4;
        private System.Windows.Forms.BindingSource doctorDetailBindingSource;
        private System.Windows.Forms.Label lbl_Test_Record;
        private System.Windows.Forms.Label lbl_Test_ID;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.Label lbl_Unit;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.TextBox tb_Test_ID;
        private System.Windows.Forms.Label lbl_Up_Range;
        private System.Windows.Forms.Label lbl_Lo_Range;
        private System.Windows.Forms.TextBox tb_Test_Name;
        private System.Windows.Forms.TextBox tb_Unit;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.TextBox tb_Test_Category;
        private System.Windows.Forms.TextBox tb_Upper_Range;
        private System.Windows.Forms.TextBox tb_Lower_Range;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Clinical_Lab_Management_System_DBDataSet12 clinical_Lab_Management_System_DBDataSet12;
        private System.Windows.Forms.BindingSource testDetailBindingSource;
        private Clinical_Lab_Management_System_DBDataSet12TableAdapters.Test_DetailTableAdapter test_DetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tLoRangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tUpRangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRegDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}