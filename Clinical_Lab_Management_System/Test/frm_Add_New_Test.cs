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
    public partial class frm_Add_New_Test : Form
    {
        public frm_Add_New_Test()
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


        void Clear_Controls()
        {
            tb_Test_ID.Text = Convert.ToString(Auto_Increment());
            tb_Test_Category.Text = "";
            tb_Unit.Clear();
            tb_Test_Name.Clear();
            tb_Price.Clear();
            tb_Upper_Range.Clear();
            tb_Lower_Range.Clear();
            rtb_Description.Clear();
            tb_Test_Category.Focus();
        }


        int Auto_Increment()
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) From Test_Detail";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(T_ID) From Test_Detail";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;

            }
            else
            {
                Cnt = 1;
            }

            Cmd.Dispose();

            Con_Close();

            return Cnt;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        void Bind_Grid()
        {

            Con_Open();
            dgv_Test_Details.DataSource = "";

            SqlDataAdapter SDA = new SqlDataAdapter("Select * From Test_Detail", Con);

            DataTable Dt = new DataTable();

            SDA.Fill(Dt);

            dgv_Test_Details.DataSource = Dt;

            Con_Close();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void tb_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (tb_Test_Category.Text != "" && tb_Test_Name.Text != "" && tb_Upper_Range.Text != "" && tb_Lower_Range.Text != "" && tb_Unit.Text != "" && tb_Price.Text != "")
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Test_Detail(T_ID,T_Category,T_Name,T_Lo_Range,T_Up_Range,T_Unit,T_Price,T_Description,T_Reg_Date) values(@TID,@TCat,@TName,@TLRange,@TURange,@TUnit,@TCharge,@TDesc,@T_Reg_Date)";

                Cmd.Parameters.Add("TID", SqlDbType.Int).Value = tb_Test_ID.Text;
                Cmd.Parameters.Add("TCat", SqlDbType.VarChar).Value = tb_Test_Category.Text;
                Cmd.Parameters.Add("TName", SqlDbType.VarChar).Value = tb_Test_Name.Text;               
                Cmd.Parameters.Add("TLRange", SqlDbType.Int).Value = tb_Lower_Range.Text;
                Cmd.Parameters.Add("TURange", SqlDbType.Int).Value = tb_Upper_Range.Text;
                Cmd.Parameters.Add("TUnit", SqlDbType.NVarChar).Value = tb_Unit.Text;
                Cmd.Parameters.Add("TCharge", SqlDbType.Int).Value = tb_Price.Text;
                Cmd.Parameters.Add("TDesc", SqlDbType.NVarChar).Value = rtb_Description.Text;
                Cmd.Parameters.Add("T_Reg_Date", SqlDbType.Date).Value = dtp_Date.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Test Added Successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
                Bind_Grid();
            }
            else
            {
                MessageBox.Show("Incomplete Information", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Test_Category.Focus();
            }
        }

        private void frm_Add_New_Test_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinical_Lab_Management_System_DBDataSet17.Test_Detail' table. You can move, or remove it, as needed.
            this.test_DetailTableAdapter3.Fill(this.clinical_Lab_Management_System_DBDataSet17.Test_Detail);
            // TODO: This line of code loads data into the 'clinical_Lab_Management_System_DBDataSet10.Test_Detail' table. You can move, or remove it, as needed.
            this.test_DetailTableAdapter2.Fill(this.clinical_Lab_Management_System_DBDataSet10.Test_Detail);
            Clear_Controls();

           
            DateTime DT = DateTime.Now;
            dtp_Time.Value = DateTime.Now;

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            frm_Dash_Board obj = new frm_Dash_Board();
            this.Hide();
            obj.Show();
        }

        private void dgv_Test_Details_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
