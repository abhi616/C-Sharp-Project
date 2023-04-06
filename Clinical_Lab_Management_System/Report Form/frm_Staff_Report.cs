using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;

namespace Clinical_Lab_Management_System
{
    public partial class frm_Staff_Report : Form
    {
        public frm_Staff_Report()
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



        private void frm_Staff_Report_Load(object sender, EventArgs e)
        {

            this.crystalReportViewer1.RefreshReport();
        }

        private void btn_ShowReport_Click(object sender, EventArgs e)
        {
            Con_Open();
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"D:\Clinical_Lab_Management_System\Clinical_Lab_Management_System\Project Reports\Staff_CrystalReport1.rpt");

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();


            Con_Close();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            frm_Medical obj = new frm_Medical();
            this.Hide();
            obj.Show();
        }
    }
}
