using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<int> people = new List<int>();
            int sum = 0;
            

            for (int i = 0; i < number; i++)
            {
                int persons = int.Parse(Console.ReadLine());
                people.Add(persons);
                sum += persons;
            }

            Console.WriteLine(string.Join(" ", people));

            Console.WriteLine(sum);
        }
    }
}
