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
    public partial class Info : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1J68T8\SQLEXPRESS;Initial Catalog=AOAPROJECT;Integrated Security=True");
        public Info()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into login values('" + textname.Text + "','" + textUserName.Text + "','" + textPassword.Text + "')";
            cmd.ExecuteNonQuery();
            textname.Text = "";
            textUserName.Text = "";
            textPassword.Text = "";
            MessageBox.Show("Signed up Successfully");
            Form1 a = new Form1();
            a.Show();
            this.Hide();
                
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Textname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Info_Load(object sender, EventArgs e)
        {
            if(con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

        }

        private void Login_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J1J68T8\SQLEXPRESS;Initial Catalog=AOAPROJECT;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from login where name= @name and username=@username and password=@password", con);
            cmd.Parameters.AddWithValue("name", textname.Text);
            cmd.Parameters.AddWithValue("username", textUserName.Text);
            cmd.Parameters.AddWithValue("passsword", textPassword.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (dt.Rows.Count > 0)
            {
                Data data = new Data();
                data.Show();
            }
            else
            {
                MessageBox.Show("Your username and word is incorrect");
               
            }


            
        }
    }
}
