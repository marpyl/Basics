using System;
using System.Linq;
using System.Collections.Generic;

namespace BreadFactoryEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> workingDays = Console.ReadLine().Split('|').ToList();

            int energy = 100;
            int coins = 100;



            for (int i = 0; i < workingDays.Count; i++)
            {
                List<string> events = workingDays[i].Split('-').ToList();

                string currentEvent = events[0];
                int number = int.Parse(events[1]);

                if (currentEvent == "rest")
                {
                    int gainEnergy = 0;

                    if (energy + number >= 100)
                    {
                        gainEnergy = 100 - energy;
                        energy = 100;
                    }
                    else
                    {
                        gainEnergy = number;
                        energy += number;
                    }
                    Console.WriteLine($"You gained {gainEnergy} energy.");
                    Console.WriteLine($"Current energy: {energy}.");

                }
                else if (currentEvent == "order")
                {
                    

                    if (energy-30 >= 0)
                    {
                        coins += number;
                        Console.WriteLine($"You earned {number} coins.");
                        energy -= 30;
                    }
                    

                    else
                    {
                        
                        
                        Console.WriteLine("You had to rest!");
                        energy += 50;

                        
                    }
                    

                }

                else
                {
                    

                    if (coins <= 0 && coins <= number)
                    {
                        Console.WriteLine($"Closed! Cannot afford {currentEvent}.");
                        break;
                    }

                    else
                    {
                        coins -= number;
                        Console.WriteLine($"You bought {currentEvent}.");
                    }
                    
                }

                
            }

            if (coins >= 0)
            {
                Console.WriteLine("Day completed!");
                Console.WriteLine($"Coins: {coins}");
                Console.WriteLine($"Energy: {energy}");
            }
        }
    }
}
