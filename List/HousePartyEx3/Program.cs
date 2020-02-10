using System;
using System.Linq;
using System.Collections.Generic;

namespace HousePartyEx3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. House Party
            //Write a program that keeps track of guests, that are going to a house party. On the first line of input, you are going
            //to receive the number of commands you are going to receive.On the next lines you are going to receive one of the
            //following messages:
            //-&quot;
            //            { name} is going!&quot;
            //            -&quot;
            //            { name} is not going!&quot;
            //            If you receive the first message, you have to add the person if he / she is not in the list and if he / she is in the list print
            //                on the console: &quot;
            //            { name} is already in the list!&quot;. If you receive the second message, you have to remove the
            //person if he / she is in the list and if not print: &quot;
            //            { name} is not in the list!&quot;. At the end print all the guests.
            //Examples

            //Input Output
            //4
            //Allie is going!
            //George is going!
            //John is not going!
            //George is not going!

            //John is not in the list!
            //Allie

            //5
            //Tom is going!
            //Annie is going!
            ////Tom is going!
            //Garry is going!
            //Jerry is going!

            //Tom is already in the list!
            //Tom
            //Annie
            //Garry
            //Jerry

            int guests = int.Parse(Console.ReadLine());

            List<string> numberOfGuests = new List<string>();

            for (int i = 0; i < guests; i++)
            {
                string command = Console.ReadLine();
                string[] actions = command.Split();

                if (actions[1] == "is" && actions[2] == "going!")
                {
                    if (numberOfGuests.Contains(actions[0]))
                    {
                        Console.WriteLine($"{actions[0]} is already in the list!");
                    }
                    else
                    {
                        numberOfGuests.Add(actions[0]);
                    }
                }

                if (actions[1] == "is" && actions[2] == "not" && actions[3] == "going!")
                {
                    if (numberOfGuests.Contains(actions[0]))
                    {
                        numberOfGuests.Remove(actions[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{actions[0]} is not in the list!");
                    }
                }
            }

            foreach (var guest in numberOfGuests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
