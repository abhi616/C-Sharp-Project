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
    public partial class frm_Doctor : Form
    {
        public frm_Doctor()
        {
            InitializeComponent();
        }

       

        private void btn_Update_And_Delete_Dr_Click(object sender, EventArgs e)
        {
            frm_Update_And_Delete_Doctor_Details UD = new frm_Update_And_Delete_Doctor_Details();
            UD.Show();
            this.Hide();

        }

        private void btn_Doctors_Record_Click(object sender, EventArgs e)
        {
            frm_Doctors_Record DR = new frm_Doctors_Record();
            DR.Show();
            this.Hide();
        }

        private void btn_New_Dr_Registration_Click(object sender, EventArgs e)
        {
            frm_Doctors_Registration FD = new frm_Doctors_Registration();
            FD.Show();
            this.Hide();
        }

        
    }
}
