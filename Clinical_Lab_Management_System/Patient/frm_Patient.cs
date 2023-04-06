using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinical_Lab_Management_System
{
    public partial class frm_Patient : Form
    {
        public frm_Patient()
        {
            InitializeComponent();
        }

        private void btn_Patient_Registration_Click(object sender, EventArgs e)
        {
            
            Frm_Patient_Registration PR = new Frm_Patient_Registration();
            PR.Show();
            this.Hide();
           
        }

        private void btn_Patient_Record_Click(object sender, EventArgs e)
        {
            frm_Patient_Records PR = new frm_Patient_Records();
            PR.Show();
            this.Hide();
        }

        private void btn_Patient_Receipt_Click(object sender, EventArgs e)
        {
            frm_Update_Patient UP = new frm_Update_Patient();
            UP.Show();
            this.Hide();
        }

       
       
    }
}
