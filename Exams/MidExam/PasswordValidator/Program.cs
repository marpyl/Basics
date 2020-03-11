using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum();

        }

        private static void Sum()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int sum = first + second;
            int result = sum - third;
            Console.WriteLine(result);
        }
    }
}
