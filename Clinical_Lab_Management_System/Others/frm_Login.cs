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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

       
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Clinical_Lab_Management_System_DB;Integrated Security=True");
        void con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        void con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

           
                //if(tb_Username.Text == "" && tb_Password.Text == "" )
                //{
                //   MessageBox.Show("Login Successful");
                //    frm_Dash_Board Obj = new frm_Dash_Board();
                //    Obj.Show();
                //    this.Hide();
                //}
            



            con_Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            cmd.CommandText = "Select * From Login Where Username = @uname And Password = @pass";

            cmd.Parameters.Add("uname",SqlDbType.NVarChar).Value = tb_Username.Text;
             cmd.Parameters.Add("pass", SqlDbType.NVarChar).Value = tb_Password.Text;

            string Ret = Convert.ToString(cmd.ExecuteScalar());


            if (Ret == tb_Username.Text && tb_Username.Text != "")
            {
               
                MessageBox.Show("Login Successfully......", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_Dash_Board Obj = new frm_Dash_Board();
                Obj.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Please Check Username Or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            tb_Username.Clear();
            tb_Password.Clear();

            tb_Username.Focus();
            
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        
        {
            Application.Exit();
        }

      
        
    }
}






 