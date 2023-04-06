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
    public partial class frm_Dash_Board : Form
    {
        public frm_Dash_Board()
        {
            InitializeComponent();
        }

        private void btn_Doctor_Click(object sender, EventArgs e)
        {
            frm_Doctor D = new frm_Doctor();
            D.TopLevel = false;
            pnl_Load.Controls.Add(D);
            D.BringToFront();
            D.Show();

            btn_Doctor.Select();
        }

        private void frm_Dash_Board_Load(object sender, EventArgs e)
        {
   
            frm_Main_Dashboard MD = new frm_Main_Dashboard();
            MD.TopLevel = false;
            pnl_Load.Controls.Add(MD);
            MD.BringToFront();
            MD.Show();

            btn_Dashboard.Select();
        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            frm_Staff S = new frm_Staff();
            S.TopLevel = false;
            pnl_Load.Controls.Add(S);
            S.BringToFront();
            S.Show();

            btn_Staff.Select();

        }

        private void btn_Patient_Click(object sender, EventArgs e)
        {
            frm_Patient P = new frm_Patient();
            P.TopLevel = false;
            pnl_Load.Controls.Add(P);
            P.BringToFront();
            P.Show();

            btn_Patient.Select();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            frm_Main_Dashboard M = new frm_Main_Dashboard();
            M.TopLevel = false;
            pnl_Load.Controls.Add(M);
            M.BringToFront();
            M.Show();

            btn_Dashboard.Select();
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            frm_Test T = new frm_Test();
            T.TopLevel = false;
            pnl_Load.Controls.Add(T);
            T.BringToFront();
            T.Show();

            btn_Test.Select();
        }

        private void btn_Medical_Click(object sender, EventArgs e)
        {
            frm_Medical M = new frm_Medical();
            M.TopLevel = false;
            pnl_Load.Controls.Add(M);
            M.BringToFront();
            M.Show();

            btn_Report.Select();
        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            Application.Exit();

           /* DialogResult result;
            result = MessageBox.Show("Are you Sure", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.No)
            {
                frm_Login FL = new frm_Login();

                FL.Show();

                this.Hide();
                
            }*/

        }

        private void btn_Delete_Record_Click(object sender, EventArgs e)
        {

        }

        private void pnl_Load_Paint(object sender, PaintEventArgs e)
        {

        }

        

       
    }
}
