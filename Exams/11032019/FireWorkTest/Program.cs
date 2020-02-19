using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace FireWorkTest
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> text = Console.ReadLine().Split('#', StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < text.Count; i++)
            {
                Console.WriteLine(text[4]);
            }


            Console.WriteLine(string.Join(" ", text));

            foreach (var item in text)
            {
                Console.WriteLine(item);
            }
        }    

    }
}
