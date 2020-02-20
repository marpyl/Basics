using System;
using System.Linq;
using System.Collections.Generic;

namespace CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            double totalFirst = 0.0;
            double totalSecond = 0.0;

            for (int i = 0; i < numbers.Count/2; i++)
            {
                totalFirst += numbers[i];
                if (numbers[i] == 0)
                {
                    totalFirst = totalFirst * 0.8;
                }
            }

            for (int i = numbers.Count - 1; i > numbers.Count/2; i--)
            {
                totalSecond += numbers[i];
                if (numbers[i] == 0)
                {
                    totalSecond = totalSecond * 0.8;
   
                }
   
            }

            if (totalFirst < totalSecond)
            {
                Console.WriteLine($"The winner is left with total time: {totalFirst}");
            }

            else
            {
                Console.WriteLine($"The winner is right with total time: {totalSecond}");
            }
        }
    }
}
