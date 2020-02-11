using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationsBasicLab6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {

                string[] actions = command.Split();

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


                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
