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
        public DataEntry()
        {
            InitializeComponent();
           
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
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6CV5ARA\SQLEXPRESS;Initial Catalog=AOAPROJECT;Integrated Security=True");
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into customerdata values ('" + textCName.Text + "','" + textCPhoneNo.Text +"','"+ textCAddress.Text +  "','" + textCEmail.Text + "')";
            cmd.ExecuteNonQuery();
            textCName.Text = "";
            textCAddress.Text = "";
            textCPhoneNo.Text = "";
            textCEmail.Text = "";
            con.Close();


            this.Hide();
            Parcel_Delivery pa = new Parcel_Delivery();
            pa.Show();
        }
    }
}
