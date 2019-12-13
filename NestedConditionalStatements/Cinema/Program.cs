using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            double total = rows * cols;

            if (type == "Premiere")
            {
                total *= 12;
                
            }
            else if (type == "Normal")
            {
                total *= 7.50;
            }
            else if (type == "Discount") 
            {
                total *= 5;
            }

            Console.WriteLine($"{total:f2} leva");
        }
    }
}
