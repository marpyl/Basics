using System;

namespace EncryptSortPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int totalVowels = 0;
            int totalConsonant = 0;
            int total = 0;

            for (int i = 0; i < number; i++)
            {
                string names = Console.ReadLine();

                char[] name = names.ToCharArray();
                

                if (name[i] == 'a' || name[i] == 'e' || name[i] == 'y' || name[i] == 'o' || name[i] == 'i')
                {
                    totalVowels += name[i] * name.Length;
                    Console.WriteLine(totalVowels);
                }

                else
                {
                    totalConsonant += name[i] / name.Length;
                    Console.WriteLine(totalConsonant);
                }
                total += totalVowels + totalConsonant;

                Console.WriteLine(total);
                
            }
        }
    }
}
