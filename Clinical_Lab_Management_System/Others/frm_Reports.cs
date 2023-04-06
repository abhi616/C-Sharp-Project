using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinical_Lab_Management_System.Report_Form;

namespace Clinical_Lab_Management_System
{
    public partial class frm_Medical : Form
    {
        public frm_Medical()
        {
            InitializeComponent();
        }

        private void btn_Patient_Report_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Staff_Report_Click(object sender, EventArgs e)
        {
            frm_Staff_Report SR = new frm_Staff_Report();
            SR.Show();
            this.Hide();
        }

        private void btn_Doctor_Report_Click(object sender, EventArgs e)
        {
            frm_Doctor_Report DR = new frm_Doctor_Report();
            DR.Show();
            this.Hide();
        }

        private void btn_Test_Report_Click(object sender, EventArgs e)
        {
            frm_Test_Report TR = new frm_Test_Report();
            TR.Show();
            this.Hide();
        }
    }
}
