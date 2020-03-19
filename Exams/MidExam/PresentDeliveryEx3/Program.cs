using System;
using System.Linq;
using System.Collections.Generic;

namespace PresentDeliveryEx3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> houses = Console.ReadLine().Split('@').Select(int.Parse).ToList();

            int index = 0;


            while (true)
            {

                string command = Console.ReadLine();

                if (command == "Merry Xmas!")
                {

                    break;
                }

                string[] action = command.Split().ToArray();

                int jump = int.Parse(action[1]);

                if (index + jump >= houses.Count)
                {

                    index = (index + jump) % houses.Count;
                }

                else
                {

                    index += jump;
                }

                if (houses[index] == 0)
                {

                    Console.WriteLine("House " + index + " will have a Merry Christmas.");
                }

                else
                {

                    houses[index] -= 2;
                }



            }

            int failed = houses.Where(x => x != 0).Count();

            Console.WriteLine("Santa's last position was " + index + ".");

            if (failed > 0)
            {

                Console.WriteLine("Santa has failed " + failed + " houses.");

            }

            else
            {

                Console.WriteLine("Mission was successful.");
            }
        }
    }
}
