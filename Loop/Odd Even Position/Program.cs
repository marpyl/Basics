using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int maxNumberEven = int.MinValue;
            int maxNumberOdd = int.MinValue;
            int minNumberEven = int.MaxValue;
            int minNumberOdd = int.MaxValue;
            int sumOdd = 0;
            int sumEven = 0;

            for (int i = 1; i <= number; i++)
            {
                int n = int.Parse(Console.ReadLine());
                

                if (i%2 == 0)
                {
                    sumEven += n;
                    if (n > maxNumberEven)
                    {
                        maxNumberEven = n;
                    }
                    else if (n < minNumberEven)
                    {
                        minNumberEven = n;
                    }
                }
                else
                {
                    sumOdd += n;
                    if (n > maxNumberOdd)
                    {
                        maxNumberOdd = n;
                    }
                    else if (n < minNumberOdd)
                    {
                        minNumberOdd = n;
                    }
                }

            }

            if (maxNumberEven == 0)
            {
                Console.WriteLine("OddSum=" + sumOdd);
                Console.WriteLine("OddMin=" + minNumberOdd);
                Console.WriteLine("OddMax=" + maxNumberOdd);
                Console.WriteLine("EvenSum=" + sumEven);
                Console.WriteLine("EvenMin=" + minNumberEven);
                Console.WriteLine("EvenMax=No");

            }
            if (minNumberEven == 0)
            {
                Console.WriteLine("OddSum=" + sumOdd);
                Console.WriteLine("OddMin=" + minNumberOdd);
                Console.WriteLine("OddMax=" + maxNumberOdd);
                Console.WriteLine("EvenSum=" + sumEven);
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=" + maxNumberEven);

            }
            if (maxNumberOdd == 0)
            {
                Console.WriteLine("OddSum=" + sumOdd);
                Console.WriteLine("OddMin=" + minNumberOdd);
                Console.WriteLine("OddMax=No");
                Console.WriteLine("EvenSum=" + sumEven);
                Console.WriteLine("EvenMin=" + minNumberEven);
                Console.WriteLine("EvenMax=" + maxNumberEven);
            }
            if (minNumberOdd == 0)
            {
                Console.WriteLine("OddSum=" + sumOdd);
                Console.WriteLine("OddMin=No");
                Console.WriteLine("OddMax=" + maxNumberOdd);
                Console.WriteLine("EvenSum=" + sumEven);
                Console.WriteLine("EvenMin=" + minNumberEven);
                Console.WriteLine("EvenMax=" + maxNumberEven);
            }
            if(maxNumberEven!=0 && maxNumberOdd!=0 && minNumberOdd!=0 && minNumberEven!=0)
            {
                Console.WriteLine("OddSum=" + sumOdd);
                Console.WriteLine("OddMin=" + minNumberOdd);
                Console.WriteLine("OddMax=" + maxNumberOdd);
                Console.WriteLine("EvenSum=" + sumEven);
                Console.WriteLine("EvenMin=" + minNumberEven);
                Console.WriteLine("EvenMax=" + maxNumberEven);
            }
           

            //https://csharp-book.softuni.bg/Content/Chapter-5-1-loops/exercises-loops/even-odd-positions.html
        }
    }
}
