using System;
using System.Linq;
using System.Collections.Generic;

namespace MergingListLab3
{
    class Program
    {
        static void Main(string[] args)

            //3. Merging Lists
            //You are going to receive two lists with numbers.Create a result list, which contains the numbers from both of the
            //lists.The first element should be from the first list, the second from the second list and so on.If the length of the
            //two lists are not equal, just add the remaining elements at the end of the list.
            //Example
            //Input Output
            //3 5 2 43 12 3 54 10 23
            //76 5 34 2 4 12

            //3 76 5 5 2 34 43 2 12 4 3 12 54 10 23

            //76 5 34 2 4 12
            //3 5 2 43 12 3 54 10 23

            //76 3 5 5 34 2 2 43 4 12 12 3 54 10 23
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> newList = new List<int>();

            if (firstList.Count >= secondList.Count)
            {

                for (int i = 0; i < firstList.Count; i++)
                {

                    newList.Add(firstList[i]);


                    if (i < secondList.Count)
                    {

                        newList.Add(secondList[i]);
                    }

                }

            }

            else
            {

                for (int i = 0; i < secondList.Count; i++)
                {




                    if (i < firstList.Count)
                    {

                        newList.Add(firstList[i]);
                    }
                    newList.Add(secondList[i]);

                }
            }



            Console.Write(String.Join(" ", newList));
        }
    }
}
