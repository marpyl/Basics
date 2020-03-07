using System;

namespace ChristmasSpiritMidExam2018
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double ornament = 2.00;
            double skirt = 5.00;
            double garland = 3.00;
            double lights = 15.00;



            int spirit = 0;

            double total = 0.00;

            



            for (int i = 1; i <= days; i++)
            {

                if (i % 11 == 0)
                {

                    quantity += 2;
                }

                if (i % 2 == 0)
                {

                    total += ornament * quantity;
                    spirit += 5;

                }

                if (i % 3 == 0)
                {

                    total += skirt * quantity + garland*quantity;
                    

                    spirit += 13;
                }

                if (i % 5 == 0)
                {

                    total += lights * quantity;

                    spirit += 17;

                    if (i%3 == 0)
                    {
                        spirit += 30;
                    }
                }

                

                if (i % 10 == 0)
                {

                    spirit -= 20;
                    total += skirt + garland + lights;

                    if (i == days)
                    {

                        spirit -= 30;
                    }
                }

                
             


            }

            Console.WriteLine($"Total cost: {total}");
            Console.WriteLine($"Total spirit: {spirit}");
        }
    }
}
