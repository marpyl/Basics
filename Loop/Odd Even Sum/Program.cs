using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 1; i <= num; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i%2 == 0)
                {
                    leftSum += number;
                }
                else
                {
                    rightSum += number;
                }

            }
            

            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + leftSum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(rightSum-leftSum));
            }
        }
    }
}
