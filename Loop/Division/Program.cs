using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            for (int i = 0; i < num; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number %2 == 0)
                {
                    p1++;
                }
                if (number%3 == 0)
                {
                    p2++;
                }
                if (number%4 == 0)
                {
                    p3++;
                }
            }

            Console.WriteLine($"{((p1/num)*100):f2}%");
            Console.WriteLine($"{((p2/num)*100):f2}%");
            Console.WriteLine($"{((p3/num)*100):f2}%");

            //https://csharp-book.softuni.bg/Content/Chapter-5-2-loops-exam-problems/exam-problems/division/division.html

        }
    }
}
