namespace Clinical_Lab_Management_System
{
    partial class frm_Update_And_Delete_Doctor_Details
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
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.gb_Address_Details = new System.Windows.Forms.GroupBox();
            this.cb_Country = new System.Windows.Forms.ComboBox();
            this.tb_Aadhar_No = new System.Windows.Forms.TextBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_Pincode = new System.Windows.Forms.TextBox();
            this.cb_State = new System.Windows.Forms.ComboBox();
            this.cb_District = new System.Windows.Forms.ComboBox();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.lbl_Pincode = new System.Windows.Forms.Label();
            this.lbl_State = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_District = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.tb_Email_Id = new System.Windows.Forms.TextBox();
            this.tb_MobNo_2 = new System.Windows.Forms.TextBox();
            this.tb_MobNo_1 = new System.Windows.Forms.TextBox();
            this.lbl_Email_Id = new System.Windows.Forms.Label();
            this.lbl_Mobile = new System.Windows.Forms.Label();
            this.lbl_Home = new System.Windows.Forms.Label();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.gb_Primary_Details = new System.Windows.Forms.GroupBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.tb_Deg_Edu = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Doctor_ID = new System.Windows.Forms.Label();
            this.lbl_Deg_Edu = new System.Windows.Forms.Label();
            this.dtp_Dob = new System.Windows.Forms.DateTimePicker();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.tb_Age = new System.Windows.Forms.TextBox();
            this.tb_Pr_Name_On_Frm = new System.Windows.Forms.TextBox();
            this.tb_Surname = new System.Windows.Forms.TextBox();
            this.tb_Middle_Name = new System.Windows.Forms.TextBox();
            this.tb_First_Name = new System.Windows.Forms.TextBox();
            this.tb_Dr_ID = new System.Windows.Forms.TextBox();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.lbl_Pr_Name_On_Frm = new System.Windows.Forms.Label();
            this.lbl_Surname = new System.Windows.Forms.Label();
            this.lbl_First_Name = new System.Windows.Forms.Label();
            this.lbl_Dob = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Middle_Name = new System.Windows.Forms.Label();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.dtp_Date = new System.Windows.Forms.DateTimePicker();
            this.dtp_Time = new System.Windows.Forms.DateTimePicker();
            this.gb_Address_Details.SuspendLayout();
            this.gb_Primary_Details.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.ForeColor = System.Drawing.Color.Red;
            this.lbl_Header.Location = new System.Drawing.Point(689, 18);
            this.lbl_Header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(379, 53);
            this.lbl_Header.TabIndex = 1;
            this.lbl_Header.Text = "Update Doctor";
            // 
            // btn_Update
            // 
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_Update.Location = new System.Drawing.Point(729, 822);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(112, 47);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Close.Location = new System.Drawing.Point(905, 822);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(112, 47);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // gb_Address_Details
            // 
            this.gb_Address_Details.Controls.Add(this.cb_Country);
            this.gb_Address_Details.Controls.Add(this.tb_Aadhar_No);
            this.gb_Address_Details.Controls.Add(this.tb_Address);
            this.gb_Address_Details.Controls.Add(this.tb_Pincode);
            this.gb_Address_Details.Controls.Add(this.cb_State);
            this.gb_Address_Details.Controls.Add(this.cb_District);
            this.gb_Address_Details.Controls.Add(this.lbl_Country);
            this.gb_Address_Details.Controls.Add(this.lbl_Pincode);
            this.gb_Address_Details.Controls.Add(this.lbl_State);
            this.gb_Address_Details.Controls.Add(this.label1);
            this.gb_Address_Details.Controls.Add(this.lbl_District);
            this.gb_Address_Details.Controls.Add(this.lbl_Address);
            this.gb_Address_Details.Controls.Add(this.tb_Email_Id);
            this.gb_Address_Details.Controls.Add(this.tb_MobNo_2);
            this.gb_Address_Details.Controls.Add(this.tb_MobNo_1);
            this.gb_Address_Details.Controls.Add(this.lbl_Email_Id);
            this.gb_Address_Details.Controls.Add(this.lbl_Mobile);
            this.gb_Address_Details.Controls.Add(this.lbl_Home);
            this.gb_Address_Details.Controls.Add(this.lbl_Phone);
            this.gb_Address_Details.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Address_Details.Location = new System.Drawing.Point(931, 158);
            this.gb_Address_Details.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Address_Details.Name = "gb_Address_Details";
            this.gb_Address_Details.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Address_Details.Size = new System.Drawing.Size(829, 612);
            this.gb_Address_Details.TabIndex = 2;
            this.gb_Address_Details.TabStop = false;
            this.gb_Address_Details.Text = "Address Details";
            // 
            // cb_Country
            // 
            this.cb_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Country.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Country.FormattingEnabled = true;
            this.cb_Country.Items.AddRange(new object[] {
            "India",
            "America",
            "Australia",
            "Pakistan",
            "China"});
            this.cb_Country.Location = new System.Drawing.Point(204, 514);
            this.cb_Country.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Country.Name = "cb_Country";
            this.cb_Country.Size = new System.Drawing.Size(161, 26);
            this.cb_Country.TabIndex = 8;
            this.cb_Country.Visible = false;
            // 
            // tb_Aadhar_No
            // 
            this.tb_Aadhar_No.Enabled = false;
            this.tb_Aadhar_No.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Aadhar_No.Location = new System.Drawing.Point(204, 265);
            this.tb_Aadhar_No.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Aadhar_No.Name = "tb_Aadhar_No";
            this.tb_Aadhar_No.Size = new System.Drawing.Size(369, 27);
            this.tb_Aadhar_No.TabIndex = 3;
            // 
            // tb_Address
            // 
            this.tb_Address.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Address.Location = new System.Drawing.Point(204, 380);
            this.tb_Address.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(432, 27);
            this.tb_Address.TabIndex = 5;
            // 
            // tb_Pincode
            // 
            this.tb_Pincode.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Pincode.Location = new System.Drawing.Point(205, 573);
            this.tb_Pincode.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Pincode.Name = "tb_Pincode";
            this.tb_Pincode.Size = new System.Drawing.Size(160, 27);
            this.tb_Pincode.TabIndex = 9;
            this.tb_Pincode.Visible = false;
            // 
            // cb_State
            // 
            this.cb_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_State.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_State.FormattingEnabled = true;
            this.cb_State.Items.AddRange(new object[] {
            "Maharashtra",
            "Karanatak",
            "Goa",
            "Gujrat",
            "Hariyana"});
            this.cb_State.Location = new System.Drawing.Point(449, 456);
            this.cb_State.Margin = new System.Windows.Forms.Padding(4);
            this.cb_State.Name = "cb_State";
            this.cb_State.Size = new System.Drawing.Size(185, 26);
            this.cb_State.TabIndex = 7;
            this.cb_State.Visible = false;
            // 
            // cb_District
            // 
            this.cb_District.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_District.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_District.FormattingEnabled = true;
            this.cb_District.Items.AddRange(new object[] {
            "Satara",
            "Sangli",
            "Kolhapur"});
            this.cb_District.Location = new System.Drawing.Point(203, 456);
            this.cb_District.Margin = new System.Windows.Forms.Padding(4);
            this.cb_District.Name = "cb_District";
            this.cb_District.Size = new System.Drawing.Size(163, 26);
            this.cb_District.TabIndex = 6;
            this.cb_District.Visible = false;
            // 
            // lbl_Country
            // 
            this.lbl_Country.AutoSize = true;
            this.lbl_Country.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Country.Location = new System.Drawing.Point(57, 517);
            this.lbl_Country.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(95, 23);
            this.lbl_Country.TabIndex = 8;
            this.lbl_Country.Text = "Country";
            this.lbl_Country.Visible = false;
            // 
            // lbl_Pincode
            // 
            this.lbl_Pincode.AutoSize = true;
            this.lbl_Pincode.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pincode.Location = new System.Drawing.Point(60, 579);
            this.lbl_Pincode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Pincode.Name = "lbl_Pincode";
            this.lbl_Pincode.Size = new System.Drawing.Size(95, 23);
            this.lbl_Pincode.TabIndex = 9;
            this.lbl_Pincode.Text = "Pincode";
            this.lbl_Pincode.Visible = false;
            // 
            // lbl_State
            // 
            this.lbl_State.AutoSize = true;
            this.lbl_State.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_State.Location = new System.Drawing.Point(375, 461);
            this.lbl_State.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(68, 23);
            this.lbl_State.TabIndex = 7;
            this.lbl_State.Text = "State";
            this.lbl_State.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 272);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aadhar No";
            // 
            // lbl_District
            // 
            this.lbl_District.AutoSize = true;
            this.lbl_District.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_District.Location = new System.Drawing.Point(60, 461);
            this.lbl_District.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_District.Name = "lbl_District";
            this.lbl_District.Size = new System.Drawing.Size(89, 23);
            this.lbl_District.TabIndex = 6;
            this.lbl_District.Text = "District";
            this.lbl_District.Visible = false;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(60, 380);
            this.lbl_Address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(95, 23);
            this.lbl_Address.TabIndex = 5;
            this.lbl_Address.Text = "Address";
            // 
            // tb_Email_Id
            // 
            this.tb_Email_Id.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email_Id.Location = new System.Drawing.Point(205, 324);
            this.tb_Email_Id.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Email_Id.Name = "tb_Email_Id";
            this.tb_Email_Id.Size = new System.Drawing.Size(369, 27);
            this.tb_Email_Id.TabIndex = 4;
            // 
            // tb_MobNo_2
            // 
            this.tb_MobNo_2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MobNo_2.Location = new System.Drawing.Point(205, 205);
            this.tb_MobNo_2.Margin = new System.Windows.Forms.Padding(4);
            this.tb_MobNo_2.Name = "tb_MobNo_2";
            this.tb_MobNo_2.Size = new System.Drawing.Size(252, 27);
            this.tb_MobNo_2.TabIndex = 2;
            // 
            // tb_MobNo_1
            // 
            this.tb_MobNo_1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MobNo_1.Location = new System.Drawing.Point(205, 121);
            this.tb_MobNo_1.Margin = new System.Windows.Forms.Padding(4);
            this.tb_MobNo_1.Name = "tb_MobNo_1";
            this.tb_MobNo_1.Size = new System.Drawing.Size(252, 27);
            this.tb_MobNo_1.TabIndex = 1;
            // 
            // lbl_Email_Id
            // 
            this.lbl_Email_Id.AutoSize = true;
            this.lbl_Email_Id.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email_Id.Location = new System.Drawing.Point(60, 331);
            this.lbl_Email_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Email_Id.Name = "lbl_Email_Id";
            this.lbl_Email_Id.Size = new System.Drawing.Size(110, 23);
            this.lbl_Email_Id.TabIndex = 4;
            this.lbl_Email_Id.Text = "E-Mail ID";
            // 
            // lbl_Mobile
            // 
            this.lbl_Mobile.AutoSize = true;
            this.lbl_Mobile.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile.Location = new System.Drawing.Point(199, 80);
            this.lbl_Mobile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Mobile.Name = "lbl_Mobile";
            this.lbl_Mobile.Size = new System.Drawing.Size(102, 23);
            this.lbl_Mobile.TabIndex = 1;
            this.lbl_Mobile.Text = "Mobile 1";
            // 
            // lbl_Home
            // 
            this.lbl_Home.AutoSize = true;
            this.lbl_Home.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Home.Location = new System.Drawing.Point(199, 166);
            this.lbl_Home.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Home.Name = "lbl_Home";
            this.lbl_Home.Size = new System.Drawing.Size(102, 23);
            this.lbl_Home.TabIndex = 2;
            this.lbl_Home.Text = "Mobile 2";
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phone.Location = new System.Drawing.Point(60, 90);
            this.lbl_Phone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(78, 23);
            this.lbl_Phone.TabIndex = 0;
            this.lbl_Phone.Text = "Phone";
            // 
            // gb_Primary_Details
            // 
            this.gb_Primary_Details.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gb_Primary_Details.Controls.Add(this.btn_Clear);
            this.gb_Primary_Details.Controls.Add(this.tb_Deg_Edu);
            this.gb_Primary_Details.Controls.Add(this.btn_Search);
            this.gb_Primary_Details.Controls.Add(this.lbl_Doctor_ID);
            this.gb_Primary_Details.Controls.Add(this.lbl_Deg_Edu);
            this.gb_Primary_Details.Controls.Add(this.dtp_Dob);
            this.gb_Primary_Details.Controls.Add(this.rb_Female);
            this.gb_Primary_Details.Controls.Add(this.rb_Male);
            this.gb_Primary_Details.Controls.Add(this.tb_Age);
            this.gb_Primary_Details.Controls.Add(this.tb_Pr_Name_On_Frm);
            this.gb_Primary_Details.Controls.Add(this.tb_Surname);
            this.gb_Primary_Details.Controls.Add(this.tb_Middle_Name);
            this.gb_Primary_Details.Controls.Add(this.tb_First_Name);
            this.gb_Primary_Details.Controls.Add(this.tb_Dr_ID);
            this.gb_Primary_Details.Controls.Add(this.lbl_Age);
            this.gb_Primary_Details.Controls.Add(this.lbl_Pr_Name_On_Frm);
            this.gb_Primary_Details.Controls.Add(this.lbl_Surname);
            this.gb_Primary_Details.Controls.Add(this.lbl_First_Name);
            this.gb_Primary_Details.Controls.Add(this.lbl_Dob);
            this.gb_Primary_Details.Controls.Add(this.lbl_Gender);
            this.gb_Primary_Details.Controls.Add(this.lbl_Middle_Name);
            this.gb_Primary_Details.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Primary_Details.Location = new System.Drawing.Point(88, 158);
            this.gb_Primary_Details.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Primary_Details.Name = "gb_Primary_Details";
            this.gb_Primary_Details.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Primary_Details.Size = new System.Drawing.Size(728, 612);
            this.gb_Primary_Details.TabIndex = 1;
            this.gb_Primary_Details.TabStop = false;
            this.gb_Primary_Details.Text = "Primary Details";
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.Navy;
            this.btn_Clear.Location = new System.Drawing.Point(549, 60);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(113, 42);
            this.btn_Clear.TabIndex = 12;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // tb_Deg_Edu
            // 
            this.tb_Deg_Edu.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Deg_Edu.Location = new System.Drawing.Point(289, 529);
            this.tb_Deg_Edu.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Deg_Edu.Name = "tb_Deg_Edu";
            this.tb_Deg_Edu.Size = new System.Drawing.Size(200, 27);
            this.tb_Deg_Edu.TabIndex = 11;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Search.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Navy;
            this.btn_Search.Location = new System.Drawing.Point(439, 60);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(112, 42);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_Doctor_ID
            // 
            this.lbl_Doctor_ID.AutoSize = true;
            this.lbl_Doctor_ID.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Doctor_ID.Location = new System.Drawing.Point(49, 66);
            this.lbl_Doctor_ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Doctor_ID.Name = "lbl_Doctor_ID";
            this.lbl_Doctor_ID.Size = new System.Drawing.Size(114, 23);
            this.lbl_Doctor_ID.TabIndex = 1;
            this.lbl_Doctor_ID.Text = "Doctor ID";
            // 
            // lbl_Deg_Edu
            // 
            this.lbl_Deg_Edu.AutoSize = true;
            this.lbl_Deg_Edu.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Deg_Edu.Location = new System.Drawing.Point(48, 521);
            this.lbl_Deg_Edu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Deg_Edu.Name = "lbl_Deg_Edu";
            this.lbl_Deg_Edu.Size = new System.Drawing.Size(207, 23);
            this.lbl_Deg_Edu.TabIndex = 11;
            this.lbl_Deg_Edu.Text = "Degree/Education";
            // 
            // dtp_Dob
            // 
            this.dtp_Dob.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Dob.Location = new System.Drawing.Point(289, 347);
            this.dtp_Dob.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_Dob.Name = "dtp_Dob";
            this.dtp_Dob.Size = new System.Drawing.Size(225, 27);
            this.dtp_Dob.TabIndex = 7;
            this.dtp_Dob.Value = new System.DateTime(2021, 11, 8, 22, 11, 52, 0);
            this.dtp_Dob.Leave += new System.EventHandler(this.dtp_Dob_Leave);
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Enabled = false;
            this.rb_Female.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Female.Location = new System.Drawing.Point(416, 410);
            this.rb_Female.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(109, 27);
            this.rb_Female.TabIndex = 9;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Enabled = false;
            this.rb_Male.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Male.Location = new System.Drawing.Point(292, 407);
            this.rb_Male.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(82, 27);
            this.rb_Male.TabIndex = 8;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // tb_Age
            // 
            this.tb_Age.Enabled = false;
            this.tb_Age.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Age.Location = new System.Drawing.Point(289, 466);
            this.tb_Age.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Age.Name = "tb_Age";
            this.tb_Age.Size = new System.Drawing.Size(64, 27);
            this.tb_Age.TabIndex = 10;
            // 
            // tb_Pr_Name_On_Frm
            // 
            this.tb_Pr_Name_On_Frm.Enabled = false;
            this.tb_Pr_Name_On_Frm.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Pr_Name_On_Frm.Location = new System.Drawing.Point(289, 293);
            this.tb_Pr_Name_On_Frm.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Pr_Name_On_Frm.Name = "tb_Pr_Name_On_Frm";
            this.tb_Pr_Name_On_Frm.Size = new System.Drawing.Size(408, 27);
            this.tb_Pr_Name_On_Frm.TabIndex = 6;
            // 
            // tb_Surname
            // 
            this.tb_Surname.Enabled = false;
            this.tb_Surname.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Surname.Location = new System.Drawing.Point(289, 238);
            this.tb_Surname.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Surname.Name = "tb_Surname";
            this.tb_Surname.Size = new System.Drawing.Size(200, 27);
            this.tb_Surname.TabIndex = 5;
            // 
            // tb_Middle_Name
            // 
            this.tb_Middle_Name.Enabled = false;
            this.tb_Middle_Name.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Middle_Name.Location = new System.Drawing.Point(289, 177);
            this.tb_Middle_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Middle_Name.Name = "tb_Middle_Name";
            this.tb_Middle_Name.Size = new System.Drawing.Size(200, 27);
            this.tb_Middle_Name.TabIndex = 4;
            // 
            // tb_First_Name
            // 
            this.tb_First_Name.Enabled = false;
            this.tb_First_Name.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_First_Name.Location = new System.Drawing.Point(289, 121);
            this.tb_First_Name.Margin = new System.Windows.Forms.Padding(4);
            this.tb_First_Name.Name = "tb_First_Name";
            this.tb_First_Name.Size = new System.Drawing.Size(200, 27);
            this.tb_First_Name.TabIndex = 3;
            // 
            // tb_Dr_ID
            // 
            this.tb_Dr_ID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Dr_ID.Location = new System.Drawing.Point(289, 66);
            this.tb_Dr_ID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Dr_ID.Name = "tb_Dr_ID";
            this.tb_Dr_ID.Size = new System.Drawing.Size(120, 27);
            this.tb_Dr_ID.TabIndex = 1;
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Age.Location = new System.Drawing.Point(51, 459);
            this.lbl_Age.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(51, 23);
            this.lbl_Age.TabIndex = 10;
            this.lbl_Age.Text = "Age";
            // 
            // lbl_Pr_Name_On_Frm
            // 
            this.lbl_Pr_Name_On_Frm.AutoSize = true;
            this.lbl_Pr_Name_On_Frm.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pr_Name_On_Frm.Location = new System.Drawing.Point(48, 286);
            this.lbl_Pr_Name_On_Frm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Pr_Name_On_Frm.Name = "lbl_Pr_Name_On_Frm";
            this.lbl_Pr_Name_On_Frm.Size = new System.Drawing.Size(237, 23);
            this.lbl_Pr_Name_On_Frm.TabIndex = 6;
            this.lbl_Pr_Name_On_Frm.Text = "Print Name On Form ";
            // 
            // lbl_Surname
            // 
            this.lbl_Surname.AutoSize = true;
            this.lbl_Surname.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Surname.Location = new System.Drawing.Point(48, 230);
            this.lbl_Surname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Surname.Name = "lbl_Surname";
            this.lbl_Surname.Size = new System.Drawing.Size(107, 23);
            this.lbl_Surname.TabIndex = 5;
            this.lbl_Surname.Text = "Surname";
            // 
            // lbl_First_Name
            // 
            this.lbl_First_Name.AutoSize = true;
            this.lbl_First_Name.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_First_Name.Location = new System.Drawing.Point(48, 116);
            this.lbl_First_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_First_Name.Name = "lbl_First_Name";
            this.lbl_First_Name.Size = new System.Drawing.Size(127, 23);
            this.lbl_First_Name.TabIndex = 3;
            this.lbl_First_Name.Text = "First Name";
            // 
            // lbl_Dob
            // 
            this.lbl_Dob.AutoSize = true;
            this.lbl_Dob.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dob.Location = new System.Drawing.Point(51, 347);
            this.lbl_Dob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Dob.Name = "lbl_Dob";
            this.lbl_Dob.Size = new System.Drawing.Size(56, 23);
            this.lbl_Dob.TabIndex = 7;
            this.lbl_Dob.Text = "DOB";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(51, 415);
            this.lbl_Gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(87, 23);
            this.lbl_Gender.TabIndex = 8;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Middle_Name
            // 
            this.lbl_Middle_Name.AutoSize = true;
            this.lbl_Middle_Name.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Middle_Name.Location = new System.Drawing.Point(48, 170);
            this.lbl_Middle_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Middle_Name.Name = "lbl_Middle_Name";
            this.lbl_Middle_Name.Size = new System.Drawing.Size(150, 23);
            this.lbl_Middle_Name.TabIndex = 4;
            this.lbl_Middle_Name.Text = "Middle Name";
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_Header.Controls.Add(this.btn_Back);
            this.pnl_Header.Controls.Add(this.dtp_Date);
            this.pnl_Header.Controls.Add(this.dtp_Time);
            this.pnl_Header.Controls.Add(this.lbl_Header);
            this.pnl_Header.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_Header.Location = new System.Drawing.Point(-4, 1);
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(2080, 87);
            this.pnl_Header.TabIndex = 5;
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(64, 18);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(127, 50);
            this.btn_Back.TabIndex = 0;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // dtp_Date
            // 
            this.dtp_Date.CustomFormat = "";
            this.dtp_Date.Enabled = false;
            this.dtp_Date.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Date.Location = new System.Drawing.Point(1460, 34);
            this.dtp_Date.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_Date.Name = "dtp_Date";
            this.dtp_Date.Size = new System.Drawing.Size(132, 26);
            this.dtp_Date.TabIndex = 2;
            this.dtp_Date.Value = new System.DateTime(2021, 10, 29, 12, 42, 13, 0);
            // 
            // dtp_Time
            // 
            this.dtp_Time.CustomFormat = "";
            this.dtp_Time.Enabled = false;
            this.dtp_Time.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_Time.Location = new System.Drawing.Point(1616, 34);
            this.dtp_Time.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_Time.Name = "dtp_Time";
            this.dtp_Time.Size = new System.Drawing.Size(107, 26);
            this.dtp_Time.TabIndex = 3;
            this.dtp_Time.Value = new System.DateTime(2021, 10, 29, 12, 44, 8, 0);
            // 
            // frm_Update_And_Delete_Doctor_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1827, 922);
            this.Controls.Add(this.gb_Address_Details);
            this.Controls.Add(this.gb_Primary_Details);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.pnl_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Update_And_Delete_Doctor_Details";
            this.Text = "Update Doctor Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Update_And_Delete_Doctor_Details_Load);
            this.gb_Address_Details.ResumeLayout(false);
            this.gb_Address_Details.PerformLayout();
            this.gb_Primary_Details.ResumeLayout(false);
            this.gb_Primary_Details.PerformLayout();
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.GroupBox gb_Address_Details;
        private System.Windows.Forms.ComboBox cb_Country;
        private System.Windows.Forms.TextBox tb_Aadhar_No;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.TextBox tb_Pincode;
        private System.Windows.Forms.ComboBox cb_State;
        private System.Windows.Forms.ComboBox cb_District;
        private System.Windows.Forms.Label lbl_Country;
        private System.Windows.Forms.Label lbl_Pincode;
        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_District;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox tb_Email_Id;
        private System.Windows.Forms.TextBox tb_MobNo_2;
        private System.Windows.Forms.TextBox tb_MobNo_1;
        private System.Windows.Forms.Label lbl_Email_Id;
        private System.Windows.Forms.Label lbl_Mobile;
        private System.Windows.Forms.Label lbl_Home;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.GroupBox gb_Primary_Details;
        private System.Windows.Forms.Label lbl_Doctor_ID;
        private System.Windows.Forms.Label lbl_Deg_Edu;
        private System.Windows.Forms.DateTimePicker dtp_Dob;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.TextBox tb_Age;
        private System.Windows.Forms.TextBox tb_Pr_Name_On_Frm;
        private System.Windows.Forms.TextBox tb_Surname;
        private System.Windows.Forms.TextBox tb_Middle_Name;
        private System.Windows.Forms.TextBox tb_First_Name;
        private System.Windows.Forms.TextBox tb_Dr_ID;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.Label lbl_Pr_Name_On_Frm;
        private System.Windows.Forms.Label lbl_Surname;
        private System.Windows.Forms.Label lbl_First_Name;
        private System.Windows.Forms.Label lbl_Dob;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Middle_Name;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.DateTimePicker dtp_Date;
        private System.Windows.Forms.DateTimePicker dtp_Time;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox tb_Deg_Edu;
        private System.Windows.Forms.Button btn_Clear;
    }
}