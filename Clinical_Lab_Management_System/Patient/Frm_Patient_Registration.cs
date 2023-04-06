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
    public partial class Frm_Patient_Registration : Form
    {

        public Frm_Patient_Registration()
        {
            InitializeComponent();
        }



        //ListBox ListItem = new ListBox();

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


        int Auto_Increment()
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) From Patient_Detail";
            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(P_ID) From Patient_Detail";
                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                Cnt = 101;
            }
            Cmd.Dispose();
            return Cnt;
        }

        void Clear_Control()
        {
            tb_Patient_ID.Text = Convert.ToString(Auto_Increment());
            tb_First_Name.Clear();
            tb_Middle_Name.Clear();
            tb_Surname.Clear();
            tb_Pr_Name_On_Frm.Clear();
            dtp_Dob.Text = "";
            tb_Age.Clear();
            tb_MobNo1.Clear();
            tb_MobNo2.Clear();
            tb_Aadhar_Number.Clear();
            tb_Email_Id.Clear();
            rtb_Address.Clear();
            rb_Male.Checked = false;
            rb_Female.Checked = false;
            rb_Yes.Checked = false;
            rb_No.Checked = false;
            rtb_AllergyName.Clear();
            rtb_Sideeffects.Clear();
            tb_First_Name.Focus();
            cb_Referred_By.Text = "";
            lb_Test_Name.Items.Clear();

            clb_Test_Name.SelectedItems.Clear();
            tb_TotalTest.Clear();
            tb_Fees.Text = "";
            cb_Discount.Text = "";
           
            tb_Total_Amount.Text = "0";
            tb_Amount.Clear();
            cb_Cash.Checked = false;
            cb_Check.Checked = false;
            cb_Online.Checked = false;
            rb_Paid.Checked = false;
            rb_Unpaid.Checked = false;
            rtb_Reamark.Clear();
            lb_Test_Name.Items.Clear();
            cb_Discount.Text = "0";

            foreach (int i in clb_Test_Name.CheckedIndices)
            {
                clb_Test_Name.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        void Bind_Data()
        {

            Con_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Distinct (T_Name) from Test_Detail ";

            var Obj = Cmd.ExecuteReader();

            while (Obj.Read())
            {
                clb_Test_Name.Items.Add(Obj.GetString(Obj.GetOrdinal("T_Name")));
            }

            Obj.Dispose();
            Cmd.Dispose();
            Con_Close();
        }

        void Bind_Doctor()
        {

            Con_Open();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
           
            Cmd.CommandText = "Select Distinct (D_FullName) from Doctor_Detail";

            var Obj = Cmd.ExecuteReader();
            while (Obj.Read())
            {
                cmb_DrName.Items.Add(Obj.GetString(Obj.GetOrdinal("D_FullName")));
            }

            Obj.Dispose();
            Cmd.Dispose();
            Con_Close();

        }


        

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Only_Char(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Dash_Board DB = new frm_Dash_Board();
            DB.Show();
            this.Hide();

            frm_Patient P = new frm_Patient();
            P.TopLevel = false;
            DB.pnl_Load.Controls.Add(P);
            P.BringToFront();
            P.Show();
            DB.btn_Patient.Select();
        }

     
        private void Frm_Patient_Registration_Load(object sender, EventArgs e)
        {
            Clear_Control();
            Bind_Data();
            Bind_Doctor();

        }

        private void btn_Item_Click(object sender, EventArgs e)
        {


          /*  {
                lb_Test_Name.Items.Clear();

                foreach (string s in clb_Test_Name.CheckedItems)
                    lb_Test_Name.Items.Add(s);

                tb_TotalTest.Text = lb_Test_Name.Items.Count.ToString();
            }*/
        }

        private void clb_Test_Name_SelectedIndexChanged(object sender, EventArgs e)
        {

            {
                lb_Test_Name.Items.Clear();

                foreach (string s in clb_Test_Name.CheckedItems)
                    lb_Test_Name.Items.Add(s);

                tb_TotalTest.Text = lb_Test_Name.Items.Count.ToString();
            }


            int Amt = 0;

            Con_Open();

            for (int i = 0; i < clb_Test_Name.Items.Count; i++)
            {
                if (clb_Test_Name.GetItemChecked(i))
                {

                    SqlCommand Cmd = new SqlCommand("select T_Price from Test_Detail where T_Name = '" + clb_Test_Name.Items[i] + "'", Con);
                    SqlDataReader Dr = Cmd.ExecuteReader();

                    while (Dr.Read())
                    {
                        Amt = Amt + Convert.ToInt32(Dr["T_Price"].ToString());
                     
                    }

                    Dr.Dispose();
                    Cmd.Dispose();

                }

            }

            tb_Total_Amount.Text = Amt.ToString();
            tb_Fees.Text = Amt.ToString();

            Con_Close();

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string Gender, Allergy, PaidBy, Paid_Status;

            if (tb_First_Name.Text != "" && tb_Middle_Name.Text != "" &&  tb_Surname.Text != "" && tb_Pr_Name_On_Frm.Text != "" && dtp_Dob.Text != "" && tb_Age.Text != "" && tb_MobNo1.Text != "" && tb_Email_Id.Text != "" && tb_TotalTest.Text != "" && tb_Fees.Text != "" && tb_Total_Amount.Text != "" && rtb_Address.Text != "" && (rb_Male.Checked || rb_Female.Checked))
            {
                Con_Open();
                {

                    if (rb_Male.Checked == true)
                    {
                        Gender = "Male";
                    }
                    else
                    {
                        Gender = "Female";
                    }


                    if (rb_Yes.Checked == true)
                    {
                        Allergy = "Yes";
                        rtb_AllergyName.Enabled = true;
                        rtb_Sideeffects.Enabled = true;
                        
                    }
                    else
                    {
                        Allergy = "No";
                        rtb_AllergyName.Enabled = false;
                        rtb_Sideeffects.Enabled = false;
                    }


                    if (cb_Cash.Checked == true)
                    {
                        PaidBy = "Cash";

                    }

                    else if (cb_Check.Checked == true)
                    {
                        PaidBy = "Chek";
                    }
                    else
                    {
                        PaidBy = "Online";
                    }
                }

                if (rb_Paid.Checked == true)
                {
                    Paid_Status = "Paid";
                    rtb_Reamark.Enabled = false;
                }
                else
                {
                    Paid_Status = "Non Paid";
                    rtb_Reamark.Enabled = true;
                }


                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;

                 Cmd.CommandText = "Insert into Patient_Detail(P_ID,P_FName,P_MName,P_Surname,P_FullName,P_Dob,P_Age,P_Gender,P_AadharNo,P_Address,P_MobNo1,P_MobNo2,P_EmailId,P_RefBy,P_RegBy,P_Allergy,P_AllergyName,P_Sideeffects,P_Total_Test,P_Fees,P_Discount,P_TotalAmount,P_PaidBy,P_Payment_Status,P_Remark,P_RegDate,Dr_Name)Values(@ID,@FName,@MName,@Surname,@FullName,@DOB,@Age,@Gender,@AadharNo,@Address,@MobNo1,@MobNo2,@EmailId,@RefBy,@RegBy,@Allergy,@AlgName,@Sideeff,@TotalTest,@fees,@Disc,@Totalamt,@PaidBy,@PayStatus,@Remark,@RegDate,@Drname)";
                //
                Cmd.Parameters.Add("ID", SqlDbType.Int).Value = tb_Patient_ID.Text;
                Cmd.Parameters.Add("FName", SqlDbType.VarChar).Value = tb_First_Name.Text;
                Cmd.Parameters.Add("MName", SqlDbType.VarChar).Value = tb_Middle_Name.Text;
                Cmd.Parameters.Add("Surname", SqlDbType.VarChar).Value = tb_Surname.Text;
                Cmd.Parameters.Add("FullName", SqlDbType.VarChar).Value = tb_Pr_Name_On_Frm.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_Dob.Text;
                Cmd.Parameters.Add("Age", SqlDbType.Int).Value = tb_Age.Text;
                Cmd.Parameters.Add("Gender", SqlDbType.VarChar).Value = Gender;
                Cmd.Parameters.Add("AadharNo", SqlDbType.Decimal).Value = tb_Aadhar_Number.Text;
                Cmd.Parameters.Add("Address", SqlDbType.NVarChar).Value = rtb_Address.Text;
                Cmd.Parameters.Add("MobNo1", SqlDbType.Decimal).Value = tb_MobNo1.Text;
                Cmd.Parameters.Add("MobNo2", SqlDbType.Decimal).Value = tb_MobNo2.Text;
                Cmd.Parameters.Add("EmailId", SqlDbType.NVarChar).Value = tb_Email_Id.Text;
                Cmd.Parameters.Add("RefBy", SqlDbType.VarChar).Value = cb_Referred_By.Text;
                Cmd.Parameters.Add("RegBy", SqlDbType.VarChar).Value = tb_Registered_By.Text;
                Cmd.Parameters.Add("Allergy", SqlDbType.NVarChar).Value = Allergy;
                Cmd.Parameters.Add("AlgName", SqlDbType.NVarChar).Value = rtb_AllergyName.Text;
                Cmd.Parameters.Add("Sideeff", SqlDbType.NVarChar).Value = rtb_Sideeffects.Text;
                Cmd.Parameters.Add("TotalTest", SqlDbType.Int).Value = tb_TotalTest.Text;
                Cmd.Parameters.Add("fees", SqlDbType.Money).Value = tb_Fees.Text;
                Cmd.Parameters.Add("Disc", SqlDbType.Float).Value = cb_Discount.Text;
                Cmd.Parameters.Add("Totalamt", SqlDbType.Money).Value = tb_Total_Amount.Text;
                Cmd.Parameters.Add("PaidBy", SqlDbType.NVarChar).Value = PaidBy;
                Cmd.Parameters.Add("PayStatus", SqlDbType.VarChar).Value = Paid_Status;
                Cmd.Parameters.Add("Remark", SqlDbType.NVarChar).Value = rtb_Reamark.Text;
                Cmd.Parameters.Add("RegDate", SqlDbType.Date).Value = dtp_Date.Text;
                Cmd.Parameters.Add("Drname", SqlDbType.VarChar).Value = cmb_DrName.Text;
                


                Cmd.ExecuteNonQuery();
                Cmd.Dispose();

                if (lb_Test_Name.Items.Count != 0)
                {
                    SqlCommand Cmd1 = new SqlCommand();
                    Cmd1.Connection = Con;

                    foreach (string catgry in lb_Test_Name.Items)
                    {
                        Cmd1.CommandText = "insert into Patient_Test (P_ID,P_Test_Name)values(" + tb_Patient_ID.Text + ",'" + catgry + "')";
                
                       // Cmd1.Parameters.Add("@name", SqlDbType.NVarChar).Value = catgry;
                       
                        Cmd1.ExecuteNonQuery();
                        Cmd1.Dispose();
                    }
                   // MessageBox.Show("Records inserted succesfully.");
                }
                else
                {
                    MessageBox.Show("Error!!!");
                }
                


                MessageBox.Show("Patient Register Successfully...", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Control();
                Con_Close();
            }
            else
            {
                MessageBox.Show("Error...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
        }

        private void cb_Discount_SelectedValueChanged(object sender, EventArgs e)
        {

            if (Convert.ToInt32(tb_Fees.Text) > 0)
            {
                tb_Total_Amount.Text = Convert.ToString(Convert.ToInt32(tb_Fees.Text) - ((Convert.ToInt32(tb_Fees.Text) * Convert.ToInt32(cb_Discount.Text)) / 100));
                tb_Amount.Text = tb_Total_Amount.Text;
            }
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

        private void Auto_Name(object sender, EventArgs e)
        {
            tb_Pr_Name_On_Frm.Text =  tb_First_Name.Text + " " + tb_Middle_Name.Text + " " + tb_Surname.Text;
        }

        private void rb_Yes_Click(object sender, EventArgs e)
        {
            rtb_AllergyName.Enabled = true;
            rtb_Sideeffects.Enabled = true;
        }

        private void rb_No_Click(object sender, EventArgs e)
        {
            rtb_Sideeffects.Enabled = false;
            rtb_AllergyName.Enabled = false;
            rtb_AllergyName.Clear();
            rtb_Sideeffects.Clear();
        }

        private void rb_Paid_Click(object sender, EventArgs e)
        {
            rtb_Reamark.Enabled = false;
            rtb_Reamark.Clear();
        }

        private void rb_Unpaid_Click(object sender, EventArgs e)
        {
            rtb_Reamark.Enabled = true;
        }

        private void cb_Cash_CheckedChanged(object sender, EventArgs e)
        {
            cb_Check.Checked = false;
            cb_Online.Checked = false;
        }

        private void cb_Check_CheckedChanged(object sender, EventArgs e)
        {
            cb_Cash.Checked = false;
            cb_Online.Checked = false;
        }

        private void cb_Online_CheckedChanged(object sender, EventArgs e)
        {
            cb_Cash.Checked = false;
            cb_Check.Checked = false;
        }




        
       
       


    }
}