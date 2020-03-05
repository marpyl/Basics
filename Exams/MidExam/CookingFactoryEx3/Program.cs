using System;
using System.Linq;
using System.Collections.Generic;

namespace CookingFactoryEx3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            List<int> newList = new List<int>();
            int sum = int.MinValue;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Bake It!")
                {
                    break;
                }

                numbers = command.Split('#').Select(int.Parse).ToList();

                int currentSum = numbers.Sum();
                
                int minTotal = int.MinValue;

                int currentCount = numbers.Count();
                double total = (double)currentSum / currentCount;

                

                if (currentSum > sum && minTotal < total)
                {
                    sum = currentSum;
                    
                    minTotal = (int)total;
                    newList = numbers;


                }
                
                
            }
            Console.WriteLine($"Best Batch quality: {sum}");
            Console.WriteLine(string.Join(" ", newList));
            
        }
    }
}
