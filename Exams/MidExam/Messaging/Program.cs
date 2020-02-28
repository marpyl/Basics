using System;
using System.Linq;
using System.Collections.Generic;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<char> text = Console.ReadLine().ToList();

            string line = string.Empty;


            int total = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                while (numbers[i] != 0)
                {
                    int lastDigit = numbers[i] % 10;
                    numbers[i] /= 10;

                    total += lastDigit;

                }


               
            }

            for (int i = 0; i < text.Count; i++)
            {
                if (text.Count >= total)
                {
                    line += text.ElementAt(total);

                }
                else
                {

                    line += text.ElementAt(total - text.Count);

                }
            }

            Console.WriteLine(line);
        }
    }
}
