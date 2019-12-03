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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String txtname, txtuserName, txtpassword;
            txtname = "Usama123";
            txtuserName = "usama_123";
            txtpassword = "090078601";
            if (textname.Text == txtname && textUserName.Text == txtuserName && textPassword.Text == txtpassword)
            {
                Data dt = new Data();
                dt.Show();
            }
            else
            {
                MessageBox.Show("INVALID USERNAME OR PASSWORD");
            }
                
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
