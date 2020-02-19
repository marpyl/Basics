using System;
using System.Linq;
using System.Collections.Generic;

namespace SeizeTheFire
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            double effort = 0;

            List<string> line = text.Split(new char[] {'#' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<int> newLine = new List<int>();

            int water = int.Parse(Console.ReadLine());

            int totalFire = 0;

            while(water > 0)
            {
                string fire = line[0];
                int strong = int.Parse(line[1]);

                if (fire == "High")
                {
                    if (strong >= 81 && strong <= 125)
                    {
                        water -= strong;
                        effort += strong * 0.25;
                        totalFire += strong;
                        newLine.Add(strong);

                    }


                }

                if (fire == "Medium")
                {
                    if (strong >= 51 && strong <= 80)
                    {
                        water -= strong;
                        effort += strong * 25;
                        totalFire += strong;
                        newLine.Add(strong);
                    }

                }

                if (fire == "Low")
                {
                    if (strong >= 1 && strong <= 50)
                    {
                        water -= strong;
                        effort += strong * 25;
                        totalFire += strong;
                        newLine.Add(strong);
                    }

                }
            }
           
            Console.WriteLine("Cells:");

            foreach (var item in newLine)
            {
                Console.WriteLine($"- {item}");
            }
            Console.WriteLine($"Effort: {effort:f2}");
            Console.WriteLine($"Total Fire: {totalFire}");

            

           
        }
    }
}
