using System;

namespace MISY2313_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 6;
            int num2 = 4;
            //int result_multiplication;

            sum(num1, num2);
            Difference(num1, num2);

            int product_multiplication = Product();

            Console.WriteLine(product_multiplication);

            // Console.WriteLine(result_multiplication);


            static void sum(int x1, int x2)
            {
                int result_sum;

                result_sum = x1 + x2;

                Console.WriteLine(result_sum);

                //Console.WriteLine("Hello World!");

            }

            static void Difference(int x1, int x2)
            {
                int result_Difference;

                result_Difference = x1 - x2;

                Console.WriteLine(result_Difference);

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