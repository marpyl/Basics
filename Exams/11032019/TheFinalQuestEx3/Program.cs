using System;
using System.Linq;
using System.Collections.Generic;

namespace TheFinalQuestEx3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split().ToList();

            while (true)
            {
                string commands = Console.ReadLine();

                if (commands == "Stop")
                {
                    break;
                }

                List<string> command = commands.Split().ToList();
                

                string action = command[0];

                if (action == "Delete")
                {
                    int index = int.Parse(command[1]);

                    if (text.Count-1 > index && index >= -1)
                    {
                        text.RemoveAt(index+1);
                        
                    }
                }

                else if (action == "Swap")
                {
                    string word = command[1];
                    string wordOne = command[2];

                    if (text.Contains(word) && text.Contains(wordOne))
                    {
                        string newWord = string.Empty;
                        string nextWord = string.Empty;
                        string final = string.Empty;
                        int indexNew = 0;
                        int indexNext = 0;
                        

                        for (int i = 0; i < text.Count; i++)
                        {
                            if (text[i] == word)
                            {
                                newWord = text[i];
                                indexNew = text.IndexOf(text[i]);

                            }
                            if (text[i] == wordOne)
                            {
                                nextWord = text[i];
                                indexNext = text.IndexOf(text[i]);

                            }
                        }

                        text.RemoveAt(indexNew);
                        text.Insert(indexNew, nextWord);
                        text.RemoveAt(indexNext);
                        text.Insert(indexNext, newWord);
                       

                    }


                }

                else if (action == "Put")
                {
                    string word = command[1];
                    int index = int.Parse(command[2]);

                    if (text.Count >= index && index >= 1)
                    {
                        text.Insert(index - 1, word);

                       
                    }
                }
                else if (action == "Sort")
                {
                    text.Sort();
                    text.Reverse();
                   
                }

                else if (action == "Replace")
                {
                    string firstWord = command[1];
                    string secondWord = command[2];
                    string finalWord = string.Empty;
                    int index = 0;

                    if (text.Contains(secondWord))
                    {
                        for (int i = 0; i < text.Count; i++)
                        {
                            if (secondWord == text[i])
                            {
                                finalWord = text[i];
                                index = text.IndexOf(text[i]);

                            }
                        }

                        text.Remove(secondWord);
                        text.Insert(index, firstWord);
                    }

                   


                }
                
            }

            Console.WriteLine(string.Join(" ", text));
        }
    }
}
