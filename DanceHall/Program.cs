using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            double L = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double A = double.Parse(Console.ReadLine());

            double hole = (L * 100) * (100 * W);
            double gard = (A * 100) * (100 * A);
            double peika = hole / 10;
            double dancer = 7040;

            double result = (hole - gard - peika) / dancer;

            Console.WriteLine(Math.Floor(result));
        }
    }
}