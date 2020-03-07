using System;
using System.Collections.Generic;
using System.Linq;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // 80 tochki

            List<string> firstList = Console.ReadLine().Split().ToList(); 
            List<string> secondList = Console.ReadLine().Split().ToList();
            List<string> newLine = new List<string>();

            int count = 0;

            if (firstList.Count >= secondList.Count)
            {
                count = firstList.Count;
            }
            else
            {
                count = secondList.Count;
            } 

            for (int i = 0; i < count; i++)
            {
                if (firstList.Contains(secondList[i]))
                {
                    newLine.Add(secondList[i]);
                }
            }

            
            

         

            Console.WriteLine(string.Join(" ", newLine));
        }
    }
}
