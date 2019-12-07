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

    public partial class Distance : Form
    {
        string show = "";
        int size = 0;
        List<nameofCities> costs = new List<nameofCities>();
        int s = 0;
        int i = 0;
        int j = 1;
        int tempCost = 0;
        string tempPath = "";
        int min_path = Int32.MaxValue;
        static List<int> vertex = new List<int>();
        
        static int[] path = { 0 };
        public Distance()
        {
            InitializeComponent();
        }

        
        public Distance(int s)
        {
            size = s;
            for (int l = 0; l < size; l++)
            {
                 costs.Add(new nameofCities());
                for (int m = 0; m < size; m++)
                {
                    costs[l].Arr.Add(0);
                }
            }
            InitializeComponent();
        }
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DataEntry c = new DataEntry(tempCost,tempPath);
            c.Show();
        }

        private void Distance_Load(object sender, EventArgs e)
        {
            citieslabel.Text = "Enter Cost from  \n" + Data.cities[i].ToUpper() + "  to  " + Data.cities[j].ToUpper();
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

      
        public static void swap(int left, int right)
        {
       int temp = vertex[left];
            vertex[left] = vertex[right];
            vertex[right] = temp;

           
        }

        
        public static void reverse(int left, int right)
        {

           
            while (left < right)
            {
                int temp = vertex[left];
                vertex[left++] = vertex[right];
                vertex[right--] = temp;
            }

        }

       
        public static bool findNextPermutation()
        {

            if (vertex.Count <= 1)
                return false;

            int last = vertex.Count - 2;

            while (last >= 0)
            {
                if (vertex[last] < vertex[last + 1])
                {
                    break;
                }
                last--;
            }

            if (last < 0)
                return false;

            int nextGreater = vertex.Count - 1;

            for (int ii = vertex.Count - 1; ii > last; ii--)
            {
                if (vertex[ii] > vertex[last])
                {
                    nextGreater = ii;
                    break;
                }
            }

        
            swap(nextGreater, last);

            
            reverse(last + 1, vertex.Count - 1);

            return true;
        }




        private void TSP()
        {

           
            for (int o = 0; o < size; o++)
                if (o != s)
                    vertex.Add(o);

            int[] low_path = { 0 };
            Array.Resize<int>(ref low_path, size + 1);
       
            do
            {

                int current_pathweight = 0;

                Array.Resize<int>(ref path, size);
                path.Initialize();
                
                int k = s;
                path[0] = s;
                for (int i = 0; i < vertex.Count; i++)
                {
                    current_pathweight += costs[k].Arr[vertex[i]];
                    path[i + 1] = vertex[i];
                    k = vertex[i];
                }
                current_pathweight += costs[k].Arr[s];

               
                int chk = min_path;
                min_path = Math.Min(min_path, current_pathweight);
                
                if (min_path != chk)
                {
                    for (int j = 0; j < size; j++)
                    {
                        low_path[j] = path[j];
                    }
                }

            } while (findNextPermutation());
            low_path[size] = s;



            for (int ii = 0; ii< size; ii++)
            {
                show += Convert.ToString(Data.cities[low_path[ii]]) + "->";
            }

            show += Data.cities[low_path[size]];

            optCost.Text= Convert.ToString(min_path);
            richTextBox1.Text = show;
            tempCost = min_path;
            tempPath = show;

        }


        private void input()
        {
            if (i == j)
            {
                j++;
            }
            if (j == size)
            {
                i++;
                j = 0;
            }
            if (i < size)
            {
                citieslabel.Text = "Enter Cost from \n" + Data.cities[i] + " to " + Data.cities[j];

            }
            if (i == size)
            {
                textcost.Enabled = false;
                btnNext.Enabled = false;
                BindingSource a = new BindingSource();
                a.DataSource = Data.cities;
                comboBox1.DataSource = a;
                textstartcity.Text = comboBox1.Text;

                distanceNext.Enabled = true;
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            costs[i].Arr[j] = Convert.ToInt32(textcost.Text);
            
            if (costs[i].Arr[j] >= 0)
            {
                textcost.Text = "";
                j++;
                input();
            }
            else
            {
                textcost.Text = "";
                MessageBox.Show("Enter a Positive Input");
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            

            s = comboBox1.SelectedIndex;

            btnNext.Enabled = false;
            textstartcity.Enabled = false;
            TSP();
        }

        private void Textstartcity_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textstartcity.Text = comboBox1.Text;
        }

        private void DistanceNext_Click(object sender, EventArgs e)
        {

        }

        private void Citieslabel_Click(object sender, EventArgs e)
        {

        }
    }
}
