using System;

namespace Hogswatch
{
    class Program
    {
        static void Main(string[] args)
        {
            // ne e zavarshena
            int homes = int.Parse(Console.ReadLine());

            int totalPresents = int.Parse(Console.ReadLine());
            int count = 0;
            int current = 0;
            int total = 0;

            for (int i = 0; i < homes; i++)
            {
                int childrens = int.Parse(Console.ReadLine());

                totalPresents -= childrens;

                if (totalPresents >= 0 && i == homes-1)
                {
                    Console.WriteLine(totalPresents);
                    break;
                }

                else if (totalPresents < 0 && i !=homes - 1)
                {
                    count++;
                    totalPresents += childrens;
                    current = Math.Abs(totalPresents - childrens);
                    totalPresents += totalPresents / i * (homes - i);
                    total = totalPresents + current;
                    Console.WriteLine("Current " + current);
                    Console.WriteLine("Total " + total);
                }
                
                
            }

            if (count > 0)
            {
                Console.WriteLine(count);
                Console.WriteLine(total);
            }
        }
    }
}
