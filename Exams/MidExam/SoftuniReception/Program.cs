using System;

namespace SoftuniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            int studentsPerHour = first + second + third;
            int all = students / studentsPerHour;
            int hours = 0;

            while (students > 0)
            {
                hours++;
                students -= studentsPerHour;
                if (hours % 4 == 0)
                {
                    hours++;
                }
            }
           

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
