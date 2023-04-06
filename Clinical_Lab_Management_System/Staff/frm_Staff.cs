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
    public partial class frm_Staff : Form
    {
        public frm_Staff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Staff_Registration obj = new frm_Staff_Registration();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_Update_And_Delete_Staff_Details obj = new frm_Update_And_Delete_Staff_Details();
            obj.Show();
            this.Hide();
        }

        private void btn_Doctors_Record_Click(object sender, EventArgs e)
        {
            frm_Staff_Record obj = new frm_Staff_Record();
            obj.Show();
            this.Hide();
        }

       
    }
}
