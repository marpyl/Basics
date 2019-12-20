using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int sum = 0;

            for (int i = 0; i < number; i++)
            {
                int n = int.Parse(Console.ReadLine());
                
                sum += n;

                if (n > maxNumber)
                {
                    maxNumber = n;

                }
               


            }
            if (maxNumber == (sum - maxNumber))
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + maxNumber);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(maxNumber - (sum - maxNumber)));
            }
        }
    }
}
