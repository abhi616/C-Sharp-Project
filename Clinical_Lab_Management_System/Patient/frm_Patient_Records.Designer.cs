namespace Clinical_Lab_Management_System
{
    partial class frm_Patient_Records
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
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lbl_Patient_Records = new System.Windows.Forms.Label();
            this.dgv_PatientRecord = new System.Windows.Forms.DataGridView();
            this.patientDetailBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.clinical_Lab_Management_System_DBDataSet15 = new Clinical_Lab_Management_System.Clinical_Lab_Management_System_DBDataSet15();
            this.patientDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinical_Lab_Management_System_DBDataSet13 = new Clinical_Lab_Management_System.Clinical_Lab_Management_System_DBDataSet13();
            this.patient_DetailTableAdapter = new Clinical_Lab_Management_System.Clinical_Lab_Management_System_DBDataSet13TableAdapters.Patient_DetailTableAdapter();
            this.clinical_Lab_Management_System_DBDataSet14 = new Clinical_Lab_Management_System.Clinical_Lab_Management_System_DBDataSet14();
            this.patientDetailBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patient_DetailTableAdapter1 = new Clinical_Lab_Management_System.Clinical_Lab_Management_System_DBDataSet14TableAdapters.Patient_DetailTableAdapter();
            this.patient_DetailTableAdapter2 = new Clinical_Lab_Management_System.Clinical_Lab_Management_System_DBDataSet15TableAdapters.Patient_DetailTableAdapter();
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRefByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMobNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAadhaarNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PatientRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinical_Lab_Management_System_DBDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinical_Lab_Management_System_DBDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinical_Lab_Management_System_DBDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_Header.Controls.Add(this.btn_Back);
            this.pnl_Header.Controls.Add(this.dateTimePicker1);
            this.pnl_Header.Controls.Add(this.dateTimePicker2);
            this.pnl_Header.Controls.Add(this.lbl_Patient_Records);
            this.pnl_Header.Location = new System.Drawing.Point(-3, 0);
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(2059, 91);
            this.pnl_Header.TabIndex = 27;
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(64, 18);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(127, 50);
            this.btn_Back.TabIndex = 22;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(1460, 34);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 22);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2021, 10, 29, 12, 42, 13, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(1616, 34);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(107, 22);
            this.dateTimePicker2.TabIndex = 9;
            this.dateTimePicker2.Value = new System.DateTime(2021, 10, 29, 12, 44, 8, 0);
            // 
            // lbl_Patient_Records
            // 
            this.lbl_Patient_Records.AutoSize = true;
            this.lbl_Patient_Records.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Patient_Records.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Patient_Records.ForeColor = System.Drawing.Color.Red;
            this.lbl_Patient_Records.Location = new System.Drawing.Point(720, 18);
            this.lbl_Patient_Records.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Patient_Records.Name = "lbl_Patient_Records";
            this.lbl_Patient_Records.Size = new System.Drawing.Size(319, 51);
            this.lbl_Patient_Records.TabIndex = 0;
            this.lbl_Patient_Records.Text = "Patient Records";
            // 
            // dgv_PatientRecord
            // 
            this.dgv_PatientRecord.AllowUserToAddRows = false;
            this.dgv_PatientRecord.AllowUserToDeleteRows = false;
            this.dgv_PatientRecord.AutoGenerateColumns = false;
            this.dgv_PatientRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PatientRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PatientRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pIDDataGridViewTextBoxColumn,
            this.pFullNameDataGridViewTextBoxColumn,
            this.P_Email,
            this.pDOBDataGridViewTextBoxColumn,
            this.pAgeDataGridViewTextBoxColumn,
            this.pRefByDataGridViewTextBoxColumn,
            this.pMobNoDataGridViewTextBoxColumn,
            this.pAadhaarNoDataGridViewTextBoxColumn,
            this.pAddressDataGridViewTextBoxColumn,
            this.regDateDataGridViewTextBoxColumn});
            this.dgv_PatientRecord.DataSource = this.patientDetailBindingSource2;
            this.dgv_PatientRecord.Location = new System.Drawing.Point(-3, 91);
            this.dgv_PatientRecord.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_PatientRecord.Name = "dgv_PatientRecord";
            this.dgv_PatientRecord.ReadOnly = true;
            this.dgv_PatientRecord.Size = new System.Drawing.Size(1832, 832);
            this.dgv_PatientRecord.TabIndex = 28;
            // 
            // patientDetailBindingSource2
            // 
            this.patientDetailBindingSource2.DataMember = "Patient_Detail";
            this.patientDetailBindingSource2.DataSource = this.clinical_Lab_Management_System_DBDataSet15;
            // 
            // clinical_Lab_Management_System_DBDataSet15
            // 
            this.clinical_Lab_Management_System_DBDataSet15.DataSetName = "Clinical_Lab_Management_System_DBDataSet15";
            this.clinical_Lab_Management_System_DBDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientDetailBindingSource
            // 
            this.patientDetailBindingSource.DataMember = "Patient_Detail";
            this.patientDetailBindingSource.DataSource = this.clinical_Lab_Management_System_DBDataSet13;
            // 
            // clinical_Lab_Management_System_DBDataSet13
            // 
            this.clinical_Lab_Management_System_DBDataSet13.DataSetName = "Clinical_Lab_Management_System_DBDataSet13";
            this.clinical_Lab_Management_System_DBDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patient_DetailTableAdapter
            // 
            this.patient_DetailTableAdapter.ClearBeforeFill = true;
            // 
            // clinical_Lab_Management_System_DBDataSet14
            // 
            this.clinical_Lab_Management_System_DBDataSet14.DataSetName = "Clinical_Lab_Management_System_DBDataSet14";
            this.clinical_Lab_Management_System_DBDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientDetailBindingSource1
            // 
            this.patientDetailBindingSource1.DataMember = "Patient_Detail";
            this.patientDetailBindingSource1.DataSource = this.clinical_Lab_Management_System_DBDataSet14;
            // 
            // patient_DetailTableAdapter1
            // 
            this.patient_DetailTableAdapter1.ClearBeforeFill = true;
            // 
            // patient_DetailTableAdapter2
            // 
            this.patient_DetailTableAdapter2.ClearBeforeFill = true;
            // 
            // pIDDataGridViewTextBoxColumn
            // 
            this.pIDDataGridViewTextBoxColumn.DataPropertyName = "P_ID";
            this.pIDDataGridViewTextBoxColumn.HeaderText = " ID";
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            this.pIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pFullNameDataGridViewTextBoxColumn
            // 
            this.pFullNameDataGridViewTextBoxColumn.DataPropertyName = "P_FullName";
            this.pFullNameDataGridViewTextBoxColumn.HeaderText = "P_FullName";
            this.pFullNameDataGridViewTextBoxColumn.Name = "pFullNameDataGridViewTextBoxColumn";
            this.pFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // P_Email
            // 
            this.P_Email.DataPropertyName = "P_Email";
            this.P_Email.HeaderText = "Email";
            this.P_Email.Name = "P_Email";
            this.P_Email.ReadOnly = true;
            // 
            // pDOBDataGridViewTextBoxColumn
            // 
            this.pDOBDataGridViewTextBoxColumn.DataPropertyName = "P_DOB";
            this.pDOBDataGridViewTextBoxColumn.HeaderText = "P_DOB";
            this.pDOBDataGridViewTextBoxColumn.Name = "pDOBDataGridViewTextBoxColumn";
            this.pDOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pAgeDataGridViewTextBoxColumn
            // 
            this.pAgeDataGridViewTextBoxColumn.DataPropertyName = "P_Age";
            this.pAgeDataGridViewTextBoxColumn.HeaderText = "P_Age";
            this.pAgeDataGridViewTextBoxColumn.Name = "pAgeDataGridViewTextBoxColumn";
            this.pAgeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRefByDataGridViewTextBoxColumn
            // 
            this.pRefByDataGridViewTextBoxColumn.DataPropertyName = "P_RefBy";
            this.pRefByDataGridViewTextBoxColumn.HeaderText = "P_RefBy";
            this.pRefByDataGridViewTextBoxColumn.Name = "pRefByDataGridViewTextBoxColumn";
            this.pRefByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pMobNoDataGridViewTextBoxColumn
            // 
            this.pMobNoDataGridViewTextBoxColumn.DataPropertyName = "P_MobNo";
            this.pMobNoDataGridViewTextBoxColumn.HeaderText = "P_MobNo";
            this.pMobNoDataGridViewTextBoxColumn.Name = "pMobNoDataGridViewTextBoxColumn";
            this.pMobNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pAadhaarNoDataGridViewTextBoxColumn
            // 
            this.pAadhaarNoDataGridViewTextBoxColumn.DataPropertyName = "P_AadhaarNo";
            this.pAadhaarNoDataGridViewTextBoxColumn.HeaderText = "P_AadhaarNo";
            this.pAadhaarNoDataGridViewTextBoxColumn.Name = "pAadhaarNoDataGridViewTextBoxColumn";
            this.pAadhaarNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pAddressDataGridViewTextBoxColumn
            // 
            this.pAddressDataGridViewTextBoxColumn.DataPropertyName = "P_Address";
            this.pAddressDataGridViewTextBoxColumn.HeaderText = "P_Address";
            this.pAddressDataGridViewTextBoxColumn.Name = "pAddressDataGridViewTextBoxColumn";
            this.pAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regDateDataGridViewTextBoxColumn
            // 
            this.regDateDataGridViewTextBoxColumn.DataPropertyName = "Reg_Date";
            this.regDateDataGridViewTextBoxColumn.HeaderText = "Reg_Date";
            this.regDateDataGridViewTextBoxColumn.Name = "regDateDataGridViewTextBoxColumn";
            this.regDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_Patient_Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1827, 922);
            this.Controls.Add(this.dgv_PatientRecord);
            this.Controls.Add(this.pnl_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Patient_Records";
            this.Text = "Patient Records";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Patient_Records_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PatientRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinical_Lab_Management_System_DBDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinical_Lab_Management_System_DBDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinical_Lab_Management_System_DBDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientDetailBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lbl_Patient_Records;
        private System.Windows.Forms.DataGridView dgv_PatientRecord;
        private Clinical_Lab_Management_System_DBDataSet13 clinical_Lab_Management_System_DBDataSet13;
        private System.Windows.Forms.BindingSource patientDetailBindingSource;
        private Clinical_Lab_Management_System_DBDataSet13TableAdapters.Patient_DetailTableAdapter patient_DetailTableAdapter;
        private Clinical_Lab_Management_System_DBDataSet14 clinical_Lab_Management_System_DBDataSet14;
        private System.Windows.Forms.BindingSource patientDetailBindingSource1;
        private Clinical_Lab_Management_System_DBDataSet14TableAdapters.Patient_DetailTableAdapter patient_DetailTableAdapter1;
        private Clinical_Lab_Management_System_DBDataSet15 clinical_Lab_Management_System_DBDataSet15;
        private System.Windows.Forms.BindingSource patientDetailBindingSource2;
        private Clinical_Lab_Management_System_DBDataSet15TableAdapters.Patient_DetailTableAdapter patient_DetailTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRefByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pMobNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAadhaarNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regDateDataGridViewTextBoxColumn;
    }
}