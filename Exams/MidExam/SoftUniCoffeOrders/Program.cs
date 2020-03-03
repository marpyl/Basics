using System;
using System.Globalization;

namespace SoftUniCoffeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            decimal total = 0;

            for (int i = 0; i < number; i++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsules = long.Parse(Console.ReadLine());

                decimal currentPrice = DateTime.DaysInMonth(date.Year, date.Month) * capsules * price;
                total += currentPrice;
                Console.WriteLine($"The price for the coffee is: ${currentPrice:f2}");


            }

            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
