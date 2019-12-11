using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();

            if (name == "f")
            {

                if (age < 16)
                {

                    Console.WriteLine("Miss");
                }

                else if (age >= 16)
                {

                    Console.WriteLine("Ms.");
                }
            }

            else if (name == "m")
            {

                if (age < 16)
                {

                    Console.WriteLine("Master");

                }

                else if (age >= 16)
                {

                    Console.WriteLine("Mr.");
                }

            }
        }
    }
}