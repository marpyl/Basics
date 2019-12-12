using System;


namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            bool total = number >= 100 && number <= 200 || number == 0;


            if (!total) { Console.WriteLine("invalid"); }
        }
    }
}