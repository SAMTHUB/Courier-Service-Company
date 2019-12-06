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
    public partial class Parcel_Delivery : Form
    {
        public Parcel_Delivery()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (textPNum.Text == "")
            {
                MessageBox.Show("Please Enter the Delivery Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textPFee.Text == "")
            {
                MessageBox.Show("Please Enter the Delivery Fee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textPDate.Text == "")
            {
                MessageBox.Show("Please Enter the Data and Time", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textPClaim.Text == "")
            {
                MessageBox.Show("Please Enter the Claim", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textPDes.Text == "")
            {
                MessageBox.Show("Please Enter the Description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textPItem.Text == "")
            {
                MessageBox.Show("Please Enter the Item Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            cmd.CommandText = "insert into parceldata values ('" + textPNum.Text + "','" + textPFee.Text + "','" + textPDate.Text + "','" + textPClaim.Text + "','" + textPDes.Text + "','" +textPItem.Text+ "')";
            cmd.ExecuteNonQuery();
            textPNum.Text = "";
            textPFee.Text = "";
            textPDate.Text = "";
            textPClaim.Text = "";
            textPDes.Text = "";
            textPItem.Text = "";
            con.Close();


            this.Hide();
            Result pa = new Result();
            pa.Show();
        }

        private void textPNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
