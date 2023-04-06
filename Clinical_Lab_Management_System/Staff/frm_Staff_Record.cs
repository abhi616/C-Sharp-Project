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
    public partial class frm_Staff_Record : Form
    {
      
        public frm_Staff_Record()
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
            tb_FullName.Clear();
            tb_Gender.Clear();
            dtp_DOB.ResetText();
            tb_Post.Clear();
            tb_Address.Clear();
            tb_Shift_Time.Clear();
            tb_Mob_No1.Clear();
            tb_Mob_No2.Clear();
            tb_AadharNo.Clear();
            pb_Photograph.Image = null;

            tb_Staff_ID.Focus();
        }

        private void frm_Staff_Record_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinical_Lab_Management_System_DBDataSet18.Staff_Detail' table. You can move, or remove it, as needed.
            this.staff_DetailTableAdapter1.Fill(this.clinical_Lab_Management_System_DBDataSet18.Staff_Detail);
            // TODO: This line of code loads data into the 'clinical_Lab_Management_System_DBDataSet1.Staff_Detail' table. You can move, or remove it, as needed.
            //this.staff_DetailTableAdapter.Fill(this.clinical_Lab_Management_System_DBDataSet1.Staff_Detail);

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            lbl_Photograph.Visible = false;
            lbl_size.Visible = false;

            if (tb_Staff_ID.Text != "") 
            {
              
                Con_Open();
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Select * From Staff_Detail Where S_ID = " + tb_Staff_ID.Text + "";
                SqlDataAdapter da = new SqlDataAdapter(Cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                var Obj = Cmd.ExecuteReader();

                if (Obj.Read())
                {
                    tb_FullName.Text = Obj.GetString(Obj.GetOrdinal("S_FName")) + " " + Obj.GetString(Obj.GetOrdinal("S_MName")) + " "+ Obj.GetString(Obj.GetOrdinal("S_Surname"));
                    tb_Gender.Text = Obj.GetString(Obj.GetOrdinal("S_Gender"));
                    dtp_DOB.Text = (Obj["S_Dob"].ToString());
                    tb_Post.Text = Obj.GetString(Obj.GetOrdinal("S_Post"));
                    tb_Address.Text = Obj.GetString(Obj.GetOrdinal("S_Address"));
                    tb_Shift_Time.Text = Obj.GetString(Obj.GetOrdinal("S_ShiftTime"));
                    tb_Mob_No1.Text = (Obj["S_MobNo1"].ToString());
                    tb_Mob_No2.Text = (Obj["S_MobNo2"].ToString());
                    tb_AadharNo.Text = (Obj["S_AadhaarNo"].ToString());

                  

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["S_Image"]);
                        pb_Photograph.Image = Image.FromStream(ms);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Information Is Not Available Which Your Searching", "No Record Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clear_Control();

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

      

      /* private void dgv_Staff_Record_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dgv_Staff_Record.Rows[index];
            tb_Staff_ID.Text = row.Cells[0].Value.ToString();
            tb_FullName.Text = row.Cells[4].Value.ToString();
            tb_Gender.Text = row.Cells[7].Value.ToString();
            dtp_DOB.Text = row.Cells[5].Value.ToString();
            tb_Post.Text = row.Cells[9].Value.ToString();
            tb_Address.Text = row.Cells[14].Value.ToString();
            tb_Shift_Time.Text = row.Cells[19].Value.ToString();
            tb_Mob_No1.Text = row.Cells[10].Value.ToString();
            tb_Mob_No2.Text = row.Cells[11].Value.ToString();
            tb_AadharNo.Text = row.Cells[12].Value.ToString();

         
            //pb_Photograph.Image = Image.FromStream(row.Cells[21].Value.ToString());
        }*/

        

    }
}


 