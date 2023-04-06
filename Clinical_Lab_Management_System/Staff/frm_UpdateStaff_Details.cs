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
    public partial class frm_Update_And_Delete_Staff_Details : Form
    {
        public frm_Update_And_Delete_Staff_Details()
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
            tb_Staff_ID.Clear();
            tb_First_Name.Clear();
            tb_Middle_Name.Clear();
            tb_Surname.Clear();
            tb_Pr_Name_On_Frm.Clear();
            dtp_Dob.Text = "";
            tb_Age.Clear();
            tb_Education.Clear();
            cmb_Post.Text = "";
            tb_MobNo1.Clear();
            tb_MobNo2.Clear();
            tb_Aadhar_No.Clear();
            tb_Email_Id.Clear();
            tb_Address.Clear();
            cb_District.Text = "";
            cb_State.Text = "";
            cb_Country.Text = "";
            tb_Pincode.Clear();
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string Gender, Shift;

            if (tb_Staff_ID.Text != "")
            {
                Con_Open();
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Select * From Staff_Detail Where S_ID = " + tb_Staff_ID.Text + "";

                SqlDataReader Stf = Cmd.ExecuteReader();

                if (Stf.Read())
                {
                    tb_First_Name.Text = Stf.GetString(Stf.GetOrdinal("S_FName"));
                    tb_Middle_Name.Text = Stf.GetString(Stf.GetOrdinal("S_MName"));
                    tb_Surname.Text = Stf.GetString(Stf.GetOrdinal("S_Surname"));
                    tb_Pr_Name_On_Frm.Text = Stf.GetString(Stf.GetOrdinal("S_FullName"));
                    dtp_Dob.Text = (Stf["S_DOB"].ToString());
                    tb_Age.Text = (Stf["S_Age"].ToString());
                    Gender = Stf.GetString(Stf.GetOrdinal("S_Gender"));
                    if (Gender == "Male")
                    {
                        rb_Male.Checked = true;
                    }
                    else
                    {
                        rb_Female.Checked = true;
                    }

                    tb_Education.Text = Stf.GetString(Stf.GetOrdinal("S_Education"));
                    tb_MobNo1.Text = (Stf["S_MobNo1"].ToString());
                    tb_MobNo2.Text = (Stf["S_MobNo2"].ToString());
                    tb_Email_Id.Text = Stf.GetString(Stf.GetOrdinal("S_EmailID"));
                    tb_Aadhar_No.Text = (Stf["S_AadharNo"].ToString());
                    tb_Address.Text = (Stf["S_Address"].ToString());
                    cb_Country.Text = Stf.GetString(Stf.GetOrdinal("S_Country"));
                    cb_District.Text = Stf.GetString(Stf.GetOrdinal("S_District"));
                    cb_State.Text = Stf.GetString(Stf.GetOrdinal("S_State"));
                    tb_Pincode.Text = (Stf["S_Pincode"].ToString());
                    Shift = Stf.GetString(Stf.GetOrdinal("S_ShiftTime"));
                    if (Shift == "Morning")
                    {
                        rb_Morning.Checked = true;
                    }
                    else if (Shift == "Afternoon")
                    {
                        rb_Afternoon.Checked = true;
                    }
                    else
                    {
                        rb_Night.Checked = true;
                    }
                    cmb_Post.Text = Stf.GetString(Stf.GetOrdinal("S_Post"));
                }
                else
                {
                    MessageBox.Show("Staff Records Not Found", "No Record", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clear_Control();
                    tb_Staff_ID.Focus();
                }
                Con_Close();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (tb_First_Name.Text != "" && tb_Middle_Name.Text != "" && tb_Pr_Name_On_Frm.Text != "" && dtp_Dob.Text != "" && tb_Age.Text != "" && tb_MobNo1.Text != "" && tb_Aadhar_No.Text != "" && tb_Email_Id.Text != "" && tb_Address.Text != "" && (rb_Male.Checked || rb_Female.Checked))
            {
                Con_Open();

                string Shift;

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
                Cmd.CommandText = "Update Staff_Detail Set S_DOB = @DOB, S_Education = @Edu, S_MobNo1 = @MobNo1, S_MobNo2 = @MobNo2, S_EmailID = @EmailID, S_Address = @Address, S_District = @District, S_State = @State, S_Country = @Country, S_ShiftTime = @ShiftTime Where S_ID = " + tb_Staff_ID.Text + " ";

                //SqlDataAdapter da = new SqlDataAdapter(Cmd);
                //DataSet ds = new DataSet();
                //da.Fill(ds);
                //var Obj = Cmd.ExecuteReader();


                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_Dob.Text;
                Cmd.Parameters.Add("Edu", SqlDbType.VarChar).Value = tb_Education.Text;
                Cmd.Parameters.Add("MobNo1", SqlDbType.Decimal).Value = tb_MobNo1.Text;
                Cmd.Parameters.Add("MobNo2", SqlDbType.Decimal).Value = tb_MobNo2.Text;
                Cmd.Parameters.Add("EmailID", SqlDbType.NVarChar).Value = tb_Email_Id.Text;
                Cmd.Parameters.Add("Address", SqlDbType.NVarChar).Value = tb_Address.Text;
                Cmd.Parameters.Add("District", SqlDbType.VarChar).Value = cb_District.Text;
                Cmd.Parameters.Add("State", SqlDbType.VarChar).Value = cb_State.Text;
                Cmd.Parameters.Add("Country", SqlDbType.VarChar).Value = cb_Country.Text;
                Cmd.Parameters.Add("Pincode", SqlDbType.VarChar).Value = tb_Pincode.Text;
                Cmd.Parameters.Add("ShiftTime", SqlDbType.VarChar).Value = Shift;

                //if (ds.Tables[0].Rows.Count > 0)
                //{
                //    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["S_Image"]);
                //    pb_Photograph.Image = Image.FromStream(ms);
                //}

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Staff Details Update Successfully...", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Control();
                Con_Close();

            }
            else
            {
                MessageBox.Show("Somthing Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear_Control();
                tb_Staff_ID.Focus();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear_Control();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        { 
            frm_Dash_Board DB = new frm_Dash_Board();
            DB.Show();
            this.Hide();

            frm_Staff P = new frm_Staff();
            P.TopLevel = false;
            DB.pnl_Load.Controls.Add(P);
            P.BringToFront();
            P.Show();
           // DB.bt .Select();
        }
        

        private void btn_Close_Click(object sender, EventArgs e)
        {
            frm_Dash_Board DB = new frm_Dash_Board();
            DB.Show();
            this.Hide();
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            frm_Staff_Record SR = new frm_Staff_Record();
            SR.Show();
            this.Hide();
        }

        private void Auto_Age(object sender, EventArgs e)
        {
            DateTime D_From = Convert.ToDateTime(dtp_Dob.Text);
            DateTime D_To = DateTime.Now;
            TimeSpan Span = D_To.Subtract(D_From);
            var day = Span.TotalDays;
            var year = Math.Truncate(day / 365);
            tb_Age.Text = Convert.ToString(year);
        }

    }
}
