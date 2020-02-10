using System;
using System.Collections.Generic;


namespace ListOfProductsLab4
{
    class Program
    {
        static void Main(string[] args)
        {

            //4.List of Products
            //Read a number n and n lines of products.Print a numbered list of all the products ordered by name.
            //Examples
            //Input Output
            //4
            //Potatoes
            //Tomatoes
            //Onions
            //Apples

            //1.Apples
            //2.Onions
            //3.Potatoes
            //4.Tomatoes
           
            int num = int.Parse(Console.ReadLine());
            List<string> ordered = new List<string>();

            for (int i = 0; i < num; i++)
            {

                string products = Console.ReadLine();
                ordered.Add(products);


            }
            ordered.Sort();
            for (int i = 0; i < ordered.Count; i++)
            {

                Console.WriteLine(i + 1 + "." + ordered[i]);
            };
        }
    }
}
