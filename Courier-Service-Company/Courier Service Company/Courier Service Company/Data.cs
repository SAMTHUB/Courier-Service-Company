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
            txt_CityName.Enabled = false;
            btn_OKcityName.Enabled = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            size = Convert.ToInt32(txt_cities.Text);
            if (size>0)
            {
                txt_cities.Enabled = false;
                txt_CityName.Enabled = true;
                Array.Resize<string>(ref cities, size);
                btn_OKcities.Enabled = true;
                btn_OKcityName.Enabled = true;

            }
            else
            {
                txt_cities.Text = "";
                MessageBox.Show("Input Value must be Greater than 0");
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

            if(string.IsNullOrEmpty(txt_CityName.Text)||string.IsNullOrWhiteSpace(txt_CityName.Text))
            {
                MessageBox.Show("Fill the Fields Properly & Empty Fields Not Allowed ");
            }
            else
            {
                int z = 0;
                for(z=0;z<count;z++)
                {
                    if (string.Equals(txt_CityName.Text, cities[z], StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Name Already Entered");
                        break;
                    }
                }
                if (!string.Equals(txt_CityName.Text, cities[z], StringComparison.OrdinalIgnoreCase))
                {
                    cities[count] = txt_CityName.Text;
                    count++;
                    txt_CityName.Text = "";
                }
            }
            if(count==size)
            {
                txt_CityName.Enabled = false;
                btn_OKcityName.Enabled = false;
                MessageBox.Show("Data Entered");
                txt_CityName.Enabled = false;
                Distance dt = new Distance(size);
                dt.Show();
                this.Hide();
            }
        }

        private void txt_cities_validating(object sender, CancelEventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(txt_cities.Text, out parsedValue))
            {
                e.Cancel = true;
                errorProvider1.SetError(txt_cities, "Integer Only");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt_cities, null);
            }
        }
    }
   
}
