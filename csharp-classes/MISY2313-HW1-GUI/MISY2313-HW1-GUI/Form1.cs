using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MISY2313_HW1_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = 6;
            int num2 = 4;
            //int result_multiplication;

            sum(num1, num2);

            Difference(num1, num2);

            int product_multiplication = Product();


            MessageBox.Show(product_multiplication.ToString(), "product multiplication of 10, 5");

            static void sum(int x1, int x2)
            {
                int result_sum;

                result_sum = x1 + x2;              

                MessageBox.Show(result_sum.ToString(), "Sum Result of 6, 4");              

            }

            static void Difference(int x1, int x2)
            {
                int result_Difference;

                result_Difference = x1 - x2;

                MessageBox.Show(result_Difference.ToString(), "Difference Result of 6, 4");

                //Console.WriteLine("Hello World!");

            }



            static int Product()
            {

                int multiply_Val = 10 * 5;

                return multiply_Val;

            }

        }
    }
}
