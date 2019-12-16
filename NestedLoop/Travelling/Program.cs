using System;


namespace exams
{
    class Program
    {
        static void Main(string[] args)
        {



            while (true)
            {
                string destination = Console.ReadLine();


                if (destination == "End")
                {
                    break;
                }
                double total = 0.0;
                double budget = double.Parse(Console.ReadLine());

                for (int i = 1; i <= budget; i++)
                {

                    double sum = double.Parse(Console.ReadLine());
                    total += sum;

                    if (total >= budget)
                    {
                        Console.WriteLine("Going to " + destination + "!");

                        break;
                    }

                }

            }


            //int n = int.Parse(Console.ReadLine());
            //int total = 0;

            //for (int i = 0; i <= n; i++)
            //{
            //    for (int j = 0; j <= n; j++)
            //    {
            //        for (int k = 0; k <= n; k++)
            //        {
            //            for (int l = 0; l <= n; l++)
            //            {
            //                for (int m = 0; m <= n; m++)
            //                {



            //                    if (i+j+k+l+m == n)
            //                    {
            //                        total++;

            //                    }

            //                }
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine(total);
        }
    }
}