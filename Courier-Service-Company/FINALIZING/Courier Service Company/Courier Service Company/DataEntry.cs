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
    public partial class DataEntry : Form
    {
        int tempCost = 0;
        string tempPath = "";
        public DataEntry()
        {
            InitializeComponent();
           
        }
        public DataEntry(int tempC,string tempP)
        {
            InitializeComponent();
             tempCost = tempC;
             tempPath = tempP;

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textCName.Text == "")
            {
                MessageBox.Show("Please Enter the Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textCPhoneNo.Text == "")
            {
                MessageBox.Show("Please Enter the Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textCAddress.Text == "")
            {
                MessageBox.Show("Please Enter the Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textCEmail.Text == "")
            {
                MessageBox.Show("Please Enter the Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            /*
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1J68T8\SQLEXPRESS;Initial Catalog=AOAPROJECT;Integrated Security=True");
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into customerdata(Name,PhoneNo,Address,Email) values ('" + textCName.Text + "','" + textCPhoneNo.Text +"','"+ textCAddress.Text +  "','" + textCEmail.Text + "')";
            cmd.ExecuteNonQuery();
            */
            String Name=textCName.Text ;
            String Address=textCAddress.Text ;
            String PhoneNo =textCPhoneNo.Text ;
            String Email=textCEmail.Text ;
           // con.Close();


            this.Hide();
            Parcel_Delivery pa = new Parcel_Delivery(tempCost,tempPath,Name,PhoneNo,Address,Email);
            pa.Show();
        }

        private void DataEntry_Load(object sender, EventArgs e)
        {

        }
    }
}
