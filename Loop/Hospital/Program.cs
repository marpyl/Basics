using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int doctors = 7;
            int treatedPaciants = 0;
            int untreatedPaciants = 0;

            for (int i = 1; i <= days; i++)
            {
                int pacients = int.Parse(Console.ReadLine());


                if ((i%3 == 0) && (untreatedPaciants>treatedPaciants))
                {
                    doctors++;
                }

                
                if (pacients>= doctors)
                {
                    untreatedPaciants += (pacients - doctors);
                    treatedPaciants += doctors;
                }
                else if (doctors>pacients)
                {
                    treatedPaciants += pacients;
                }
                
            }

            Console.WriteLine($"Treated patients: {treatedPaciants}.");
            Console.WriteLine($"Untreated patients: {untreatedPaciants}.");



        }
    }
}
