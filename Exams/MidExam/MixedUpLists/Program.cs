using System;
using System.Linq;
using System.Collections.Generic;

namespace MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int firstIndex = 0;
            int secondIndex = 0;

            if (firstNumbers.Count > secondNumbers.Count)
            {
                for (int i = firstNumbers.Count - 1; i >= 0; i--)
                {
                    firstIndex = firstNumbers[i];
                    secondIndex = firstNumbers[i - 1];
                    break;
                }
                
                firstNumbers.Remove(firstIndex);
                firstNumbers.Remove(secondIndex);

            }

            List<int> all = firstNumbers.Concat(secondNumbers).ToList();

            for (int i = 0; i < all.Count; i++)
            {
                if (firstNumbers[i])
                {

                }
            }
            Console.WriteLine(string.Join(" ", all));
       
        }
    }
}
