using System;
using System.Linq;

namespace PartyProfitEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double coins = 0.00;

            for (int i = 1; i <= days; i++)
            {

                

                if (i % 10 == 0)
                {

                    people -= 2;
                }
                if (i % 15 == 0)
                {

                    people += 5;
                }

                coins += 50;
                coins -= 2 * people;

                if (i % 3 == 0)
                {

                    coins -= 3 * people;
                }
                if (i % 5 == 0)
                {

                    coins += 20 * people;
                    if (i % 3 == 0)
                    {

                        coins -= 2 * people;
                    }
                }


            }

            double total = Math.Floor(coins / people);

            Console.WriteLine(people + " companions received " + total + " coins each.");
        }
    }
}
