using System;

namespace NewHome
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int pcs = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double total = 0;

            while (budget >= 0) 
            {
                if (type == "Roses" && pcs >= 80)
                {
                    total += pcs * 5 - (total / 100 * 10);
                    budget -= total;
                }
                else if (type == "Roses") 
                {
                    total += pcs * 5;
                    budget -= total;
                }
                if (type == "Dahlias" && pcs >= 90)
                {
                    total += pcs * 3.80 - (total / 100 * 15);
                    budget -= total;
                }
                else if (type == "Dahlias")
                {
                    total += pcs * 3.80;
                    budget -= total;
                }
                if (type == "Tulips" && pcs >= 80)
                {
                    total += pcs * 2.80 - (total / 100 * 15);
                    budget -= total;
                }
                else if (type == "Tulips")
                {
                    total += pcs * 2.80;
                    budget -= total;
                }
                if (type == "Narcissus" && pcs < 120)
                {
                    total += pcs * 3 + (total / 100 * 15);
                    budget -= total;
                }
                else if (type == "Narcissus")
                {
                    total += pcs * 3;
                    budget -= total;
                }
                if (type == "Gladiolus" && pcs < 80)
                {
                    total += pcs * 2.50 + (total / 100 * 20);
                    budget -= total;
                }
                else if (type == "Gladiolus")
                {
                    total += pcs * 2.50;
                    budget -= total;
                }
            }
            if (budget >= total)
            {
                Console.WriteLine($"Hey, you have a great garden with {pcs} {type} and {budget} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(total - budget)} leva more.");
            }
            
        }
    }
}
