namespace Clinical_Lab_Management_System
{
    partial class frm_Add_New_Test
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
            this.lbl_New_Test_Entry = new System.Windows.Forms.Label();
            this.lbl_Test_ID = new System.Windows.Forms.Label();
            this.lbl_Test_Name = new System.Windows.Forms.Label();
            this.lbl_Upper_Range = new System.Windows.Forms.Label();
            this.lbl_Unit = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_Test_Category = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.tb_Test_Name = new System.Windows.Forms.TextBox();
            this.tb_Test_Category = new System.Windows.Forms.TextBox();
            this.tb_Upper_Range = new System.Windows.Forms.TextBox();
            this.tb_Lower_Range = new System.Windows.Forms.TextBox();
            this.tb_Unit = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Lower_Range = new System.Windows.Forms.Label();
            this.rtb_Description = new System.Windows.Forms.RichTextBox();
            this.gb_Test_Details = new System.Windows.Forms.GroupBox();
            this.tb_Test_ID = new System.Windows.Forms.TextBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.dgv_Test_Details = new System.Windows.Forms.DataGridView();
            this.tIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tLoRangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tUpRangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRegDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testDetailBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.clinical_Lab_Management_System_DBDataSet10 = new Clinical_Lab_Management_System.Clinical_Lab_Management_System_DBDataSet10();
            this.testDetailBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clinical_Lab_Management_System_DBDataSet9 = new Clinical_Lab_Management_System.Clinical_Lab_Management_System_DBDataSet9();
            this.addNewTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinical_Lab_Management_System_DBDataSet6 = new Clinical_Lab_Management_System.Clinical_Lab_Management_System_DBDataSet6();
            this.add_New_TestTableAdapter = new Clinical_Lab_Management_System.Clinical_Lab_Management_System_DBDataSet6TableAdapters.Add_New_TestTableAdapter();
            this.clinical_Lab_Management_System_DBDataSet7 = new Clinical_Lab_Management_System.Clinical_Lab_Management_System_DBDataSet7();
            this.clinical_Lab_Management_System_DBDataSet8 = new Clinical_Lab_Management_System.Clinical_Lab_Management_System_DBDataSet8();
            this.testDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.test_DetailTableAdapter = new Clinical_Lab_Management_System.Clinical_Lab_Management_System_DBDataSet7TableAdapters.Test_DetailTableAdapter();
            this.test_DetailTableAdapter1 = new Clinical_Lab_Management_System.Clinical_Lab_Management_System_DBDataSet9TableAdapters.Test_DetailTableAdapter();
            this.test_DetailTableAdapter2 = new Clinical_Lab_Management_System.Clinical_Lab_Management_System_DBDataSet10TableAdapters.Test_DetailTableAdapter();
            this.clinical_Lab_Management_System_DBDataSet17 = new Clinical_Lab_Management_System.Clinical_Lab_Management_System_DBDataSet17();
            this.testDetailBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.test_DetailTableAdapter3 = new Clinical_Lab_Management_System.Clinical_Lab_Management_System_DBDataSet17TableAdapters.Test_DetailTableAdapter();
            this.pnl_Header.SuspendLayout();
            this.gb_Test_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Test_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDetailBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinical_Lab_Management_System_DBDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDetailBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinical_Lab_Management_System_DBDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNewTestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinical_Lab_Management_System_DBDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinical_Lab_Management_System_DBDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinical_Lab_Management_System_DBDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinical_Lab_Management_System_DBDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDetailBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_Time
            // 
            this.dtp_Time.CustomFormat = "";
            this.dtp_Time.Enabled = false;
            this.dtp_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_Time.Location = new System.Drawing.Point(1624, 32);
            this.dtp_Time.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_Time.Name = "dtp_Time";
            this.dtp_Time.Size = new System.Drawing.Size(107, 22);
            this.dtp_Time.TabIndex = 9;
            this.dtp_Time.Value = new System.DateTime(2021, 10, 29, 12, 44, 8, 0);
            // 
            // dtp_Date
            // 
            this.dtp_Date.CustomFormat = "";
            this.dtp_Date.Enabled = false;
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(1461, 32);
            this.dtp_Date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(132, 22);
            this.dtp_Date.TabIndex = 9;
            this.dtp_Date.Value = new System.DateTime(2021, 10, 29, 12, 42, 13, 0);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(64, 18);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(127, 50);
            this.btn_Back.TabIndex = 0;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_Header.Controls.Add(this.lbl_New_Test_Entry);
            this.pnl_Header.Controls.Add(this.btn_Back);
            this.pnl_Header.Controls.Add(this.dtp_Date);
            this.pnl_Header.Controls.Add(this.dtp_Time);
            this.pnl_Header.Location = new System.Drawing.Point(-7, 0);
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1836, 96);
            this.pnl_Header.TabIndex = 1;
            // 
            // lbl_New_Test_Entry
            // 
            this.lbl_New_Test_Entry.AutoSize = true;
            this.lbl_New_Test_Entry.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_New_Test_Entry.ForeColor = System.Drawing.Color.Red;
            this.lbl_New_Test_Entry.Location = new System.Drawing.Point(712, 18);
            this.lbl_New_Test_Entry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_New_Test_Entry.Name = "lbl_New_Test_Entry";
            this.lbl_New_Test_Entry.Size = new System.Drawing.Size(333, 60);
            this.lbl_New_Test_Entry.TabIndex = 7;
            this.lbl_New_Test_Entry.Text = "Add New Test";
            // 
            // lbl_Test_ID
            // 
            this.lbl_Test_ID.AutoSize = true;
            this.lbl_Test_ID.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Test_ID.Location = new System.Drawing.Point(45, 75);
            this.lbl_Test_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Test_ID.Name = "lbl_Test_ID";
            this.lbl_Test_ID.Size = new System.Drawing.Size(103, 28);
            this.lbl_Test_ID.TabIndex = 0;
            this.lbl_Test_ID.Text = "Test ID";
            // 
            // lbl_Test_Name
            // 
            this.lbl_Test_Name.AutoSize = true;
            this.lbl_Test_Name.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Test_Name.Location = new System.Drawing.Point(45, 169);
            this.lbl_Test_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Test_Name.Name = "lbl_Test_Name";
            this.lbl_Test_Name.Size = new System.Drawing.Size(129, 28);
            this.lbl_Test_Name.TabIndex = 0;
            this.lbl_Test_Name.Text = "Test Name";
            // 
            // lbl_Upper_Range
            // 
            this.lbl_Upper_Range.AutoSize = true;
            this.lbl_Upper_Range.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Upper_Range.Location = new System.Drawing.Point(47, 265);
            this.lbl_Upper_Range.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Upper_Range.Name = "lbl_Upper_Range";
            this.lbl_Upper_Range.Size = new System.Drawing.Size(155, 28);
            this.lbl_Upper_Range.TabIndex = 0;
            this.lbl_Upper_Range.Text = "Upper Range";
            // 
            // lbl_Unit
            // 
            this.lbl_Unit.AutoSize = true;
            this.lbl_Unit.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unit.Location = new System.Drawing.Point(47, 322);
            this.lbl_Unit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Unit.Name = "lbl_Unit";
            this.lbl_Unit.Size = new System.Drawing.Size(64, 28);
            this.lbl_Unit.TabIndex = 0;
            this.lbl_Unit.Text = "Unit";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(47, 379);
            this.lbl_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(77, 28);
            this.lbl_Price.TabIndex = 0;
            this.lbl_Price.Text = "Price";
            // 
            // lbl_Test_Category
            // 
            this.lbl_Test_Category.AutoSize = true;
            this.lbl_Test_Category.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Test_Category.Location = new System.Drawing.Point(45, 121);
            this.lbl_Test_Category.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Test_Category.Name = "lbl_Test_Category";
            this.lbl_Test_Category.Size = new System.Drawing.Size(181, 28);
            this.lbl_Test_Category.TabIndex = 0;
            this.lbl_Test_Category.Text = "Test Category";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.Location = new System.Drawing.Point(45, 431);
            this.lbl_Description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(155, 28);
            this.lbl_Description.TabIndex = 0;
            this.lbl_Description.Text = "Description";
            // 
            // tb_Test_Name
            // 
            this.tb_Test_Name.Location = new System.Drawing.Point(236, 169);
            this.tb_Test_Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Test_Name.Name = "tb_Test_Name";
            this.tb_Test_Name.Size = new System.Drawing.Size(287, 29);
            this.tb_Test_Name.TabIndex = 2;
            // 
            // tb_Test_Category
            // 
            this.tb_Test_Category.Location = new System.Drawing.Point(236, 121);
            this.tb_Test_Category.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Test_Category.Name = "tb_Test_Category";
            this.tb_Test_Category.Size = new System.Drawing.Size(287, 29);
            this.tb_Test_Category.TabIndex = 1;
            // 
            // tb_Upper_Range
            // 
            this.tb_Upper_Range.Location = new System.Drawing.Point(236, 268);
            this.tb_Upper_Range.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Upper_Range.Name = "tb_Upper_Range";
            this.tb_Upper_Range.Size = new System.Drawing.Size(233, 29);
            this.tb_Upper_Range.TabIndex = 4;
            // 
            // tb_Lower_Range
            // 
            this.tb_Lower_Range.Location = new System.Drawing.Point(236, 219);
            this.tb_Lower_Range.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Lower_Range.Name = "tb_Lower_Range";
            this.tb_Lower_Range.Size = new System.Drawing.Size(233, 29);
            this.tb_Lower_Range.TabIndex = 3;
            // 
            // tb_Unit
            // 
            this.tb_Unit.Location = new System.Drawing.Point(236, 322);
            this.tb_Unit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Unit.Name = "tb_Unit";
            this.tb_Unit.Size = new System.Drawing.Size(233, 29);
            this.tb_Unit.TabIndex = 5;
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(123, 551);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(112, 47);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(337, 550);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(112, 47);
            this.btn_Close.TabIndex = 10;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_Lower_Range
            // 
            this.lbl_Lower_Range.AutoSize = true;
            this.lbl_Lower_Range.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lower_Range.Location = new System.Drawing.Point(47, 219);
            this.lbl_Lower_Range.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Lower_Range.Name = "lbl_Lower_Range";
            this.lbl_Lower_Range.Size = new System.Drawing.Size(155, 28);
            this.lbl_Lower_Range.TabIndex = 0;
            this.lbl_Lower_Range.Text = "Lower Range";
            // 
            // rtb_Description
            // 
            this.rtb_Description.Location = new System.Drawing.Point(236, 431);
            this.rtb_Description.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtb_Description.Name = "rtb_Description";
            this.rtb_Description.Size = new System.Drawing.Size(287, 64);
            this.rtb_Description.TabIndex = 7;
            this.rtb_Description.Text = "";
            // 
            // gb_Test_Details
            // 
            this.gb_Test_Details.Controls.Add(this.tb_Test_ID);
            this.gb_Test_Details.Controls.Add(this.rtb_Description);
            this.gb_Test_Details.Controls.Add(this.lbl_Lower_Range);
            this.gb_Test_Details.Controls.Add(this.btn_Close);
            this.gb_Test_Details.Controls.Add(this.btn_Add);
            this.gb_Test_Details.Controls.Add(this.tb_Price);
            this.gb_Test_Details.Controls.Add(this.tb_Unit);
            this.gb_Test_Details.Controls.Add(this.tb_Lower_Range);
            this.gb_Test_Details.Controls.Add(this.tb_Upper_Range);
            this.gb_Test_Details.Controls.Add(this.tb_Test_Category);
            this.gb_Test_Details.Controls.Add(this.tb_Test_Name);
            this.gb_Test_Details.Controls.Add(this.lbl_Description);
            this.gb_Test_Details.Controls.Add(this.lbl_Test_Category);
            this.gb_Test_Details.Controls.Add(this.lbl_Price);
            this.gb_Test_Details.Controls.Add(this.lbl_Unit);
            this.gb_Test_Details.Controls.Add(this.lbl_Upper_Range);
            this.gb_Test_Details.Controls.Add(this.lbl_Test_Name);
            this.gb_Test_Details.Controls.Add(this.lbl_Test_ID);
            this.gb_Test_Details.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Test_Details.Location = new System.Drawing.Point(33, 176);
            this.gb_Test_Details.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_Test_Details.Name = "gb_Test_Details";
            this.gb_Test_Details.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_Test_Details.Size = new System.Drawing.Size(567, 634);
            this.gb_Test_Details.TabIndex = 0;
            this.gb_Test_Details.TabStop = false;
            this.gb_Test_Details.Text = "Test Details";
            // 
            // tb_Test_ID
            // 
            this.tb_Test_ID.Enabled = false;
            this.tb_Test_ID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Test_ID.Location = new System.Drawing.Point(236, 74);
            this.tb_Test_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Test_ID.Name = "tb_Test_ID";
            this.tb_Test_ID.Size = new System.Drawing.Size(120, 27);
            this.tb_Test_ID.TabIndex = 3;
            // 
            // tb_Price
            // 
            this.tb_Price.Location = new System.Drawing.Point(236, 374);
            this.tb_Price.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(233, 29);
            this.tb_Price.TabIndex = 6;
            // 
            // dgv_Test_Details
            // 
            this.dgv_Test_Details.AllowUserToAddRows = false;
            this.dgv_Test_Details.AllowUserToDeleteRows = false;
            this.dgv_Test_Details.AutoGenerateColumns = false;
            this.dgv_Test_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Test_Details.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_Test_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Test_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tIDDataGridViewTextBoxColumn,
            this.tCategoryDataGridViewTextBoxColumn,
            this.tNameDataGridViewTextBoxColumn,
            this.tLoRangeDataGridViewTextBoxColumn,
            this.tUpRangeDataGridViewTextBoxColumn,
            this.tUnitDataGridViewTextBoxColumn,
            this.tPriceDataGridViewTextBoxColumn,
            this.tDescriptionDataGridViewTextBoxColumn,
            this.tRegDateDataGridViewTextBoxColumn});
            this.dgv_Test_Details.DataSource = this.testDetailBindingSource3;
            this.dgv_Test_Details.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_Test_Details.Location = new System.Drawing.Point(623, 186);
            this.dgv_Test_Details.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Test_Details.Name = "dgv_Test_Details";
            this.dgv_Test_Details.ReadOnly = true;
            this.dgv_Test_Details.Size = new System.Drawing.Size(1153, 624);
            this.dgv_Test_Details.TabIndex = 2;
            this.dgv_Test_Details.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Test_Details_CellContentClick);
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
            // testDetailBindingSource2
            // 
            this.testDetailBindingSource2.DataMember = "Test_Detail";
            this.testDetailBindingSource2.DataSource = this.clinical_Lab_Management_System_DBDataSet10;
            // 
            // clinical_Lab_Management_System_DBDataSet10
            // 
            this.clinical_Lab_Management_System_DBDataSet10.DataSetName = "Clinical_Lab_Management_System_DBDataSet10";
            this.clinical_Lab_Management_System_DBDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testDetailBindingSource1
            // 
            this.testDetailBindingSource1.DataMember = "Test_Detail";
            this.testDetailBindingSource1.DataSource = this.clinical_Lab_Management_System_DBDataSet9;
            // 
            // clinical_Lab_Management_System_DBDataSet9
            // 
            this.clinical_Lab_Management_System_DBDataSet9.DataSetName = "Clinical_Lab_Management_System_DBDataSet9";
            this.clinical_Lab_Management_System_DBDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addNewTestBindingSource
            // 
            this.addNewTestBindingSource.DataMember = "Add_New_Test";
            this.addNewTestBindingSource.DataSource = this.clinical_Lab_Management_System_DBDataSet6;
            // 
            // clinical_Lab_Management_System_DBDataSet6
            // 
            this.clinical_Lab_Management_System_DBDataSet6.DataSetName = "Clinical_Lab_Management_System_DBDataSet6";
            this.clinical_Lab_Management_System_DBDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // add_New_TestTableAdapter
            // 
            this.add_New_TestTableAdapter.ClearBeforeFill = true;
            // 
            // clinical_Lab_Management_System_DBDataSet7
            // 
            this.clinical_Lab_Management_System_DBDataSet7.DataSetName = "Clinical_Lab_Management_System_DBDataSet7";
            this.clinical_Lab_Management_System_DBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clinical_Lab_Management_System_DBDataSet8
            // 
            this.clinical_Lab_Management_System_DBDataSet8.DataSetName = "Clinical_Lab_Management_System_DBDataSet8";
            this.clinical_Lab_Management_System_DBDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testDetailBindingSource
            // 
            this.testDetailBindingSource.DataMember = "Test_Detail";
            this.testDetailBindingSource.DataSource = this.clinical_Lab_Management_System_DBDataSet7;
            // 
            // test_DetailTableAdapter
            // 
            this.test_DetailTableAdapter.ClearBeforeFill = true;
            // 
            // test_DetailTableAdapter1
            // 
            this.test_DetailTableAdapter1.ClearBeforeFill = true;
            // 
            // test_DetailTableAdapter2
            // 
            this.test_DetailTableAdapter2.ClearBeforeFill = true;
            // 
            // clinical_Lab_Management_System_DBDataSet17
            // 
            this.clinical_Lab_Management_System_DBDataSet17.DataSetName = "Clinical_Lab_Management_System_DBDataSet17";
            this.clinical_Lab_Management_System_DBDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testDetailBindingSource3
            // 
            this.testDetailBindingSource3.DataMember = "Test_Detail";
            this.testDetailBindingSource3.DataSource = this.clinical_Lab_Management_System_DBDataSet17;
            // 
            // test_DetailTableAdapter3
            // 
            this.test_DetailTableAdapter3.ClearBeforeFill = true;
            // 
            // frm_Add_New_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1805, 901);
            this.Controls.Add(this.dgv_Test_Details);
            this.Controls.Add(this.gb_Test_Details);
            this.Controls.Add(this.pnl_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_Add_New_Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Test";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Add_New_Test_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.gb_Test_Details.ResumeLayout(false);
            this.gb_Test_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Test_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDetailBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinical_Lab_Management_System_DBDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDetailBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinical_Lab_Management_System_DBDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNewTestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinical_Lab_Management_System_DBDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinical_Lab_Management_System_DBDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinical_Lab_Management_System_DBDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinical_Lab_Management_System_DBDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDetailBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_Time;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_New_Test_Entry;
        private System.Windows.Forms.Label lbl_Test_ID;
        private System.Windows.Forms.Label lbl_Test_Name;
        private System.Windows.Forms.Label lbl_Upper_Range;
        private System.Windows.Forms.Label lbl_Unit;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Label lbl_Test_Category;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.TextBox tb_Test_Name;
        private System.Windows.Forms.TextBox tb_Test_Category;
        private System.Windows.Forms.TextBox tb_Upper_Range;
        private System.Windows.Forms.TextBox tb_Lower_Range;
        private System.Windows.Forms.TextBox tb_Unit;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_Lower_Range;
        private System.Windows.Forms.RichTextBox rtb_Description;
        private System.Windows.Forms.GroupBox gb_Test_Details;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.DataGridView dgv_Test_Details;
        private Clinical_Lab_Management_System_DBDataSet6 clinical_Lab_Management_System_DBDataSet6;
        private System.Windows.Forms.BindingSource addNewTestBindingSource;
        private Clinical_Lab_Management_System_DBDataSet6TableAdapters.Add_New_TestTableAdapter add_New_TestTableAdapter;
        private System.Windows.Forms.TextBox tb_Test_ID;
        private Clinical_Lab_Management_System_DBDataSet7 clinical_Lab_Management_System_DBDataSet7;
        private Clinical_Lab_Management_System_DBDataSet8 clinical_Lab_Management_System_DBDataSet8;
        private System.Windows.Forms.BindingSource testDetailBindingSource;
        private Clinical_Lab_Management_System_DBDataSet7TableAdapters.Test_DetailTableAdapter test_DetailTableAdapter;
        private Clinical_Lab_Management_System_DBDataSet9 clinical_Lab_Management_System_DBDataSet9;
        private System.Windows.Forms.BindingSource testDetailBindingSource1;
        private Clinical_Lab_Management_System_DBDataSet9TableAdapters.Test_DetailTableAdapter test_DetailTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tLoRangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tUpRangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRegDateDataGridViewTextBoxColumn;
        private Clinical_Lab_Management_System_DBDataSet10 clinical_Lab_Management_System_DBDataSet10;
        private System.Windows.Forms.BindingSource testDetailBindingSource2;
        private Clinical_Lab_Management_System_DBDataSet10TableAdapters.Test_DetailTableAdapter test_DetailTableAdapter2;
        private Clinical_Lab_Management_System_DBDataSet17 clinical_Lab_Management_System_DBDataSet17;
        private System.Windows.Forms.BindingSource testDetailBindingSource3;
        private Clinical_Lab_Management_System_DBDataSet17TableAdapters.Test_DetailTableAdapter test_DetailTableAdapter3;

    }
}