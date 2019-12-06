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
        public Distance()
        {
            InitializeComponent();
        }

        string show = "";
        int size = 0;
        List<nameofCities> costs = new List<nameofCities>();
        int s = 0;
        int i = 0;
        int j = 1;
        static int[] vertex = { 0 };
        static int[] path = { 0 };
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
            DataEntry c = new DataEntry();
            c.Show();
        }

        private void Distance_Load(object sender, EventArgs e)
        {
            citieslabel.Text = "Enter Cost from  " + Data.cities[i].ToUpper() + "  to  " + Data.cities[j].ToUpper();
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Function to swap the data 
        // present in the left and right indices 
        public static void swap(int left, int right)
        {

            // Swap the data 
            int temp = vertex[left];
            vertex[left] = vertex[right];
            vertex[right] = temp;

            // Return the updated array 
            //return vertex;
        }

        // Function to reverse the sub-array 
        // starting from left to the right 
        // both inclusive 
        public static void reverse(int left, int right)
        {

            // Reverse the sub-array 
            while (left < right)
            {
                int temp = vertex[left];
                vertex[left++] = vertex[right];
                vertex[right--] = temp;
            }

            // Return the updated array 
            //return data;
        }

        // Function to find the next permutation 
        // of the given integer array 
        public static bool findNextPermutation()
        {

            // If the given dataset is empty 
            // or contains only one element 
            // next_permutation is not possible 
            if (vertex.Length <= 1)
                return false;

            int last = vertex.Length - 2;

            // find the longest non-increasing suffix 
            // and find the pivot 
            while (last >= 0)
            {
                if (vertex[last] < vertex[last + 1])
                {
                    break;
                }
                last--;
            }

            // If there is no increasing pair 
            // there is no higher order permutation 
            if (last < 0)
                return false;

            int nextGreater = vertex.Length - 1;

            // Find the rightmost successor to the pivot 
            for (int i = vertex.Length - 1; i > last; i--)
            {
                if (vertex[i] > vertex[last])
                {
                    nextGreater = i;
                    break;
                }
            }

            // Swap the successor and the pivot 
            swap(nextGreater, last);

            // Reverse the suffix 
            reverse(last + 1, vertex.Length - 1);

            // Return true as the next_permutation is done 
            return true;
        }




        private void TSP()
        {

            Array.Resize<int>(ref vertex, size);


            for (int o = 0; o < size; o++)
                if (o != s)
                    vertex[o] = o;

            int[] low_path = { 0 };
            Array.Resize<int>(ref low_path, size + 1);
            int min_path = Int32.MaxValue;
            do
            {

                int current_pathweight = 0;

                Array.Resize<int>(ref path, size + 1);

                // find current path cost 
                int k = s;
                path[0] = s + 1;
                for (int i = 0; i < vertex.Length; i++)
                {
                    current_pathweight += costs[k].Arr[vertex[i]];
                    path[i + 1] = vertex[i] + 1;
                    k = vertex[i];
                }
                current_pathweight += costs[k].Arr[s];

                // modify minimum path cost
                int chk = min_path;
                min_path = Math.Min(min_path, current_pathweight);
                //modify minimum path
                if (min_path != chk)
                {
                    for (int j = 0; j < size; j++)
                    {
                        low_path[j] = path[j];
                    }
                }

            } while (findNextPermutation());
            low_path[size] = s + 1;



            for (int i = 0; i < size; i++)
            {
                show += Convert.ToString(low_path[i]) + "->";
            }

            show += low_path[size];


            richTextBox1.Text = show;

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
                citieslabel.Text = "Enter Cost from " + Data.cities[i] + " to " + Data.cities[j];

            }
            if (i == size)
            {
                textcost.Enabled = false;
                btnNext.Enabled = false;
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            costs[i].Arr[j] = Convert.ToInt32(textcost.Text);
            textcost.Text = "";
            j++;
            input();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            s = Convert.ToInt32(textstartcity.Text) - 1;

            TSP();
        }
    }
}
