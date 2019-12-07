using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Courier_Service_Company
{
    public partial class Result : Form
    {
        int tempCost = 0;
        string tempPath = "";
        
        public Result()
        {
            InitializeComponent();
            display();
        }
        public Result(int tempC,string tempP)
        {
            InitializeComponent();

            tempCost = tempC;
            tempPath = tempP;
             

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            display();
        }
        void display()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1J68T8\SQLEXPRESS;Initial Catalog=AOAPROJECT;Integrated Security=True");
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from customerdata";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
            /*
            DataTable DT = new DataTable();
            SqlDataAdapter SDA1 = new SqlDataAdapter("SELECT * FROM  customerdata", con);
            SDA1.Fill(DT);
            SqlDataAdapter SDA2 = new SqlDataAdapter("SELECT * FROM  parceldata", con);
            SDA2.Fill(DT);
            dataGridView1.DataSource = DT;
            */
            /*
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from customerdata,parceldata";
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;
            con.Close();
            */

        }

        private void Result_Load(object sender, EventArgs e)
        {
            Rcost.Text = Convert.ToString(tempCost);
            RPath.Text = tempPath;
            display();
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
