using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i < num; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sumRight += number;

            }
            for (int j = 0; j < num; j++)
            {
                int number1 = int.Parse(Console.ReadLine());
                sumLeft += number1;
            }

            if (sumRight == sumLeft)
            {
                Console.WriteLine("Yes, sum = " + sumLeft);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(sumLeft-sumRight));
            }

        }
    }
}
