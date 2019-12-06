using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Courier_Service_Company
{
    public partial class Data : Form
    {
        public int size = 0;
        public static string[] cities;
        public int count = 0;
        public Data()
        {
            InitializeComponent();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Data_Load(object sender, EventArgs e)
        {
            textnameofcities.Enabled = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            size = Convert.ToInt32(textcities.Text);
            if (size>0)
            {
                textnameofcities.Enabled = true;
                Array.Resize<string>(ref cities, size);
                textcities.Enabled = false;

            }
            else
            {
                textcities.Text = "";
                MessageBox.Show("Enter Value Greater than 0");
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Textnameofcities_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(textnameofcities.Text)||string.IsNullOrWhiteSpace(textnameofcities.Text))
            {
                MessageBox.Show("Fill the Feilds Properly OR Spaces and Empty Fields Not Allowed ");
            }
            else
            {
                int z = 0;
                for(z=0;z<count;z++)
                {
                    if (string.Equals(textnameofcities.Text, cities[z], StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Name Already Entered");
                        break;
                    }
                }
                if (!string.Equals(textnameofcities.Text, cities[z], StringComparison.OrdinalIgnoreCase))
                {
                    cities[count] = textnameofcities.Text;
                    count++;
                    textnameofcities.Text = "";
                }
            }
            if(count>=size)
            {
                MessageBox.Show("Data Entered");
                textnameofcities.Enabled = false;
                Distance dt = new Distance();
                dt.Show();
                this.Hide();

            }
            
           
            
        }
        
    }
   
}
