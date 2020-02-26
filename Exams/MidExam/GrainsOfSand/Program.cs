using System;
using System.Linq;
using System.Collections.Generic;

namespace GrainsOfSand
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> grains = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string commands = Console.ReadLine();

                if (commands == "Mort")
                {
                    break;
                }

                List<string> command = commands.Split().ToList();

                if (command[0] == "Add")
                {
                    int number = int.Parse(command[1]);
                    grains.Add(number);


                }
                else if (command[0] == "Remove")
                {
                    int number = int.Parse(command[1]);

                    if (grains.Contains(number))
                    {
                        grains.Remove(number);


                    }
                    else
                    {

                        if (number >= 0 && number < grains.Count)
                        {
                            grains.RemoveAt(number);

                        }
                    }
                }
                else if (command[0] == "Replace")
                {
                    int number = int.Parse(command[1]);
                    if (grains.Contains(number))
                    {
                        int current = grains.IndexOf(number);
                        int numberTwo = int.Parse(command[2]);
                        grains.RemoveAt(current);
                        grains.Insert(current, numberTwo);

                    }
                }

                else if (command[0] == "Increase")
                {
                    int current = 0;
                    int number = int.Parse(command[1]);
                    for (int i = 0; i < grains.Count; i++)
                    {
                        if (grains[i] >= number)
                        {
                            current = grains[i];
                            break;
                        }
                        else
                        {
                            current = grains[grains.Count - 1];
                        }

                    }

                    for (int i = 0; i < grains.Count; i++)
                    {
                        grains[i] += current;
                    }


                }

                else if (command[0] == "Collapse")
                {
                    int number = int.Parse(command[1]);
                    grains.RemoveAll(x => x < number);

                    
                }
            }

            Console.WriteLine(string.Join(" ", grains));
        }
    }
}
