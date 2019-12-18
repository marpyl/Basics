
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < number; i++)
            {

                double num = double.Parse(Console.ReadLine());

                if (num >= 1 && num < 200)
                {
                    p1++;
                }
                else if (num >= 200 && num < 400)
                {

                    p2++;
                }
                else if (num >= 400 && num < 600)
                {

                    p3++;
                }
                else if (num >= 600 && num < 800)
                {

                    p4++;
                }
                else if (num >= 800 && num <= 1000)
                {

                    p5++;
                }
            }

            Console.WriteLine($"{(100 / number * p1):f2} %");
            Console.WriteLine($"{(100 / number * p2):f2} %");
            Console.WriteLine($"{(100 / number * p3):f2} %");
            Console.WriteLine($"{(100 / number * p4):f2} %");
            Console.WriteLine($"{(100 / number * p5):f2} %");
        }
    
    }
}
