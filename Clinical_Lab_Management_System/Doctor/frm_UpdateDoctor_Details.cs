using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Clinical_Lab_Management_System
{
    public partial class frm_Update_And_Delete_Doctor_Details : Form
    {
        public frm_Update_And_Delete_Doctor_Details()
        {
            InitializeComponent();
        }


        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Clinical_Lab_Management_System_DB;Integrated Security=True");
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

            tb_Dr_ID.Clear();
            tb_First_Name.Clear();
            tb_Middle_Name.Clear();
            tb_Surname.Clear();
            tb_Pr_Name_On_Frm.Clear();
            dtp_Dob.Text = "";
            tb_Age.Clear();
            tb_Deg_Edu.Clear();
            tb_MobNo_1.Clear();
            tb_MobNo_2.Clear();
            tb_Aadhar_No.Clear();
            tb_Email_Id.Clear();
            tb_Address.Clear();
            cb_District.Text = "";
            cb_State.Text = "";
            cb_Country.Text = "";
            tb_Pincode.Clear();
            rb_Male.Checked = false;
            rb_Female.Checked = false;
           // pb_Photograph.Image = null;

            tb_Dr_ID.Focus();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Dash_Board obj = new frm_Dash_Board();
            obj.Show();

            frm_Doctor D = new frm_Doctor();
            D.TopLevel = false;
            obj.pnl_Load.Controls.Add(D);
            D.BringToFront();
            this.Hide();
            D.Show();
           
      
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_Dr_ID.Text != "")
            {
                string Gender;

                Con_Open();

                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Select * From Doctor_Detail Where D_ID = " + tb_Dr_ID.Text + "";

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_First_Name.Text = Dr.GetString(Dr.GetOrdinal("D_FName"));
                    tb_Middle_Name.Text = Dr.GetString(Dr.GetOrdinal("D_MName"));
                    tb_Surname.Text = Dr.GetString(Dr.GetOrdinal("D_Surname"));
                    tb_Pr_Name_On_Frm.Text = Dr.GetString(Dr.GetOrdinal("D_FullName"));
                    dtp_Dob.Text = (Dr["D_DOB"].ToString());
                    tb_Age.Text = (Dr["D_Age"].ToString());
                    Gender = Dr.GetString(Dr.GetOrdinal("D_Gender"));
                    if (Gender == "Male")
                    {
                        rb_Male.Checked = true;
                    }
                    else
                    {
                        rb_Female.Checked = true;
                    }

                    tb_Deg_Edu.Text = Dr.GetString(Dr.GetOrdinal("D_Degree"));
                    tb_MobNo_1.Text = (Dr["D_MobNo1"].ToString());
                    tb_MobNo_2.Text = (Dr["D_MobNo2"].ToString());
                    tb_Email_Id.Text = Dr.GetString(Dr.GetOrdinal("D_Email"));
                    tb_Aadhar_No.Text = (Dr["D_AadhaarNo"].ToString());
                    tb_Address.Text = (Dr["D_Address"].ToString());
                   /* cb_Country.Text = Dr.GetString(Dr.GetOrdinal("D_Country"));
                    cb_District.Text = Dr.GetString(Dr.GetOrdinal("D_District"));
                    cb_State.Text = Dr.GetString(Dr.GetOrdinal("D_State"));
                    tb_Pincode.Text = (Dr["D_Pincode"].ToString());*/

                }
                else
                {
                    MessageBox.Show("Doctor Records Not Found", "No Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clear_Control();
                    tb_Dr_ID.Focus();
                }
                Con_Close();
            }
          
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear_Control();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (tb_First_Name.Text != "" && tb_Middle_Name.Text != "" && tb_Surname.Text != "" && tb_Pr_Name_On_Frm.Text != "" && dtp_Dob.Text != "" && tb_Age.Text != "" && tb_Deg_Edu.Text != "" && tb_MobNo_1.Text != "" && tb_Aadhar_No.Text != "" && tb_Email_Id.Text != "" && tb_Address.Text != "" && (rb_Male.Checked || rb_Female.Checked))
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                Cmd.CommandText = "Update Doctor_Detail Set D_DOB = @DOB, D_Degree = @Degree, D_MobNo1 = @MobNo1, D_MobNo2 = @MobNo2, D_EmailID = @EmailID, D_Address = @Address, D_District = @District, D_State = @State, D_Country = @Country Where D_ID = " + tb_Dr_ID.Text + " ";
               
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_Dob.Text;
                Cmd.Parameters.Add("Degree", SqlDbType.VarChar).Value = tb_Deg_Edu.Text;
                Cmd.Parameters.Add("MobNo1", SqlDbType.Decimal).Value = tb_MobNo_1.Text;
                Cmd.Parameters.Add("MobNo2", SqlDbType.Decimal).Value = tb_MobNo_2.Text;
                Cmd.Parameters.Add("EmailID", SqlDbType.NVarChar).Value = tb_Email_Id.Text;
                Cmd.Parameters.Add("Address", SqlDbType.NVarChar).Value = tb_Address.Text;
                Cmd.Parameters.Add("District", SqlDbType.VarChar).Value = cb_District.Text;
                Cmd.Parameters.Add("State", SqlDbType.VarChar).Value = cb_State.Text;
                Cmd.Parameters.Add("Country", SqlDbType.VarChar).Value = cb_Country.Text;
                Cmd.Parameters.Add("Pincode", SqlDbType.VarChar).Value = tb_Pincode.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Doctor Details Update Successfully...", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Control();
                Con_Close();

            }
            else
            {
                MessageBox.Show("Somthing Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear_Control();
                tb_Dr_ID.Focus();
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            frm_Dash_Board obj = new frm_Dash_Board();
            this.Hide();
            obj.Show();
        }

        private void frm_Update_And_Delete_Doctor_Details_Load(object sender, EventArgs e)
        {
            
            DateTime DT = DateTime.Now;
            this.dtp_Dob.Text = DT.ToString();
            this.dtp_Time.Text = DT.ToString();
            this.dtp_Date.Text = DT.ToString();
        }

        private void dtp_Dob_Leave(object sender, EventArgs e)
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
