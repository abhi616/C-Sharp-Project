using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Clinical_Lab_Management_System
{
    public partial class frm_Doctors_Record : Form
    {
        

        public frm_Doctors_Record()
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
            tb_Doctor_ID.Clear();
            tb_FullName.Clear();
            tb_Gender.Clear();
            dtp_DOB.ResetText();
            tb_Degree.Clear();
            tb_Address.Clear();           
            tb_Mob_No1.Clear();
            tb_Mob_No2.Clear();
            tb_AadharNo.Clear();
            tb_EmailID.Clear();
            pb_Photograph.Image = null;

            tb_Doctor_ID.Focus();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Dash_Board obj = new frm_Dash_Board();
            obj.Show();

            frm_Doctor D = new frm_Doctor();
            D.TopLevel = false;
            obj.pnl_Load.Controls.Add(D);
            D.BringToFront();
            D.Show();
          
        }

        private void frm_Doctors_Record_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinical_Lab_Management_System_DBDataSet16.Doctor_Detail' table. You can move, or remove it, as needed.
            this.doctor_DetailTableAdapter1.Fill(this.clinical_Lab_Management_System_DBDataSet16.Doctor_Detail);
            // TODO: This line of code loads data into the 'clinical_Lab_Management_System_DBDataSet4.Doctor_Detail' table. You can move, or remove it, as needed.
            //this.doctor_DetailTableAdapter.Fill(this.clinical_Lab_Management_System_DBDataSet4.Doctor_Detail);

            
            DateTime DT = DateTime.Now;
            this.dtp_DOB.Text = DT.ToString();          
            this.dtp_Time.Text = DT.ToString();
            this.dtp_Date.Text = DT.ToString();

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            lbl_Photograph.Visible = false;
            lbl_size.Visible = false;

            if (tb_Doctor_ID.Text != "") 
            {
              
                Con_Open();
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Select * From Doctor_Detail Where D_ID = " + tb_Doctor_ID.Text + "";
                SqlDataAdapter da = new SqlDataAdapter(Cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                var Obj = Cmd.ExecuteReader();

                if (Obj.Read())
                {
                    tb_FullName.Text = Obj.GetString(Obj.GetOrdinal("D_FullName"));
                    tb_Gender.Text = Obj.GetString(Obj.GetOrdinal("D_Gender"));
                    dtp_DOB.Text = (Obj["D_DOB"].ToString());
                    tb_Degree.Text = (Obj["D_Degree"].ToString());
                    tb_Address.Text = Obj.GetString(Obj.GetOrdinal("D_Address"));
                    tb_Mob_No1.Text = (Obj["D_MobNo1"].ToString());
                    tb_Mob_No2.Text = (Obj["D_MobNo2"].ToString());
                    tb_AadharNo.Text = (Obj["D_AadhaarNo"].ToString());
                    tb_EmailID.Text = (Obj["D_Email"].ToString());

                  

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["D_Image"]);
                        pb_Photograph.Image = Image.FromStream(ms);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Information Is Not Available Which Your Searching", "No Record Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clear_Control();
                    lbl_Photograph.Visible = true;
                    lbl_size.Visible = true;

                }

                Con_Close();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear_Control();
            lbl_Photograph.Visible = true;
            lbl_size.Visible = true;
        }

       

       /* private void dgv_Doctors_Record_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dgv_Doctors_Record.Rows[index];
            tb_Doctor_ID.Text = row.Cells[0].Value.ToString();
            tb_FullName.Text = row.Cells[4].Value.ToString();
            tb_Gender.Text = row.Cells[7].Value.ToString();
            // dtp_DOB = row.Cells[0].Value.ToString();
            tb_Degree.Text = row.Cells[8].Value.ToString();
            tb_Address.Text = row.Cells[13].Value.ToString();        
            tb_Mob_No1.Text = row.Cells[9].Value.ToString();
            tb_Mob_No2.Text = row.Cells[10].Value.ToString();
            tb_AadharNo.Text = row.Cells[11].Value.ToString();
            tb_EmailID.Text = row.Cells[12].Value.ToString();
            //pb_Photograph.Image = Image.FromStream(row.Cells[21].Value.ToString());
        }*/

       
    }
}