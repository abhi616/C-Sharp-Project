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
    public partial class frm_Patient_Records : Form
    {
        public frm_Patient_Records()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Clinical_Lab_Management_System_DB;Integrated Security=True");

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
            frm_Dash_Board obj = new frm_Dash_Board();
            obj.Show();

            frm_Patient D = new frm_Patient();
            D.TopLevel = false;
            obj.pnl_Load.Controls.Add(D);
            D.BringToFront();
            D.Show();
           
        }

        void Bind_Grid()
        {
            Con_Open();

            dgv_PatientRecord.DataSource = "";

            SqlDataAdapter SDA = new SqlDataAdapter("Select * From Patient_Detail", Con);

            DataTable dt = new DataTable();

            SDA.Fill(dt);

            dgv_PatientRecord.DataSource = dt;

            Con_Close();
        }

        private void frm_Patient_Records_Load(object sender, EventArgs e)
        {
            Bind_Grid();
        }

        
    }
}
