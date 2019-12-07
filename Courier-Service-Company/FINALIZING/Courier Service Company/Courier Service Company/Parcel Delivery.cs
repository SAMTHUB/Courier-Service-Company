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
        int tempCost = 0;
        string tempPath = "";
        String Name1;
        String PhoneNo1;
        String Address1;
        String Email1;
        public Parcel_Delivery()
        {
            InitializeComponent();
        }

        public Parcel_Delivery(int tempC,string tempP,string n,string p ,string a,string e)
        {
            InitializeComponent();
            tempCost = tempC;
            tempPath = tempP;
            Name1 = n;
            PhoneNo1 = p;
            Address1 = a;
            Email1 = e;
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
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1J68T8\SQLEXPRESS;Initial Catalog=AOAPROJECT;Integrated Security=True");
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into customerdata values ('"+Name1 + "','" +PhoneNo1 + "','" + Address1+ "','" +Email1 +"','" + textPNum.Text + "','" + textPFee.Text + "','" + textPDate.Text + "','" + textPClaim.Text + "','" + textPDes.Text + "','" +textPItem.Text+ "')";
            cmd.ExecuteNonQuery();
            textPNum.Text = "";
            textPFee.Text = "";
            textPDate.Text = "";
            textPClaim.Text = "";
            textPDes.Text = "";
            textPItem.Text = "";
            con.Close();


            this.Hide();
            Result pa = new Result(tempCost,tempPath);
            pa.Show();
        }

        private void textPNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void Parcel_Delivery_Load(object sender, EventArgs e)
        {

        }
    }
}
