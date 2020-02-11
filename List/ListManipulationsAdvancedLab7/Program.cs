using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationsAdvancedLab7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();


            int sum = 0;

            while (true)
            {


                string command = Console.ReadLine();

                if (command == "end")
                {

                    break;
                }


                string[] actions = command.Split();

                if (actions[0] == "Contains")
                {


                    if (numbers.Contains(int.Parse(actions[1])))
                    {

                        Console.WriteLine("Yes");
                    }

                    else
                    {

                        Console.WriteLine("No such number");
                    }
                }

                if (actions[0] == "PrintEven")
                {

                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));


                }

                if (actions[0] == "PrintOdd")
                {


                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));

                }

                if (actions[0] == "GetSum")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {

                        sum += numbers[i];

                    }

                    Console.WriteLine(sum);

                }

                if (actions[0] == "Filter")
                {

                    if (actions[1] == ">=")
                    {

                        int numberBigger = int.Parse(actions[2]);

                        Console.WriteLine(string.Join(" ", numbers.Where(x => x >= numberBigger)));

                    }

                    else if (actions[1] == "<")
                    {

                        int numberSmaller = int.Parse(actions[2]);

                        Console.WriteLine(string.Join(" ", numbers.Where(x => x < numberSmaller)));

                    }
                    else if (actions[1] == "<=")
                    {
                        int numberSmallerAndEqual = int.Parse(actions[2]);

                        Console.WriteLine(string.Join(" ", numbers.Where(x => x <= numberSmallerAndEqual)));
                    }
                    else if (actions[1] == ">")
                    {
                        int numberBiggerOnly= int.Parse(actions[2]);

                        Console.WriteLine(string.Join(" ", numbers.Where(x => x > numberBiggerOnly)));
                    }
                }
                if (actions[0] == "Add" || actions[0] == "Remove" || actions[0] == "RemoveAt" || actions[0] == "Insert")
                {
                    switch (actions[0])
                    {

                        case "Add":
                            int actionToAdd = int.Parse(actions[1]);
                            numbers.Add(actionToAdd); break;
                        case "Remove":
                            int actionRemove = int.Parse(actions[1]);
                            numbers.Remove(actionRemove); break;
                        case "RemoveAt":
                            int actionRemoveAt = int.Parse(actions[1]);
                            numbers.RemoveAt(actionRemoveAt); break;
                        case "Insert":
                            int numberToAdd = int.Parse(actions[1]);
                            int indexToAdd = int.Parse(actions[2]);
                            numbers.Insert(indexToAdd, numberToAdd); break;
                    }
                    Console.WriteLine(string.Join(" ", numbers));
                }
               

            }
        }
    }
}
