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
    public partial class frm_Update_Test : Form
    {
        public frm_Update_Test()
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
            tb_Test_ID.Clear();
            tb_Test_Name.Clear();
            tb_Test_Category.Clear();
            tb_Lower_Range.Clear();
            tb_Price.Clear();
            tb_Unit.Clear();
            tb_Upper_Range.Clear();
            rtb_Description.Clear();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Dash_Board obj = new frm_Dash_Board();
            obj.Show();

            frm_Test D = new frm_Test();
            D.TopLevel = false;
            obj.pnl_Load.Controls.Add(D);
            D.BringToFront();
            D.Show();
        }

        

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (tb_Test_Name.Text != "" && tb_Test_Category.Text != "" && tb_Lower_Range.Text != "" && tb_Upper_Range.Text != "" && tb_Unit.Text != "" && tb_Price.Text != "" && rtb_Description.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Update Test_Detail Set T_Category = @TCat , T_Name = @TName , T_Lo_Range = @TLRange , T_Up_Range = @TURange , T_Unit = @TUnit , T_Price = @TCharge , T_Description = @TDesc where T_ID = " + tb_Test_ID.Text + " ";
               // Cmd.CommandText = "update Test_Detail set T_Category='" + tb_Test_Category.Text + "',T_Name='" + tb_Test_Name.Text + "',T_Lo_Range='" + tb_Lower_Range.Text + "',T_Up_Range='" + tb_Upper_Range.Text + "',T_Unit'" + tb_Unit.Text + "',T_Price'" + tb_Price.Text + "',T_Description'" + rtb_Description.Text;
                
                Cmd.Parameters.Add("TCat", SqlDbType.VarChar).Value = tb_Test_Category.Text;
                Cmd.Parameters.Add("TName", SqlDbType.VarChar).Value = tb_Test_Name.Text;
                Cmd.Parameters.Add("TLRange", SqlDbType.Int).Value = tb_Lower_Range.Text;
                Cmd.Parameters.Add("TURange", SqlDbType.Int).Value = tb_Upper_Range.Text;
                Cmd.Parameters.Add("TUnit", SqlDbType.NVarChar).Value = tb_Unit.Text;
                Cmd.Parameters.Add("TCharge", SqlDbType.Int).Value = tb_Price.Text;
                Cmd.Parameters.Add("TDesc", SqlDbType.NVarChar).Value = rtb_Description.Text;
            
                Cmd.ExecuteNonQuery();
            
                
                MessageBox.Show("Test Details Update Successfully...", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Control();
                Con_Close();

            }

            else
            {
                MessageBox.Show("Somthing Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear_Control();
                tb_Test_ID.Focus();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_Test_ID.Text != "")
            {
 
                Con_Open();

                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Select * From Test_Detail Where T_ID = " + tb_Test_ID.Text + "";
                var Obj = Cmd.ExecuteReader();

                if (Obj.Read())
                {
                    tb_Test_Name.Text = Obj.GetString(Obj.GetOrdinal("T_Name"));
                    tb_Price.Text = (Obj["T_Price"].ToString());
                    tb_Lower_Range.Text = (Obj["T_Lo_Range"].ToString());
                    tb_Upper_Range.Text = (Obj["T_Up_Range"].ToString());
                    tb_Unit.Text = (Obj["T_Unit"].ToString());                 
                    tb_Test_Category.Text = Obj.GetString(Obj.GetOrdinal("T_Category")); 
                    rtb_Description.Text = Obj.GetString(Obj.GetOrdinal("T_Description"));


                }

                else
                {
                    MessageBox.Show("Information Is Not Available Which Your Searching", "No Record Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clear_Control();
                }

                Con_Close();
              
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
           // frm_Dash_Board obj = new frm_Dash_Board();
            this.Hide();

         
        }
    }
}
