namespace Clinical_Lab_Management_System
{
    partial class frm_Doctors_Record
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
            this.lbl_Doctors_Record = new System.Windows.Forms.Label();
            this.dgv_Doctors_Record = new System.Windows.Forms.DataGridView();
            this.dIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDegreeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dMobNo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dMobNo2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.doctorDetailBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clinical_Lab_Management_System_DBDataSet16 = new Clinical_Lab_Management_System.Clinical_Lab_Management_System_DBDataSet16();
            this.doctorDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinical_Lab_Management_System_DBDataSet4 = new Clinical_Lab_Management_System.Clinical_Lab_Management_System_DBDataSet4();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.dtp_Time = new System.Windows.Forms.DateTimePicker();
            this.doctor_DetailTableAdapter = new Clinical_Lab_Management_System.Clinical_Lab_Management_System_DBDataSet4TableAdapters.Doctor_DetailTableAdapter();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.btn_Search = new System.Windows.Forms.Button();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_Gender = new System.Windows.Forms.TextBox();
            this.tb_AadharNo = new System.Windows.Forms.TextBox();
            this.tb_Mob_No2 = new System.Windows.Forms.TextBox();
            this.tb_Mob_No1 = new System.Windows.Forms.TextBox();
            this.tb_FullName = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.tb_Doctor_ID = new System.Windows.Forms.TextBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_size = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_AadharNo = new System.Windows.Forms.Label();
            this.lbl_MobNo2 = new System.Windows.Forms.Label();
            this.lbl_MobNo1 = new System.Windows.Forms.Label();
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.lbl_Doctor_ID = new System.Windows.Forms.Label();
            this.lbl_Photograph = new System.Windows.Forms.Label();
            this.lbl_EmailID = new System.Windows.Forms.Label();
            this.tb_EmailID = new System.Windows.Forms.TextBox();
            this.lbl_Degree = new System.Windows.Forms.Label();
            this.tb_Degree = new System.Windows.Forms.TextBox();
            this.pb_Photograph = new System.Windows.Forms.PictureBox();
            this.doctor_DetailTableAdapter1 = new Clinical_Lab_Management_System.Clinical_Lab_Management_System_DBDataSet16TableAdapters.Doctor_DetailTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Doctors_Record)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDetailBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinical_Lab_Management_System_DBDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinical_Lab_Management_System_DBDataSet4)).BeginInit();
            this.pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Photograph)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Doctors_Record
            // 
            this.lbl_Doctors_Record.AutoSize = true;
            this.lbl_Doctors_Record.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Doctors_Record.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Doctors_Record.ForeColor = System.Drawing.Color.Red;
            this.lbl_Doctors_Record.Location = new System.Drawing.Point(725, 23);
            this.lbl_Doctors_Record.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Doctors_Record.Name = "lbl_Doctors_Record";
            this.lbl_Doctors_Record.Size = new System.Drawing.Size(343, 56);
            this.lbl_Doctors_Record.TabIndex = 0;
            this.lbl_Doctors_Record.Text = "Doctors Record";
            // 
            // dgv_Doctors_Record
            // 
            this.dgv_Doctors_Record.AllowUserToAddRows = false;
            this.dgv_Doctors_Record.AllowUserToDeleteRows = false;
            this.dgv_Doctors_Record.AutoGenerateColumns = false;
            this.dgv_Doctors_Record.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Doctors_Record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Doctors_Record.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dIDDataGridViewTextBoxColumn,
            this.dFullNameDataGridViewTextBoxColumn,
            this.dDOBDataGridViewTextBoxColumn,
            this.dGenderDataGridViewTextBoxColumn,
            this.dDegreeDataGridViewTextBoxColumn,
            this.dMobNo1DataGridViewTextBoxColumn,
            this.dMobNo2DataGridViewTextBoxColumn,
            this.dAddressDataGridViewTextBoxColumn,
            this.dImageDataGridViewImageColumn});
            this.dgv_Doctors_Record.DataSource = this.doctorDetailBindingSource1;
            this.dgv_Doctors_Record.Location = new System.Drawing.Point(-3, 380);
            this.dgv_Doctors_Record.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Doctors_Record.Name = "dgv_Doctors_Record";
            this.dgv_Doctors_Record.ReadOnly = true;
            this.dgv_Doctors_Record.Size = new System.Drawing.Size(1844, 539);
            this.dgv_Doctors_Record.TabIndex = 1;
            // 
            // dIDDataGridViewTextBoxColumn
            // 
            this.dIDDataGridViewTextBoxColumn.DataPropertyName = "D_ID";
            this.dIDDataGridViewTextBoxColumn.HeaderText = "D_ID";
            this.dIDDataGridViewTextBoxColumn.Name = "dIDDataGridViewTextBoxColumn";
            this.dIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dFullNameDataGridViewTextBoxColumn
            // 
            this.dFullNameDataGridViewTextBoxColumn.DataPropertyName = "D_FullName";
            this.dFullNameDataGridViewTextBoxColumn.HeaderText = "D_FullName";
            this.dFullNameDataGridViewTextBoxColumn.Name = "dFullNameDataGridViewTextBoxColumn";
            this.dFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dDOBDataGridViewTextBoxColumn
            // 
            this.dDOBDataGridViewTextBoxColumn.DataPropertyName = "D_DOB";
            this.dDOBDataGridViewTextBoxColumn.HeaderText = "D_DOB";
            this.dDOBDataGridViewTextBoxColumn.Name = "dDOBDataGridViewTextBoxColumn";
            this.dDOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dGenderDataGridViewTextBoxColumn
            // 
            this.dGenderDataGridViewTextBoxColumn.DataPropertyName = "D_Gender";
            this.dGenderDataGridViewTextBoxColumn.HeaderText = "D_Gender";
            this.dGenderDataGridViewTextBoxColumn.Name = "dGenderDataGridViewTextBoxColumn";
            this.dGenderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dDegreeDataGridViewTextBoxColumn
            // 
            this.dDegreeDataGridViewTextBoxColumn.DataPropertyName = "D_Degree";
            this.dDegreeDataGridViewTextBoxColumn.HeaderText = "D_Degree";
            this.dDegreeDataGridViewTextBoxColumn.Name = "dDegreeDataGridViewTextBoxColumn";
            this.dDegreeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dMobNo1DataGridViewTextBoxColumn
            // 
            this.dMobNo1DataGridViewTextBoxColumn.DataPropertyName = "D_MobNo1";
            this.dMobNo1DataGridViewTextBoxColumn.HeaderText = "D_MobNo1";
            this.dMobNo1DataGridViewTextBoxColumn.Name = "dMobNo1DataGridViewTextBoxColumn";
            this.dMobNo1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dMobNo2DataGridViewTextBoxColumn
            // 
            this.dMobNo2DataGridViewTextBoxColumn.DataPropertyName = "D_MobNo2";
            this.dMobNo2DataGridViewTextBoxColumn.HeaderText = "D_MobNo2";
            this.dMobNo2DataGridViewTextBoxColumn.Name = "dMobNo2DataGridViewTextBoxColumn";
            this.dMobNo2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dAddressDataGridViewTextBoxColumn
            // 
            this.dAddressDataGridViewTextBoxColumn.DataPropertyName = "D_Address";
            this.dAddressDataGridViewTextBoxColumn.HeaderText = "D_Address";
            this.dAddressDataGridViewTextBoxColumn.Name = "dAddressDataGridViewTextBoxColumn";
            this.dAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dImageDataGridViewImageColumn
            // 
            this.dImageDataGridViewImageColumn.DataPropertyName = "D_Image";
            this.dImageDataGridViewImageColumn.HeaderText = "D_Image";
            this.dImageDataGridViewImageColumn.Name = "dImageDataGridViewImageColumn";
            this.dImageDataGridViewImageColumn.ReadOnly = true;
            // 
            // doctorDetailBindingSource1
            // 
            this.doctorDetailBindingSource1.DataMember = "Doctor_Detail";
            this.doctorDetailBindingSource1.DataSource = this.clinical_Lab_Management_System_DBDataSet16;
            // 
            // clinical_Lab_Management_System_DBDataSet16
            // 
            this.clinical_Lab_Management_System_DBDataSet16.DataSetName = "Clinical_Lab_Management_System_DBDataSet16";
            this.clinical_Lab_Management_System_DBDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorDetailBindingSource
            // 
            this.doctorDetailBindingSource.DataMember = "Doctor_Detail";
            this.doctorDetailBindingSource.DataSource = this.clinical_Lab_Management_System_DBDataSet4;
            // 
            // clinical_Lab_Management_System_DBDataSet4
            // 
            this.clinical_Lab_Management_System_DBDataSet4.DataSetName = "Clinical_Lab_Management_System_DBDataSet4";
            this.clinical_Lab_Management_System_DBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_Header.Controls.Add(this.btn_Back);
            this.pnl_Header.Controls.Add(this.dtp_Date);
            this.pnl_Header.Controls.Add(this.dtp_Time);
            this.pnl_Header.Location = new System.Drawing.Point(-3, 1);
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(2059, 91);
            this.pnl_Header.TabIndex = 27;
            // 
            // btn_Back
            // 
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Back.Location = new System.Drawing.Point(64, 18);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(127, 50);
            this.btn_Back.TabIndex = 22;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // dtp_Date
            // 
            this.dtp_Date.CustomFormat = "";
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(1460, 34);
            this.dtp_Date.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(132, 22);
            this.dtp_Date.TabIndex = 9;
            this.dtp_Date.Value = new System.DateTime(2021, 10, 29, 12, 42, 13, 0);
            // 
            // dtp_Time
            // 
            this.dtp_Time.CustomFormat = "";
            this.dtp_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_Time.Location = new System.Drawing.Point(1616, 34);
            this.dtp_Time.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_Time.Name = "dtp_Time";
            this.dtp_Time.Size = new System.Drawing.Size(107, 22);
            this.dtp_Time.TabIndex = 9;
            this.dtp_Time.Value = new System.DateTime(2021, 10, 29, 12, 44, 8, 0);
            // 
            // doctor_DetailTableAdapter
            // 
            this.doctor_DetailTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Clear.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Clear.Location = new System.Drawing.Point(909, 118);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(119, 42);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Enabled = false;
            this.dtp_DOB.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DOB.Location = new System.Drawing.Point(672, 256);
            this.dtp_DOB.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(195, 26);
            this.dtp_DOB.TabIndex = 70;
            // 
            // btn_Search
            // 
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Search.Location = new System.Drawing.Point(785, 118);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(116, 42);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // tb_Address
            // 
            this.tb_Address.Enabled = false;
            this.tb_Address.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(1359, 128);
            this.tb_Address.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(195, 26);
            this.tb_Address.TabIndex = 68;
            // 
            // tb_Gender
            // 
            this.tb_Gender.Enabled = false;
            this.tb_Gender.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Gender.Location = new System.Drawing.Point(672, 213);
            this.tb_Gender.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Gender.Name = "tb_Gender";
            this.tb_Gender.Size = new System.Drawing.Size(195, 26);
            this.tb_Gender.TabIndex = 69;
            // 
            // tb_AadharNo
            // 
            this.tb_AadharNo.Enabled = false;
            this.tb_AadharNo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_AadharNo.Location = new System.Drawing.Point(1359, 254);
            this.tb_AadharNo.Margin = new System.Windows.Forms.Padding(4);
            this.tb_AadharNo.Name = "tb_AadharNo";
            this.tb_AadharNo.Size = new System.Drawing.Size(195, 26);
            this.tb_AadharNo.TabIndex = 67;
            // 
            // tb_Mob_No2
            // 
            this.tb_Mob_No2.Enabled = false;
            this.tb_Mob_No2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mob_No2.Location = new System.Drawing.Point(1359, 210);
            this.tb_Mob_No2.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Mob_No2.Name = "tb_Mob_No2";
            this.tb_Mob_No2.Size = new System.Drawing.Size(195, 26);
            this.tb_Mob_No2.TabIndex = 66;
            // 
            // tb_Mob_No1
            // 
            this.tb_Mob_No1.Enabled = false;
            this.tb_Mob_No1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mob_No1.Location = new System.Drawing.Point(1359, 170);
            this.tb_Mob_No1.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Mob_No1.Name = "tb_Mob_No1";
            this.tb_Mob_No1.Size = new System.Drawing.Size(195, 26);
            this.tb_Mob_No1.TabIndex = 65;
            // 
            // tb_FullName
            // 
            this.tb_FullName.Enabled = false;
            this.tb_FullName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_FullName.Location = new System.Drawing.Point(672, 172);
            this.tb_FullName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_FullName.Name = "tb_FullName";
            this.tb_FullName.Size = new System.Drawing.Size(349, 26);
            this.tb_FullName.TabIndex = 62;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(1145, 128);
            this.lbl_Address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(106, 31);
            this.lbl_Address.TabIndex = 48;
            this.lbl_Address.Text = "Address";
            // 
            // tb_Doctor_ID
            // 
            this.tb_Doctor_ID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Doctor_ID.Location = new System.Drawing.Point(672, 128);
            this.tb_Doctor_ID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Doctor_ID.Name = "tb_Doctor_ID";
            this.tb_Doctor_ID.Size = new System.Drawing.Size(101, 26);
            this.tb_Doctor_ID.TabIndex = 1;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(459, 213);
            this.lbl_Gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(97, 31);
            this.lbl_Gender.TabIndex = 55;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_size
            // 
            this.lbl_size.AutoSize = true;
            this.lbl_size.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_size.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_size.ForeColor = System.Drawing.Color.Black;
            this.lbl_size.Location = new System.Drawing.Point(223, 228);
            this.lbl_size.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_size.Name = "lbl_size";
            this.lbl_size.Size = new System.Drawing.Size(125, 17);
            this.lbl_size.TabIndex = 60;
            this.lbl_size.Text = "(3.5cmX2.5cm)";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.Location = new System.Drawing.Point(459, 256);
            this.lbl_DOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(65, 31);
            this.lbl_DOB.TabIndex = 54;
            this.lbl_DOB.Text = "DOB";
            // 
            // lbl_AadharNo
            // 
            this.lbl_AadharNo.AutoSize = true;
            this.lbl_AadharNo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AadharNo.Location = new System.Drawing.Point(1145, 254);
            this.lbl_AadharNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AadharNo.Name = "lbl_AadharNo";
            this.lbl_AadharNo.Size = new System.Drawing.Size(137, 31);
            this.lbl_AadharNo.TabIndex = 56;
            this.lbl_AadharNo.Text = "Aadhar No";
            // 
            // lbl_MobNo2
            // 
            this.lbl_MobNo2.AutoSize = true;
            this.lbl_MobNo2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MobNo2.Location = new System.Drawing.Point(1148, 208);
            this.lbl_MobNo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MobNo2.Name = "lbl_MobNo2";
            this.lbl_MobNo2.Size = new System.Drawing.Size(156, 31);
            this.lbl_MobNo2.TabIndex = 57;
            this.lbl_MobNo2.Text = "Mobile No 2";
            // 
            // lbl_MobNo1
            // 
            this.lbl_MobNo1.AutoSize = true;
            this.lbl_MobNo1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MobNo1.Location = new System.Drawing.Point(1145, 170);
            this.lbl_MobNo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MobNo1.Name = "lbl_MobNo1";
            this.lbl_MobNo1.Size = new System.Drawing.Size(156, 31);
            this.lbl_MobNo1.TabIndex = 58;
            this.lbl_MobNo1.Text = "Mobile No 1";
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FullName.Location = new System.Drawing.Point(459, 172);
            this.lbl_FullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(81, 31);
            this.lbl_FullName.TabIndex = 51;
            this.lbl_FullName.Text = "Name";
            // 
            // lbl_Doctor_ID
            // 
            this.lbl_Doctor_ID.AutoSize = true;
            this.lbl_Doctor_ID.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Doctor_ID.Location = new System.Drawing.Point(459, 130);
            this.lbl_Doctor_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Doctor_ID.Name = "lbl_Doctor_ID";
            this.lbl_Doctor_ID.Size = new System.Drawing.Size(126, 31);
            this.lbl_Doctor_ID.TabIndex = 49;
            this.lbl_Doctor_ID.Text = "Doctor ID";
            // 
            // lbl_Photograph
            // 
            this.lbl_Photograph.AutoSize = true;
            this.lbl_Photograph.BackColor = System.Drawing.Color.DarkGray;
            this.lbl_Photograph.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Photograph.ForeColor = System.Drawing.Color.Black;
            this.lbl_Photograph.Location = new System.Drawing.Point(239, 196);
            this.lbl_Photograph.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Photograph.Name = "lbl_Photograph";
            this.lbl_Photograph.Size = new System.Drawing.Size(98, 17);
            this.lbl_Photograph.TabIndex = 71;
            this.lbl_Photograph.Text = "Photograph";
            // 
            // lbl_EmailID
            // 
            this.lbl_EmailID.AutoSize = true;
            this.lbl_EmailID.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmailID.Location = new System.Drawing.Point(1145, 299);
            this.lbl_EmailID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_EmailID.Name = "lbl_EmailID";
            this.lbl_EmailID.Size = new System.Drawing.Size(102, 31);
            this.lbl_EmailID.TabIndex = 56;
            this.lbl_EmailID.Text = "EmailID";
            // 
            // tb_EmailID
            // 
            this.tb_EmailID.Enabled = false;
            this.tb_EmailID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_EmailID.Location = new System.Drawing.Point(1359, 299);
            this.tb_EmailID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_EmailID.Name = "tb_EmailID";
            this.tb_EmailID.Size = new System.Drawing.Size(340, 26);
            this.tb_EmailID.TabIndex = 67;
            // 
            // lbl_Degree
            // 
            this.lbl_Degree.AutoSize = true;
            this.lbl_Degree.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Degree.Location = new System.Drawing.Point(459, 300);
            this.lbl_Degree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Degree.Name = "lbl_Degree";
            this.lbl_Degree.Size = new System.Drawing.Size(96, 31);
            this.lbl_Degree.TabIndex = 55;
            this.lbl_Degree.Text = "Degree";
            // 
            // tb_Degree
            // 
            this.tb_Degree.Enabled = false;
            this.tb_Degree.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Degree.Location = new System.Drawing.Point(672, 300);
            this.tb_Degree.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Degree.Name = "tb_Degree";
            this.tb_Degree.Size = new System.Drawing.Size(195, 26);
            this.tb_Degree.TabIndex = 69;
            // 
            // pb_Photograph
            // 
            this.pb_Photograph.BackColor = System.Drawing.Color.DarkGray;
            this.pb_Photograph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Photograph.Location = new System.Drawing.Point(189, 128);
            this.pb_Photograph.Margin = new System.Windows.Forms.Padding(4);
            this.pb_Photograph.Name = "pb_Photograph";
            this.pb_Photograph.Size = new System.Drawing.Size(194, 211);
            this.pb_Photograph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Photograph.TabIndex = 61;
            this.pb_Photograph.TabStop = false;
            // 
            // doctor_DetailTableAdapter1
            // 
            this.doctor_DetailTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_Doctors_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1936, 922);
            this.Controls.Add(this.lbl_Photograph);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.tb_Degree);
            this.Controls.Add(this.tb_Gender);
            this.Controls.Add(this.tb_EmailID);
            this.Controls.Add(this.tb_AadharNo);
            this.Controls.Add(this.tb_Mob_No2);
            this.Controls.Add(this.tb_Mob_No1);
            this.Controls.Add(this.tb_FullName);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_Degree);
            this.Controls.Add(this.tb_Doctor_ID);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_size);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_EmailID);
            this.Controls.Add(this.pb_Photograph);
            this.Controls.Add(this.lbl_AadharNo);
            this.Controls.Add(this.lbl_MobNo2);
            this.Controls.Add(this.lbl_MobNo1);
            this.Controls.Add(this.lbl_FullName);
            this.Controls.Add(this.lbl_Doctor_ID);
            this.Controls.Add(this.dgv_Doctors_Record);
            this.Controls.Add(this.lbl_Doctors_Record);
            this.Controls.Add(this.pnl_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(77, 439);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Doctors_Record";
            this.Text = "All Doctors History";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Doctors_Record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Doctors_Record)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDetailBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinical_Lab_Management_System_DBDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinical_Lab_Management_System_DBDataSet4)).EndInit();
            this.pnl_Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Photograph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Doctors_Record;
        private System.Windows.Forms.DataGridView dgv_Doctors_Record;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.DateTimePicker dtp_Time;
        
        private Clinical_Lab_Management_System_DBDataSet4 clinical_Lab_Management_System_DBDataSet4;
        private System.Windows.Forms.BindingSource doctorDetailBindingSource;
        private Clinical_Lab_Management_System_DBDataSet4TableAdapters.Doctor_DetailTableAdapter doctor_DetailTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDegreeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dMobNo1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dMobNo2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn dImageDataGridViewImageColumn;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.TextBox tb_Gender;
        private System.Windows.Forms.TextBox tb_AadharNo;
        private System.Windows.Forms.TextBox tb_Mob_No2;
        private System.Windows.Forms.TextBox tb_Mob_No1;
        private System.Windows.Forms.TextBox tb_FullName;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox tb_Doctor_ID;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_size;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.PictureBox pb_Photograph;
        private System.Windows.Forms.Label lbl_AadharNo;
        private System.Windows.Forms.Label lbl_MobNo2;
        private System.Windows.Forms.Label lbl_MobNo1;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.Label lbl_Doctor_ID;
        private System.Windows.Forms.Label lbl_Photograph;
        private System.Windows.Forms.Label lbl_EmailID;
        private System.Windows.Forms.TextBox tb_EmailID;
        private System.Windows.Forms.Label lbl_Degree;
        private System.Windows.Forms.TextBox tb_Degree;
        private Clinical_Lab_Management_System_DBDataSet16 clinical_Lab_Management_System_DBDataSet16;
        private System.Windows.Forms.BindingSource doctorDetailBindingSource1;
        private Clinical_Lab_Management_System_DBDataSet16TableAdapters.Doctor_DetailTableAdapter doctor_DetailTableAdapter1;
    }
}