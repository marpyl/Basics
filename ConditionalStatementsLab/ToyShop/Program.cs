using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double ex = double.Parse(Console.ReadLine());
            int pazel = int.Parse(Console.ReadLine());
            int kukla = int.Parse(Console.ReadLine());
            int meche = int.Parse(Console.ReadLine());
            int minion = int.Parse(Console.ReadLine());
            int kamion = int.Parse(Console.ReadLine());

            double sumPazel = pazel * 2.60;
            double sumKukla = kukla * 3;
            double sumMeche = meche * 4.10;
            double sumMinion = minion * 8.20;
            double sumKamion = kamion * 2;

            double sumToy = pazel + kukla + meche + minion + kamion;
            double sumSum = sumPazel + sumKukla + sumMeche + sumMinion + sumKamion;
            double sumOtstapka = (sumSum / 100) * 25;
            double sumTotal = sumSum - sumOtstapka;
            double sumAbs = (sumTotal / 100) * 10;
            double sumAbsbez = (sumSum / 100) * 10;
            double pechalbas = sumTotal - sumAbs;
            double pechalbabez = sumSum - sumAbsbez;
            double exsotstapka = pechalbas - ex;
            double exbezotstapka = ex - pechalbabez;



            if (sumToy >= 50 && sumAbs >= ex)
            {
                Console.WriteLine("Yes! " + Math.Round(exsotstapka, 2) + "lv left.");
            }

            else if (sumToy >= 50 && sumAbs <= ex)
            {

                Console.WriteLine("Not enough money! " + Math.Round(exsotstapka, 2) + "lv needed.");
            }

            if (sumToy <= 50 && sumAbsbez >= ex)
            {

                Console.WriteLine("Yes! " + Math.Round(exbezotstapka, 2) + "lv left.");

            }

            else if (sumToy <= 50 && sumAbsbez <= ex)
            {
                Console.WriteLine("Not enough money! " + Math.Round(exbezotstapka, 2) + " lv needed.");

            }

        }
    }
}