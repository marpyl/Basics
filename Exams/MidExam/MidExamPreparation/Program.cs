using System;

namespace GoogleSearches
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalDays = int.Parse(Console.ReadLine());
            int users = int.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            double total = 0;

            for (int i = 0; i < users; i++)
            {
                int words = int.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    total += money * 3;
                }

                if (words > 5)
                {
                    continue;
                }
                

                else if (words == 1)
                {
                    total += money * 2;
                }

                else
                {
                    total += money;
                }

                

                

            }

            double moneyTotal = total * totalDays;

            Console.WriteLine($"Total money earned for {totalDays} days: {moneyTotal:f2}");

        }
    }
}
