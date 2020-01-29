using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeListEx2
{
    class Program
    {
        static void Main(string[] args)
        {

            //2. Change List
            //Write a program, which reads a list of integers from the console and receives commands, which manipulate the list.
            //Your program may receive the following commands:
            // Delete { element} – delete all elements in the array, which are equal to the given element.
            // Insert { element}
            //            { position} – insert an element and the given position.
            //You should stop the program when you receive the command &quot; end & quot;. Print the numbers in the array separated by a
            //   single whitespace.
            //Examples

            //Input                         Output

            //1 2 3 4 5 5 5 6
            //Delete 5

            //                           1 10 2 3 4 6
            //Insert 10 1
            //Delete 5
            //end
            //20 12 4 319 21 31234 2 41 23 4
            //Insert 50 2
            //Insert 50 5
            //Delete 4
            //end

            //                          20 12 50 319 50 21 31234 2 41 23


            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string result = string.Empty;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                string[] actions = command.Split();

                if (actions[0] == "Delete")
                {
                    int actionDelete = int.Parse(actions[1]);
                    numbers.RemoveAll(x => x == actionDelete);

                }
                else if (actions[0] == "Insert")
                {
                    int numberToAdd = int.Parse(actions[1]);
                    int indexToAdd = int.Parse(actions[2]);
                    numbers.Insert(indexToAdd, numberToAdd);
                }


            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
