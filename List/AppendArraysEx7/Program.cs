using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArraysEx7
{
    class Program
    {
        static void Main(string[] args)
        {
            //7. Append Arrays
            //Write a program to append several arrays of numbers.
            // Arrays are separated by ‘|’.
            // Values are separated by spaces(‘ ’, one or several).
            // Order the arrays from the last to the first, and their values from left to right.
            //Examples

            //Input Output
            //1 2 3 | 4 5 6 | 7 8 7 8 4 5 6 1 2 3
            //7 | 4 5 | 1 0 | 2 5 | 3 3 2 5 1 0 4 5 7
            //1 | 4 5 6 7 | 8 9 8 9 4 5 6 7 1


            List<string> list = Console.ReadLine().Split('|').Reverse().ToList();
            List<string> newList = new List<string>();

            foreach (var item in list)
            {
                newList.AddRange(item.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList());
            }

            Console.WriteLine(string.Join (" ", newList));
        }
    }
}
