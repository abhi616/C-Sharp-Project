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
    public partial class frm_Staff_Registration : Form
    {
        public frm_Staff_Registration()
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
            tb_Staff_ID.Text = Convert.ToString(Auto_Increment());
            tb_First_Name.Clear();
            tb_Middle_Name.Clear();
            tb_Surname.Clear();
            tb_Pr_Name_On_Frm.Clear();
            dtp_Dob.Text = "";
            tb_Age.Clear();
            tb_Education.Clear();
            cmb_Post.Text = "";
            tb_Mobile1_No.Clear();
            tb_Mobile2_No.Clear();
            tb_Aadhar_No.Clear();
            tb_Email_Id.Clear();
            tb_Address.Clear();
            rb_Male.Checked = false;
            rb_Female.Checked = false;
            rb_Morning.Checked = false;
            rb_Afternoon.Checked = false;
            rb_Night.Checked = false;
            pb_Photograph.Image = null;

            lbl_Photograph.Visible = true;
            lbl_size.Visible = true;

            tb_First_Name.Focus();
        }




        int Auto_Increment()
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) From Staff_Detail";
            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(S_ID) From Staff_Detail";
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
            string Gender, Shift;

            if (tb_First_Name.Text != "" && tb_Middle_Name.Text != "" && tb_Surname.Text != "" && tb_Pr_Name_On_Frm.Text != "" && dtp_Dob.Text != "" && tb_Age.Text != "" && tb_Education.Text != "" && cmb_Post.Text != "" && tb_Mobile1_No.Text != "" && tb_Aadhar_No.Text != "" && tb_Email_Id.Text != "" && tb_Address.Text != "" && pb_Photograph.Image != null && (rb_Male.Checked || rb_Female.Checked) && (rb_Morning.Checked || rb_Afternoon.Checked || rb_Night.Checked))
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


                if (rb_Morning.Checked == true)
                {
                    Shift = "Morning";
                }
                else if (rb_Afternoon.Checked == true)
                {
                    Shift = "Afternoon";
                }
                else
                {
                    Shift = "Night";
                }

                

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert into Staff_Detail(S_ID,S_FName,S_MName,S_Surname,S_FullName,S_Dob,S_Age,S_Gender,S_Education,S_Post,S_MobNo1,S_MobNo2,S_AadharNo,S_EmailID,S_Address,S_District,S_State,S_Country,S_Pincode,S_ShiftTime,S_RegBy,S_Image,S_RegDate)Values(@ID,@FName,@MName,@Surname,@FullName,@DOB,@Age,@Gender,@Education,@Post,@MobNo1,@MobNo2,@AadharNo,@EmailID,@Address,@District,@State,@Country,@Pincode,@ShiftTime,@RegBy,@Image,@RegDate)";

                Cmd.Parameters.Add("ID", SqlDbType.Int).Value = tb_Staff_ID.Text;
                Cmd.Parameters.Add("FName", SqlDbType.VarChar).Value = tb_First_Name.Text;
                Cmd.Parameters.Add("MName", SqlDbType.VarChar).Value = tb_Middle_Name.Text;
                Cmd.Parameters.Add("Surname", SqlDbType.VarChar).Value = tb_Surname.Text;
                Cmd.Parameters.Add("FullName", SqlDbType.VarChar).Value = tb_Pr_Name_On_Frm.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_Dob.Text;
                Cmd.Parameters.Add("Age", SqlDbType.Int).Value = tb_Age.Text;
                Cmd.Parameters.Add("Gender", SqlDbType.VarChar).Value = Gender;
                Cmd.Parameters.Add("Education", SqlDbType.VarChar).Value = tb_Education.Text;
                Cmd.Parameters.Add("Post", SqlDbType.VarChar).Value = cmb_Post.Text;
                Cmd.Parameters.Add("MobNo1", SqlDbType.Decimal).Value = tb_Mobile1_No.Text;
                Cmd.Parameters.Add("MobNo2", SqlDbType.Decimal).Value = tb_Mobile2_No.Text;
                Cmd.Parameters.Add("AadharNo", SqlDbType.Decimal).Value = tb_Aadhar_No.Text;
                Cmd.Parameters.Add("EmailId", SqlDbType.NVarChar).Value = tb_Email_Id.Text;
                Cmd.Parameters.Add("Address", SqlDbType.NVarChar).Value = tb_Address.Text;
                Cmd.Parameters.Add("ShiftTime", SqlDbType.VarChar).Value = Shift;
                Cmd.Parameters.Add("RegBy", SqlDbType.VarChar).Value = tb_Registered_By.Text;
                Cmd.Parameters.Add("RegDate", SqlDbType.Date).Value = dtp_Date.Text;

                ImageConverter IC = new ImageConverter();
                byte[] imgArray = (byte[])IC.ConvertTo(pb_Photograph.Image, typeof(byte[])  );

                Cmd.Parameters.Add("Image", SqlDbType.Image).Value = imgArray;
                
                Cmd.ExecuteNonQuery();


             /*   DateTime dt = DateTime.Parse(dtp_Dob.Text);
                DateTime dt_Now = DateTime.Now;
                DateTime dt_18 = dt.AddYears(-18);
                if (dt.Date >= dt_18.Date)
                {
                    MessageBox.Show("Your age is less than 18", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/


                MessageBox.Show("Staff Added Succesfully...", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Control();
                Con_Close();
            }
            else
            {
                MessageBox.Show("Incomplete Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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

        private void frm_Staff_Registration_Load(object sender, EventArgs e)
        {
            tb_Staff_ID.Text = Convert.ToString(Auto_Increment());
            DateTime DT = DateTime.Now;
            this.dtp_Date.Text = DT.ToString();
            dtp_Dob.Value = DateTime.Now;
            dtp_Time.Value = DateTime.Now;
        }

        private void dtp_Date_ValueChanged(object sender, EventArgs e)
        {
            this.dtp_Date.Value = DateTime.Now;
            
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
            frm_Staff_Record obj = new frm_Staff_Record();
            this.Hide();
            obj.Show();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Dash_Board DB = new frm_Dash_Board();
            DB.Show();

            frm_Staff P = new frm_Staff();
            P.TopLevel = false;
            DB.pnl_Load.Controls.Add(P);
            P.BringToFront();
            P.Show();
            DB.btn_Patient.Select();
        }

        private void Full_Name_Print(object sender, EventArgs e)
        {
            tb_Pr_Name_On_Frm.Text =  tb_First_Name.Text + " " + tb_Middle_Name.Text + " " + tb_Surname.Text;

            //tb_Pr_Name_On_Frm.Text = "Mr/Miss. " + tb_First_Name.Text + " " + tb_Middle_Name.Text + " " + tb_Surname.Text;
        }

        private void Auto_Age_Leave(object sender, EventArgs e)
        {
            DateTime S_From = Convert.ToDateTime(dtp_Dob.Text);
            DateTime S_To = DateTime.Now;
            TimeSpan Span = S_To.Subtract(S_From);
            var day = Span.TotalDays;
            var year = Math.Truncate(day / 365);

            tb_Age.Text = Convert.ToString(year);
        }

       

    }
}
