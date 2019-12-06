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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Info Check = new Info();
            Check.Show();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Info Check = new Info();
            Check.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if(textUserName.Text=="")
            {
                MessageBox.Show("Please Enter the User Name","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (textPassword.Text == "")
            {
                MessageBox.Show("Please Enter the Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-6CV5ARA\SQLEXPRESS;Initial Catalog=AOAPROJECT;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from login where userName= @username and password=@password ", con);
            cmd.Parameters.AddWithValue("userName", textUserName.Text);
            cmd.Parameters.AddWithValue("password", textPassword.Text);
            //cmd.Parameters.AddWithValue("passsword", textPassword.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (dt.Rows.Count > 0)
            {
                this.Hide();
                Data Check = new Data();
                Check.Show();
           
            }
            else
            {
                MessageBox.Show("You are not Registered");

            }

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Info Check = new Info();
            Check.Show();
            
        }
    }
}
