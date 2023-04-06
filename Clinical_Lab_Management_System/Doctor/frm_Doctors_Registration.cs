using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Clinical_Lab_Management_System
{
    public partial class frm_Doctors_Registration : Form
    {
        public frm_Doctors_Registration()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Clinical_Lab_Management_System_DB;Integrated Security=True");
        string imgLocation = "";

        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }


        void Clear_Control()
        {

            tb_Dr_ID.Text = Convert.ToString(Auto_Increment());
            tb_First_Name.Clear();
            tb_Middle_Name.Clear();
            tb_Surname.Clear();
            tb_Pr_Name_On_Frm.Clear();
            dtp_Dob.Text = "";
            tb_Age.Clear();
            tb_Deg_Edu.Clear();
            tb_Mobile1_No.Clear();
            tb_Mobile2_No.Clear();
            tb_Aadhar_No.Clear();
            tb_EmailID.Clear();
            tb_Address.Clear();
            cb_District.Text = "";
            cb_State.Text = "";
            cb_Country.Text = "";
            tb_Pincode.Clear();
            rb_Male.Checked = false;
            rb_Female.Checked = false;
            pb_Photograph.Image = null;

            tb_First_Name.Focus();
        }




        int Auto_Increment()
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) From Doctor_Detail";
            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(D_ID) From Doctor_Detail";
                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                Cnt = 101;
            }
            Cmd.Dispose();
            return Cnt;
        }




        private void btn_Register_Click(object sender, EventArgs e)
        {
            string Gender;

            if (tb_First_Name.Text != "" && tb_Middle_Name.Text != "" && tb_Surname.Text != "" && tb_Pr_Name_On_Frm.Text != "" && dtp_Dob.Text != "" && tb_Age.Text != "" && tb_Deg_Edu.Text != "" && tb_Mobile1_No.Text != "" && tb_Aadhar_No.Text != "" && tb_EmailID.Text != "" && tb_Address.Text != "" && tb_Registered_By.Text!="" && pb_Photograph.Image != null && (rb_Male.Checked || rb_Female.Checked))
            {
                Con_Open();

                if (rb_Male.Checked == true)
                {
                    Gender = "Male";
                }
                else
                {
                    Gender = "Female";
                }



                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert into Doctor_Detail(D_ID,D_FName,D_MName,D_Surname,D_FullName,D_DOB,D_Age,D_Gender,D_Degree,D_MobNo1,D_MobNo2,D_AadharNo,D_EmailID,D_Address,D_District,D_State,D_Country,D_Pincode,D_RegBy,D_RegDate,D_Image)Values(@ID,@FName,@MName,@Surname,@FullName,@DOB,@Age,@Gender,@Degree,@MobNo1,@MobNo2,@AadharNo,@EmailID,@Address,@District,@State,@Country,@Pincode,@RegBy,@RegDate,@Image)";

                Cmd.Parameters.Add("ID", SqlDbType.Int).Value = tb_Dr_ID.Text;
                Cmd.Parameters.Add("FName", SqlDbType.VarChar).Value = tb_First_Name.Text;
                Cmd.Parameters.Add("MName", SqlDbType.VarChar).Value = tb_Middle_Name.Text;
                Cmd.Parameters.Add("Surname", SqlDbType.VarChar).Value = tb_Surname.Text;
                Cmd.Parameters.Add("FullName", SqlDbType.VarChar).Value = tb_Pr_Name_On_Frm.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_Dob.Text;
                Cmd.Parameters.Add("Age", SqlDbType.Int).Value = tb_Age.Text;
                Cmd.Parameters.Add("Gender", SqlDbType.VarChar).Value = Gender;
                Cmd.Parameters.Add("Degree", SqlDbType.VarChar).Value = tb_Deg_Edu.Text;
                Cmd.Parameters.Add("MobNo1", SqlDbType.Decimal).Value = tb_Mobile1_No.Text;
                Cmd.Parameters.Add("MobNo2", SqlDbType.Decimal).Value = tb_Mobile2_No.Text;
                Cmd.Parameters.Add("AadharNo", SqlDbType.Decimal).Value = tb_Aadhar_No.Text;
                Cmd.Parameters.Add("EmailID", SqlDbType.NVarChar).Value = tb_EmailID.Text;
                Cmd.Parameters.Add("Address", SqlDbType.NVarChar).Value = tb_Address.Text;
                Cmd.Parameters.Add("District", SqlDbType.VarChar).Value = cb_District.Text;
                Cmd.Parameters.Add("State", SqlDbType.VarChar).Value = cb_State.Text;
                Cmd.Parameters.Add("Country", SqlDbType.VarChar).Value = cb_Country.Text;
                Cmd.Parameters.Add("Pincode", SqlDbType.VarChar).Value = tb_Pincode.Text;
                Cmd.Parameters.Add("RegBy", SqlDbType.VarChar).Value = tb_Registered_By.Text;
                Cmd.Parameters.Add("RegDate", SqlDbType.Date).Value = dtp_Date.Text;

                ImageConverter IC = new ImageConverter();
                byte[] imgArray = (byte[])IC.ConvertTo(pb_Photograph.Image, typeof(byte[]));

                Cmd.Parameters.Add("Image", SqlDbType.Image).Value = imgArray;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Doctor Added Succesfully...", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Control();
                Con_Close();
            }
            else
            {
                MessageBox.Show("Incomplete Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frm_Doctors_Registration_Load(object sender, EventArgs e)
        {
            tb_Dr_ID.Text = Convert.ToString(Auto_Increment());
            DateTime DT = DateTime.Now;
            this.dtp_Dob.Text = DT.ToString();
            this.dtp_Time.Text = DT.ToString();
            this.dtp_Date.Text = DT.ToString();
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            lbl_Photograph.Visible = false;
            lbl_size.Visible = false;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All Files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pb_Photograph.ImageLocation = imgLocation;

            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear_Control();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            frm_Dash_Board obj = new frm_Dash_Board();
            this.Hide();
            obj.Show();
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            frm_Doctors_Record obj = new frm_Doctors_Record();
            this.Hide();
            obj.Show();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Dash_Board DB = new frm_Dash_Board();
            DB.Show();

            frm_Doctor P = new frm_Doctor();
            P.TopLevel = false;
            DB.pnl_Load.Controls.Add(P);
            P.BringToFront();
            P.Show();
            DB.btn_Patient.Select();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Char(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Auto_Write_Name(object sender, EventArgs e)
        {
            tb_Pr_Name_On_Frm.Text = "Dr. " + tb_First_Name.Text + " " + tb_Middle_Name.Text + " " + tb_Surname.Text;
        }

        private void Auto_Age_Calculate(object sender, EventArgs e)
        {
            DateTime D_From = Convert.ToDateTime(dtp_Dob.Text);
            DateTime D_To = DateTime.Now;
            TimeSpan Span = D_To.Subtract(D_From);
            var day = Span.TotalDays;
            var year = Math.Truncate(day/365);
            tb_Age.Text = Convert.ToString(year);
        }

        

        

        

    }
}