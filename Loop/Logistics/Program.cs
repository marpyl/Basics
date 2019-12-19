using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int loads = int.Parse(Console.ReadLine());
            
            int bus = 0;
            int truck = 0;
            int train = 0;
            double totalTons = bus + truck + train;

            for (int i = 0; i < loads; i++)
            {
                int tons = int.Parse(Console.ReadLine());

                if (tons> 0 && tons <=3)
                {
                    
                    bus += tons;
                }
                else if (tons > 3 && tons <= 11)
                {
                    
                    truck += tons;
                }
                else if (tons > 11)
                {
                    
                    train += tons;
                }
            }

            

            Console.WriteLine($"{((bus*200 + truck *175 + train * 120)/totalTons):f2}");
            Console.WriteLine($"{(bus/totalTons*100):f2}%");
            Console.WriteLine($"{(truck/totalTons*100):f2}%");
            Console.WriteLine($"{(train/totalTons*100):f2}%");
        }
    }
}
