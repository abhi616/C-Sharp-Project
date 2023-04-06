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
    public partial class frm_Test_Record : Form
    {
        public frm_Test_Record()
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
            //rtb_Description.Clear();
        }

        private void frm_Test_Record_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinical_Lab_Management_System_DBDataSet12.Test_Detail' table. You can move, or remove it, as needed.
            this.test_DetailTableAdapter.Fill(this.clinical_Lab_Management_System_DBDataSet12.Test_Detail);

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Dash_Board obj = new frm_Dash_Board();
            obj.Show();
            this.Hide();

            //frm_Test D = new frm_Test();
            //D.TopLevel = false;
            //obj.pnl_Load.Controls.Add(D);
            //D.BringToFront();
            //D.Show();
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
                    //rtb_Description.Text = Obj.GetString(Obj.GetOrdinal("T_Description"));


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
        }

       
    }
}
