using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperationsEx4
{
    class Program
    {

        //4. List Operations
        //You will be given a list of integer numbers on the first line of input.You will be receiving operations you have to
        //apply on the list until you receive the &quot;End&quot; command.The possible commands are:
        // Add {number
        //    } – add number at the end.
        // Insert {number
        //} {index} – insert number at given index.
        // Remove {index} – remove at index.
        // Shift left { count } – first number becomes last ‘count’ times.
        // Shift right { count } – last number becomes first ‘count’ times.
        //Note: there is a possibility that the given index is outside of the bounds of the array.In that case print &quot;Invalid
        //index&quot;
        //Input Output
        //1 23 29 18 43 21 20
        //Add 5
        //Remove 5
        //Shift left 3
        //Shift left 1
        //End

                            //43 20 5 1 23 29 18

        //5 12 42 95 32 1
        //Insert 3 0
        //Remove 10
                            //Insert 8 6
        //Shift right 1
        //Shift left 2
        //End

                            //Invalid index
                             //5 12 42 95 32 8 1 3



        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                List <string> commandLine = command.Split().ToList();

                Operations(commandLine, numbers);

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void Operations(List<string> commandLine, List<int> numbers)
        {
            if (commandLine[0] == "Add")
            {
                int numberAdd = int.Parse(commandLine[1]);
                numbers.Add(numberAdd);
            }

            else if (commandLine[0] == "Insert")
            {
                int numberInsert = int.Parse(commandLine[1]);
                int indexInsert = int.Parse(commandLine[2]);

                if (indexInsert >= 0 && indexInsert < numbers.Count)
                {
                    numbers.Insert(indexInsert, numberInsert);
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }
            }

            else if (commandLine[0] == "Remove")
            {
                int indexRemove = int.Parse(commandLine[1]);

                if (indexRemove >= 0 && indexRemove < numbers.Count)
                {
                    numbers.RemoveAt(indexRemove);
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }

            }

            else if (commandLine[0] == "Shift")
            {
                int count = int.Parse(commandLine[2]);
                if (commandLine[1] == "left")
                {
                    

                    for (int i = 0; i < count; i++)
                    {
                        int firstNumber = numbers[0];
                        numbers.Add(firstNumber);
                        numbers.RemoveAt(0);

                       
                    }

                 
                }

                else if (commandLine[1] == "right")
                {
                    for (int i = 0; i < count; i++)
                    {
                        int lastNumber = numbers[numbers.Count - 1];
                        numbers.Insert(0, lastNumber);
                        numbers.RemoveAt(numbers.Count - 1);
                    }
                }

            }
        }
    }
}
