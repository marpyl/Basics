using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            double b = double.Parse(Console.ReadLine());
            double square = (b * b);

            if (a == "square")
            {

                Console.WriteLine(square);

            }

            else if (a == "rectangle")
            {

                double c = double.Parse(Console.ReadLine());
                double rectang = b * c;
                Console.WriteLine(Math.Round(rectang, 3));

            }

            if (a == "circle")
            {


                double circ = Math.PI * b * b;
                Console.WriteLine(Math.Round(circ, 3));

            }

            else if (a == "triangle")
            {
                double c = double.Parse(Console.ReadLine());
                double trian = (b * c) / 2;
                Console.WriteLine(Math.Round(trian, 3));


            }

        }
    }
}