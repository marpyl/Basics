using System;
using System.Collections.Generic;
using System.Linq;

namespace RemovingNegativesAndReverseLab5
{
    class Program
    {
        static void Main(string[] args)
        {

            //5.Remove Negatives and Reverse
            //Read a list of integers, remove all negative numbers from it and print the remaining elements in reversed order. In
            //case there are no elements left in the list, print &quot; empty & quot;.
            //Examples
            //Input Output
            //10 - 5 7 9 - 33 50 50 9 7 10
            //7 - 2 - 10 1 1 7
            //  - 1 - 2 - 3 empty
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).Where(x => x > 0).ToList();

            numbers.Reverse();

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }

            else
            {
                Console.WriteLine(string.Join(" ", numbers));

            }

            


        }
    }
}
