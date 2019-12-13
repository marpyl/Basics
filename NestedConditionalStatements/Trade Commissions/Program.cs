using System;


namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());
            double comission = 0;




            if (city == "Sofia".ToLower())
            {

                if (sales >= 0 && sales <= 500) comission = 0.05;
                else if (sales > 500 && sales <= 1000) comission = 0.07;
                if (sales > 1000 && sales <= 10000) comission = 0.08;
                else if (sales > 10000) comission = 0.12;
                {

                    if (sales >= 0)
                    {

                        Console.WriteLine($"{sales * comission:f2}");

                    }

                    else
                    {
                        Console.WriteLine("error");
                    }


                }


            }

            else if (city == "Varna".ToLower())
            {

                if (sales >= 0 && sales <= 500) comission = 0.045;
                else if (sales > 500 && sales <= 1000) comission = 0.075;
                if (sales > 1000 && sales <= 10000) comission = 0.1;
                else if (sales > 10000) comission = 0.13;
                {

                    if (sales >= 0)
                    {

                        Console.WriteLine($"{sales * comission:f2}");

                    }

                    else
                    {
                        Console.WriteLine("error");
                    }
                }


            }

            else if (city == "Plovdiv".ToLower())
            {

                if (sales >= 0 && sales <= 500) comission = 0.055;
                else if (sales > 500 && sales <= 1000) comission = 0.08;
                if (sales > 1000 && sales <= 10000) comission = 0.12;
                else if (sales > 10000) comission = 0.145;
                {

                    if (sales >= 0)
                    {

                        Console.WriteLine($"{sales * comission:f2}");

                    }

                    else
                    {
                        Console.WriteLine("error");
                    }
                }
            }
            else 
            {
                Console.WriteLine("error");
            }
        }
    }
}