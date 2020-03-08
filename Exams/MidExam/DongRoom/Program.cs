using System;
using System.Collections.Generic;
using System.Linq;

namespace DongRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rooms = Console.ReadLine().Split('|').ToList();

            int health = 100;
            int coins = 0;
            

            int totalCoins =0;

            List<string> items = new List<string>(rooms);

           

            for (int i = 0; i < rooms.Count; i++)
            {

                string[] room = rooms[i].Split().ToArray();

                string item = room[0];
                int number = int.Parse(room[1]);

                if (item == "potion")
                {
                    int currentHealth = health;

                    if (number + health <= 100)
                    {
                        health += number;
                        Console.WriteLine($"You healed for {number} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                    else if (health + number > 100)
                    {
                        
                        Console.WriteLine($"You healed for {100 - health} hp.");
                        health = 100;
                        Console.WriteLine($"Current health: {health} hp.");
                        
                    }

                    
                    
                }

                else if (item == "chest")
                {
                    coins = number;
                    totalCoins += number;
                    Console.WriteLine($"You found {coins} coins.");
                    
                }

                else
                {
                    health -= number;

                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {item}.");
                        
                    }

                    else
                    {
                        int bestRoom = i;
                        Console.WriteLine($"You died! Killed by {item}.");
                        Console.WriteLine($"Best room: {bestRoom+1}");
                        return;
                    }
                }


            }

            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Coins: {totalCoins}");
            Console.WriteLine($"Health: {health}");
           
        }
    }
}
