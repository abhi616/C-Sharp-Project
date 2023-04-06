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
    public partial class frm_Test : Form
    {
        public frm_Test()
        {
            InitializeComponent();
        }

       

        private void btn_Add_New_Test_Click(object sender, EventArgs e)
        {
            frm_Add_New_Test ANT = new frm_Add_New_Test();
            ANT.Show();
            this.Hide();
            
        }

        private void btn_Update_Test_Click(object sender, EventArgs e)
        {
            frm_Update_Test UT = new frm_Update_Test();
            UT.Show();
            
        }

        private void btn_Test_Record_Click(object sender, EventArgs e)
        {
            frm_Test_Record TR = new frm_Test_Record();
            TR.Show();
            this.Hide();
                
        }

        

        

       
    }
}
