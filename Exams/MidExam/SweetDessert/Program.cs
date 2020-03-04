using System;

namespace SweetDessert
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            double bananaPricePc = double.Parse(Console.ReadLine());
            double eggsPricePc = double.Parse(Console.ReadLine());
            double berriesPriceKg = double.Parse(Console.ReadLine());

            int sets = 0;
            double total = 0.0;

            if (guests > 0)
            {
                sets = 1;
                while (guests > 6)
                {
                    sets++;
                    guests -= 6;
                }
            }

            total = sets*(2 * bananaPricePc + 4 * eggsPricePc + berriesPriceKg * 0.2);

            if (money >= total)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(total-money):f2}lv more.");
            }
        }
    }
}
