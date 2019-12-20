using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int sum1 = 0;
            int currentValue = 0;
            

            for (int i = 0; i < n; i++)
            {
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());

                sum = number1 + number2;
                sum1 = number2 + number1;


                


            }
            //if (sum == sum1)
            //{
            //    Console.WriteLine("Yes, value = " + sum);
            //}

            //Console.WriteLine("No, maxdiff = " + maxNumber);

        }
    }
}
