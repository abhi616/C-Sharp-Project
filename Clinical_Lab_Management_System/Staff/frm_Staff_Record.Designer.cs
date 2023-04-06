namespace Clinical_Lab_Management_System
{
    partial class frm_Staff_Record
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
            this.lbl_Staff_ID = new System.Windows.Forms.Label();
            this.dgv_Staff_Record = new System.Windows.Forms.DataGridView();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEducationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sMobNo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sShiftTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.staffDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinical_Lab_Management_System_DBDataSet1 = new Clinical_Lab_Management_System.Clinical_Lab_Management_System_DBDataSet1();
            this.lbl_Staff_Record = new System.Windows.Forms.Label();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.dtp_Time = new System.Windows.Forms.DateTimePicker();
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.staff_DetailTableAdapter = new Clinical_Lab_Management_System.Clinical_Lab_Management_System_DBDataSet1TableAdapters.Staff_DetailTableAdapter();
            this.lbl_size = new System.Windows.Forms.Label();
            this.lbl_Photograph = new System.Windows.Forms.Label();
            this.pb_Photograph = new System.Windows.Forms.PictureBox();
            this.tb_Staff_ID = new System.Windows.Forms.TextBox();
            this.tb_FullName = new System.Windows.Forms.TextBox();
            this.lbl_MobNo1 = new System.Windows.Forms.Label();
            this.tb_Mob_No1 = new System.Windows.Forms.TextBox();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Post = new System.Windows.Forms.Label();
            this.tb_Post = new System.Windows.Forms.TextBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.tb_Gender = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.lbl_Shift_Time = new System.Windows.Forms.Label();
            this.tb_Shift_Time = new System.Windows.Forms.TextBox();
            this.tb_AadharNo = new System.Windows.Forms.TextBox();
            this.lbl_AadharNo = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.tb_Mob_No2 = new System.Windows.Forms.TextBox();
            this.lbl_MobNo2 = new System.Windows.Forms.Label();
            this.clinical_Lab_Management_System_DBDataSet18 = new Clinical_Lab_Management_System.Clinical_Lab_Management_System_DBDataSet18();
            this.staffDetailBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.staff_DetailTableAdapter1 = new Clinical_Lab_Management_System.Clinical_Lab_Management_System_DBDataSet18TableAdapters.Staff_DetailTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Staff_Record)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinical_Lab_Management_System_DBDataSet1)).BeginInit();
            this.pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Photograph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinical_Lab_Management_System_DBDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDetailBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Staff_ID
            // 
            this.lbl_Staff_ID.AutoSize = true;
            this.lbl_Staff_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Staff_ID.Location = new System.Drawing.Point(465, 128);
            this.lbl_Staff_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Staff_ID.Name = "lbl_Staff_ID";
            this.lbl_Staff_ID.Size = new System.Drawing.Size(100, 31);
            this.lbl_Staff_ID.TabIndex = 0;
            this.lbl_Staff_ID.Text = "Staff ID";
            // 
            // dgv_Staff_Record
            // 
            this.dgv_Staff_Record.AllowUserToAddRows = false;
            this.dgv_Staff_Record.AllowUserToDeleteRows = false;
            this.dgv_Staff_Record.AutoGenerateColumns = false;
            this.dgv_Staff_Record.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Staff_Record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Staff_Record.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sIDDataGridViewTextBoxColumn,
            this.sFNameDataGridViewTextBoxColumn,
            this.sSurnameDataGridViewTextBoxColumn,
            this.sAgeDataGridViewTextBoxColumn,
            this.sGenderDataGridViewTextBoxColumn,
            this.sEducationDataGridViewTextBoxColumn,
            this.sPostDataGridViewTextBoxColumn,
            this.sMobNo1DataGridViewTextBoxColumn,
            this.sAddressDataGridViewTextBoxColumn,
            this.sShiftTimeDataGridViewTextBoxColumn,
            this.sImageDataGridViewImageColumn});
            this.dgv_Staff_Record.DataSource = this.staffDetailBindingSource1;
            this.dgv_Staff_Record.Location = new System.Drawing.Point(-11, 377);
            this.dgv_Staff_Record.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Staff_Record.Name = "dgv_Staff_Record";
            this.dgv_Staff_Record.ReadOnly = true;
            this.dgv_Staff_Record.Size = new System.Drawing.Size(1829, 539);
            this.dgv_Staff_Record.TabIndex = 5;
            // 
            // sIDDataGridViewTextBoxColumn
            // 
            this.sIDDataGridViewTextBoxColumn.DataPropertyName = "S_ID";
            this.sIDDataGridViewTextBoxColumn.HeaderText = "S_ID";
            this.sIDDataGridViewTextBoxColumn.Name = "sIDDataGridViewTextBoxColumn";
            this.sIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sFNameDataGridViewTextBoxColumn
            // 
            this.sFNameDataGridViewTextBoxColumn.DataPropertyName = "S_FName";
            this.sFNameDataGridViewTextBoxColumn.HeaderText = "S_FName";
            this.sFNameDataGridViewTextBoxColumn.Name = "sFNameDataGridViewTextBoxColumn";
            this.sFNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sSurnameDataGridViewTextBoxColumn
            // 
            this.sSurnameDataGridViewTextBoxColumn.DataPropertyName = "S_Surname";
            this.sSurnameDataGridViewTextBoxColumn.HeaderText = "S_Surname";
            this.sSurnameDataGridViewTextBoxColumn.Name = "sSurnameDataGridViewTextBoxColumn";
            this.sSurnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sAgeDataGridViewTextBoxColumn
            // 
            this.sAgeDataGridViewTextBoxColumn.DataPropertyName = "S_Age";
            this.sAgeDataGridViewTextBoxColumn.HeaderText = "S_Age";
            this.sAgeDataGridViewTextBoxColumn.Name = "sAgeDataGridViewTextBoxColumn";
            this.sAgeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sGenderDataGridViewTextBoxColumn
            // 
            this.sGenderDataGridViewTextBoxColumn.DataPropertyName = "S_Gender";
            this.sGenderDataGridViewTextBoxColumn.HeaderText = "S_Gender";
            this.sGenderDataGridViewTextBoxColumn.Name = "sGenderDataGridViewTextBoxColumn";
            this.sGenderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sEducationDataGridViewTextBoxColumn
            // 
            this.sEducationDataGridViewTextBoxColumn.DataPropertyName = "S_Education";
            this.sEducationDataGridViewTextBoxColumn.HeaderText = "S_Education";
            this.sEducationDataGridViewTextBoxColumn.Name = "sEducationDataGridViewTextBoxColumn";
            this.sEducationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sPostDataGridViewTextBoxColumn
            // 
            this.sPostDataGridViewTextBoxColumn.DataPropertyName = "S_Post";
            this.sPostDataGridViewTextBoxColumn.HeaderText = "S_Post";
            this.sPostDataGridViewTextBoxColumn.Name = "sPostDataGridViewTextBoxColumn";
            this.sPostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sMobNo1DataGridViewTextBoxColumn
            // 
            this.sMobNo1DataGridViewTextBoxColumn.DataPropertyName = "S_MobNo1";
            this.sMobNo1DataGridViewTextBoxColumn.HeaderText = "S_MobNo1";
            this.sMobNo1DataGridViewTextBoxColumn.Name = "sMobNo1DataGridViewTextBoxColumn";
            this.sMobNo1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sAddressDataGridViewTextBoxColumn
            // 
            this.sAddressDataGridViewTextBoxColumn.DataPropertyName = "S_Address";
            this.sAddressDataGridViewTextBoxColumn.HeaderText = "S_Address";
            this.sAddressDataGridViewTextBoxColumn.Name = "sAddressDataGridViewTextBoxColumn";
            this.sAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sShiftTimeDataGridViewTextBoxColumn
            // 
            this.sShiftTimeDataGridViewTextBoxColumn.DataPropertyName = "S_ShiftTime";
            this.sShiftTimeDataGridViewTextBoxColumn.HeaderText = "S_ShiftTime";
            this.sShiftTimeDataGridViewTextBoxColumn.Name = "sShiftTimeDataGridViewTextBoxColumn";
            this.sShiftTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sImageDataGridViewImageColumn
            // 
            this.sImageDataGridViewImageColumn.DataPropertyName = "S_Image";
            this.sImageDataGridViewImageColumn.HeaderText = "S_Image";
            this.sImageDataGridViewImageColumn.Name = "sImageDataGridViewImageColumn";
            this.sImageDataGridViewImageColumn.ReadOnly = true;
            // 
            // staffDetailBindingSource
            // 
            this.staffDetailBindingSource.DataMember = "Staff_Detail";
            this.staffDetailBindingSource.DataSource = this.clinical_Lab_Management_System_DBDataSet1;
            // 
            // clinical_Lab_Management_System_DBDataSet1
            // 
            this.clinical_Lab_Management_System_DBDataSet1.DataSetName = "Clinical_Lab_Management_System_DBDataSet1";
            this.clinical_Lab_Management_System_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_Staff_Record
            // 
            this.lbl_Staff_Record.AutoSize = true;
            this.lbl_Staff_Record.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Staff_Record.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Staff_Record.ForeColor = System.Drawing.Color.Gold;
            this.lbl_Staff_Record.Location = new System.Drawing.Point(740, 15);
            this.lbl_Staff_Record.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Staff_Record.Name = "lbl_Staff_Record";
            this.lbl_Staff_Record.Size = new System.Drawing.Size(282, 56);
            this.lbl_Staff_Record.TabIndex = 0;
            this.lbl_Staff_Record.Text = "Staff Record";
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_Header.Controls.Add(this.btn_Back);
            this.pnl_Header.Controls.Add(this.dtp_Date);
            this.pnl_Header.Controls.Add(this.dtp_Time);
            this.pnl_Header.Controls.Add(this.lbl_Staff_Record);
            this.pnl_Header.Location = new System.Drawing.Point(-11, 1);
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1835, 91);
            this.pnl_Header.TabIndex = 4;
            // 
            // btn_Back
            // 
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Back.Location = new System.Drawing.Point(64, 18);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(127, 50);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // dtp_Date
            // 
            this.dtp_Date.CustomFormat = "";
            this.dtp_Date.Enabled = false;
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(1460, 34);
            this.dtp_Date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(132, 22);
            this.dtp_Date.TabIndex = 9;
            this.dtp_Date.Value = new System.DateTime(2021, 10, 29, 12, 42, 13, 0);
            // 
            // dtp_Time
            // 
            this.dtp_Time.CustomFormat = "";
            this.dtp_Time.Enabled = false;
            this.dtp_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_Time.Location = new System.Drawing.Point(1616, 34);
            this.dtp_Time.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_Time.Name = "dtp_Time";
            this.dtp_Time.Size = new System.Drawing.Size(107, 22);
            this.dtp_Time.TabIndex = 9;
            this.dtp_Time.Value = new System.DateTime(2021, 10, 29, 12, 44, 8, 0);
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FullName.Location = new System.Drawing.Point(465, 170);
            this.lbl_FullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(81, 31);
            this.lbl_FullName.TabIndex = 1;
            this.lbl_FullName.Text = "Name";
            // 
            // staff_DetailTableAdapter
            // 
            this.staff_DetailTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_size
            // 
            this.lbl_size.AutoSize = true;
            this.lbl_size.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_size.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_size.ForeColor = System.Drawing.Color.Black;
            this.lbl_size.Location = new System.Drawing.Point(229, 225);
            this.lbl_size.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(125, 17);
            this.lbl_size.TabIndex = 43;
            this.lbl_size.Text = "(3.5cmX2.5cm)";
            // 
            // lbl_Photograph
            // 
            this.lbl_Photograph.AutoSize = true;
            this.lbl_Photograph.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_Photograph.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Photograph.ForeColor = System.Drawing.Color.Black;
            this.lbl_Photograph.Location = new System.Drawing.Point(244, 197);
            this.lbl_Photograph.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Photograph.Name = "lbl_Photograph";
            this.lbl_Photograph.Size = new System.Drawing.Size(98, 17);
            this.lbl_Photograph.TabIndex = 42;
            this.lbl_Photograph.Text = "Photograph";
            // 
            // pb_Photograph
            // 
            this.pb_Photograph.BackColor = System.Drawing.Color.DarkGray;
            this.pb_Photograph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Photograph.Location = new System.Drawing.Point(201, 126);
            this.pb_Photograph.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_Photograph.Name = "pb_Photograph";
            this.pb_Photograph.Size = new System.Drawing.Size(189, 201);
            this.pb_Photograph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Photograph.TabIndex = 44;
            this.pb_Photograph.TabStop = false;
            // 
            // tb_Staff_ID
            // 
            this.tb_Staff_ID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Staff_ID.Location = new System.Drawing.Point(679, 126);
            this.tb_Staff_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Staff_ID.Name = "tb_Staff_ID";
            this.tb_Staff_ID.Size = new System.Drawing.Size(101, 26);
            this.tb_Staff_ID.TabIndex = 1;
            // 
            // tb_FullName
            // 
            this.tb_FullName.Enabled = false;
            this.tb_FullName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_FullName.Location = new System.Drawing.Point(679, 170);
            this.tb_FullName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_FullName.Name = "tb_FullName";
            this.tb_FullName.Size = new System.Drawing.Size(349, 26);
            this.tb_FullName.TabIndex = 45;
            // 
            // lbl_MobNo1
            // 
            this.lbl_MobNo1.AutoSize = true;
            this.lbl_MobNo1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MobNo1.Location = new System.Drawing.Point(1152, 213);
            this.lbl_MobNo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MobNo1.Name = "lbl_MobNo1";
            this.lbl_MobNo1.Size = new System.Drawing.Size(156, 31);
            this.lbl_MobNo1.TabIndex = 24;
            this.lbl_MobNo1.Text = "Mobile No 1";
            // 
            // tb_Mob_No1
            // 
            this.tb_Mob_No1.Enabled = false;
            this.tb_Mob_No1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mob_No1.Location = new System.Drawing.Point(1365, 213);
            this.tb_Mob_No1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Mob_No1.Name = "tb_Mob_No1";
            this.tb_Mob_No1.Size = new System.Drawing.Size(195, 26);
            this.tb_Mob_No1.TabIndex = 45;
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.Location = new System.Drawing.Point(465, 254);
            this.lbl_DOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(65, 31);
            this.lbl_DOB.TabIndex = 19;
            this.lbl_DOB.Text = "DOB";
            // 
            // lbl_Post
            // 
            this.lbl_Post.AutoSize = true;
            this.lbl_Post.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Post.Location = new System.Drawing.Point(465, 297);
            this.lbl_Post.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Post.Name = "lbl_Post";
            this.lbl_Post.Size = new System.Drawing.Size(64, 31);
            this.lbl_Post.TabIndex = 0;
            this.lbl_Post.Text = "Post";
            // 
            // tb_Post
            // 
            this.tb_Post.Enabled = false;
            this.tb_Post.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Post.Location = new System.Drawing.Point(679, 300);
            this.tb_Post.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Post.Name = "tb_Post";
            this.tb_Post.Size = new System.Drawing.Size(195, 26);
            this.tb_Post.TabIndex = 45;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(465, 210);
            this.lbl_Gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(97, 31);
            this.lbl_Gender.TabIndex = 20;
            this.lbl_Gender.Text = "Gender";
            // 
            // tb_Gender
            // 
            this.tb_Gender.Enabled = false;
            this.tb_Gender.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Gender.Location = new System.Drawing.Point(679, 210);
            this.tb_Gender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Gender.Name = "tb_Gender";
            this.tb_Gender.Size = new System.Drawing.Size(195, 26);
            this.tb_Gender.TabIndex = 45;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(1152, 130);
            this.lbl_Address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(106, 31);
            this.lbl_Address.TabIndex = 0;
            this.lbl_Address.Text = "Address";
            // 
            // tb_Address
            // 
            this.tb_Address.Enabled = false;
            this.tb_Address.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(1365, 130);
            this.tb_Address.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(195, 26);
            this.tb_Address.TabIndex = 45;
            // 
            // lbl_Shift_Time
            // 
            this.lbl_Shift_Time.AutoSize = true;
            this.lbl_Shift_Time.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Shift_Time.Location = new System.Drawing.Point(1152, 171);
            this.lbl_Shift_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Shift_Time.Name = "lbl_Shift_Time";
            this.lbl_Shift_Time.Size = new System.Drawing.Size(129, 31);
            this.lbl_Shift_Time.TabIndex = 25;
            this.lbl_Shift_Time.Text = "Shift Time";
            // 
            // tb_Shift_Time
            // 
            this.tb_Shift_Time.Enabled = false;
            this.tb_Shift_Time.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Shift_Time.Location = new System.Drawing.Point(1365, 171);
            this.tb_Shift_Time.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Shift_Time.Name = "tb_Shift_Time";
            this.tb_Shift_Time.Size = new System.Drawing.Size(195, 26);
            this.tb_Shift_Time.TabIndex = 45;
            // 
            // tb_AadharNo
            // 
            this.tb_AadharNo.Enabled = false;
            this.tb_AadharNo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_AadharNo.Location = new System.Drawing.Point(1365, 297);
            this.tb_AadharNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_AadharNo.Name = "tb_AadharNo";
            this.tb_AadharNo.Size = new System.Drawing.Size(195, 26);
            this.tb_AadharNo.TabIndex = 45;
            // 
            // lbl_AadharNo
            // 
            this.lbl_AadharNo.AutoSize = true;
            this.lbl_AadharNo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AadharNo.Location = new System.Drawing.Point(1152, 297);
            this.lbl_AadharNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AadharNo.Name = "lbl_AadharNo";
            this.lbl_AadharNo.Size = new System.Drawing.Size(137, 31);
            this.lbl_AadharNo.TabIndex = 22;
            this.lbl_AadharNo.Text = "Aadhar No";
            // 
            // btn_Search
            // 
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Search.Location = new System.Drawing.Point(793, 118);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(119, 42);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Enabled = false;
            this.dtp_DOB.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DOB.Location = new System.Drawing.Point(679, 254);
            this.dtp_DOB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(195, 26);
            this.dtp_DOB.TabIndex = 46;
            // 
            // btn_Clear
            // 
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Clear.Location = new System.Drawing.Point(911, 118);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(119, 42);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // tb_Mob_No2
            // 
            this.tb_Mob_No2.Enabled = false;
            this.tb_Mob_No2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mob_No2.Location = new System.Drawing.Point(1365, 254);
            this.tb_Mob_No2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Mob_No2.Name = "tb_Mob_No2";
            this.tb_Mob_No2.Size = new System.Drawing.Size(195, 26);
            this.tb_Mob_No2.TabIndex = 45;
            // 
            // lbl_MobNo2
            // 
            this.lbl_MobNo2.AutoSize = true;
            this.lbl_MobNo2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MobNo2.Location = new System.Drawing.Point(1155, 251);
            this.lbl_MobNo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MobNo2.Name = "lbl_MobNo2";
            this.lbl_MobNo2.Size = new System.Drawing.Size(156, 31);
            this.lbl_MobNo2.TabIndex = 23;
            this.lbl_MobNo2.Text = "Mobile No 2";
            // 
            // clinical_Lab_Management_System_DBDataSet18
            // 
            this.clinical_Lab_Management_System_DBDataSet18.DataSetName = "Clinical_Lab_Management_System_DBDataSet18";
            this.clinical_Lab_Management_System_DBDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffDetailBindingSource1
            // 
            this.staffDetailBindingSource1.DataMember = "Staff_Detail";
            this.staffDetailBindingSource1.DataSource = this.clinical_Lab_Management_System_DBDataSet18;
            // 
            // staff_DetailTableAdapter1
            // 
            this.staff_DetailTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_Staff_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1796, 714);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Shift_Time);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.tb_Gender);
            this.Controls.Add(this.tb_Post);
            this.Controls.Add(this.tb_AadharNo);
            this.Controls.Add(this.tb_Mob_No2);
            this.Controls.Add(this.tb_Mob_No1);
            this.Controls.Add(this.lbl_Shift_Time);
            this.Controls.Add(this.tb_FullName);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.tb_Staff_ID);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_size);
            this.Controls.Add(this.lbl_Post);
            this.Controls.Add(this.lbl_Photograph);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.pb_Photograph);
            this.Controls.Add(this.lbl_AadharNo);
            this.Controls.Add(this.lbl_MobNo2);
            this.Controls.Add(this.lbl_MobNo1);
            this.Controls.Add(this.lbl_FullName);
            this.Controls.Add(this.lbl_Staff_ID);
            this.Controls.Add(this.dgv_Staff_Record);
            this.Controls.Add(this.pnl_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_Staff_Record";
            this.Text = "frm_Staff_Record";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Staff_Record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Staff_Record)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinical_Lab_Management_System_DBDataSet1)).EndInit();
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Photograph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinical_Lab_Management_System_DBDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDetailBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Staff_ID;
        private System.Windows.Forms.DataGridView dgv_Staff_Record;
        private System.Windows.Forms.Label lbl_Staff_Record;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.DateTimePicker dtp_Time;
        private System.Windows.Forms.Label lbl_FullName;
        private Clinical_Lab_Management_System_DBDataSet1 clinical_Lab_Management_System_DBDataSet1;
        private System.Windows.Forms.BindingSource staffDetailBindingSource;
        private Clinical_Lab_Management_System_DBDataSet1TableAdapters.Staff_DetailTableAdapter staff_DetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEducationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sMobNo1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sShiftTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn sImageDataGridViewImageColumn;
        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.Label lbl_Photograph;
        private System.Windows.Forms.PictureBox pb_Photograph;
        private System.Windows.Forms.TextBox tb_Staff_ID;
        private System.Windows.Forms.TextBox tb_FullName;
        private System.Windows.Forms.Label lbl_MobNo1;
        private System.Windows.Forms.TextBox tb_Mob_No1;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Post;
        private System.Windows.Forms.TextBox tb_Post;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.TextBox tb_Gender;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.Label lbl_Shift_Time;
        private System.Windows.Forms.TextBox tb_Shift_Time;
        private System.Windows.Forms.TextBox tb_AadharNo;
        private System.Windows.Forms.Label lbl_AadharNo;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TextBox tb_Mob_No2;
        private System.Windows.Forms.Label lbl_MobNo2;
        private Clinical_Lab_Management_System_DBDataSet18 clinical_Lab_Management_System_DBDataSet18;
        private System.Windows.Forms.BindingSource staffDetailBindingSource1;
        private Clinical_Lab_Management_System_DBDataSet18TableAdapters.Staff_DetailTableAdapter staff_DetailTableAdapter1;

    }
}