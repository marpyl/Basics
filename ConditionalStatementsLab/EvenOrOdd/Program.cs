using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("even");


            }

            else
            {

                Console.WriteLine("odd");

            }
        }
    }
}