using System;
using System.Linq;
using System.Collections.Generic;

namespace MemoryView
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> name = new List<string>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Visual Studio crash")
                {
                    break;
                }

                List<int> line = command.Split().Select(int.Parse).ToList();

                for (int i = 0; i < line.Count; i++)
                {
                    string word = string.Empty;
                    if (line[i] == 32763 && line[i + 1] == 0)
                    {
                        int current = line[i + 2];
                        int start = line.IndexOf(line[i + 4]);
                        int end = line.IndexOf(line[start + current - 1]);



                        for (int j = start; j <= end; j++)
                        {
                            word += (char)line[j];
                            

                        }
                        name.Add(word);
                    }
                }

                foreach (var item in name)
                {
                    Console.WriteLine(item);
                }
                
                
            }

            /*        string input = Console.ReadLine();
        string result = string.Empty;
        List<string> words = new List<string>();
        while (input != "Visual Studio crash")
        {
            result += input + " ";
            input = Console.ReadLine();
        }
        string[] token = result.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < token.Length - 5; i++)
        {
            if (token[i] == "32656" && token[i + 1] == "19759" && token[i + 2] == "32763" && token[i + 3] == "0" && token[i + 5] == "0")
            {
                string word = string.Empty;
                int wordLength = int.Parse(token[i + 4]);
                for (int j = i + 6; j <= i + 6 + wordLength; j++)
                {
                    word += (char)(int.Parse(token[j]));
                }
                words.Add(word);
            }
        }
        Console.WriteLine(string.Join("\n", words));
        */

        }
    }
}
