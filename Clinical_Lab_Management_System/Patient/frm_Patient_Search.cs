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
    public partial class frm_Update_Patient : Form
    {
        public frm_Update_Patient()
        {
            InitializeComponent();
        }

        void Clear_Control()
        {
            tb_Patient_ID.Clear();
            tb_Pr_Name_On_Frm.Clear();
            tb_2nd_Mobile_No.Clear();
            tb_Mob_No.Clear();
            tb_AadhaarNo.Clear();
            tb_Email_Id.Clear();
            tb_Address.Clear();
            lb_Test_Name.Items.Clear();
            tb_Amount.Clear();
            tb_ReferedBy.Clear();
        }


        Bitmap memoryImage;

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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Dash_Board DB = new frm_Dash_Board();
            DB.Show();

            frm_Patient P = new frm_Patient();
            P.TopLevel = false;
            DB.pnl_Load.Controls.Add(P);
            P.BringToFront();
            P.Show();
           // this.Hide();
            DB.btn_Patient.Select();
        
        }

        private void btb_Search_Click(object sender, EventArgs e)
        {
            lb_Test_Name.Items.Clear();
            if (tb_Patient_ID.Text != "")
            {
                Con_Open();

                Con_Open();

                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Select * From Patient_Detail Where P_ID = " + tb_Patient_ID.Text + "";
                var Obj = Cmd.ExecuteReader();

                if (Obj.Read())
                {
                    tb_Pr_Name_On_Frm.Text = Obj.GetString(Obj.GetOrdinal("P_FullName"));
                    tb_Mob_No.Text = (Obj["P_MobNo1"].ToString());
                    tb_2nd_Mobile_No.Text = (Obj["P_MobNo1"].ToString());
                    tb_AadhaarNo.Text = (Obj["P_AadharNo"].ToString());
                    tb_Email_Id.Text = Obj.GetString(Obj.GetOrdinal("P_EmailID"));
                    tb_Address.Text = Obj.GetString(Obj.GetOrdinal("P_Address"));
                    tb_ReferedBy.Text = Obj.GetString(Obj.GetOrdinal("P_RefBy"));
                    tb_Amount.Text = (Obj["P_TotalAmount"].ToString());

                    Obj.Dispose();
                    Cmd.Dispose();

                    Cmd.CommandText = "Select P_Test_Name from Patient_Test where P_ID = " + tb_Patient_ID.Text + "";

                    SqlDataReader Sdr = Cmd.ExecuteReader();

                    while (Sdr.Read())
                    {
                        lb_Test_Name.Items.Add(Sdr.GetString(Sdr.GetOrdinal("P_Test_Name")));
                    }

                    Obj.Dispose();
                    Cmd.Dispose();
                }
                else
                {
                    Clear_Control();

                }

               
            }

            else
            {
                MessageBox.Show("Information Is Not Available Which Your Searching", "No Record Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // Clear_Control();
            }

                Con_Close();
            
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);

            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
   
               e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        Bitmap bitmap;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear_Control();
        } 
    }
}
