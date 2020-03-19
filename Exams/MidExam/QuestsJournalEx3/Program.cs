using System;
using System.Linq;
using System.Collections.Generic;

namespace QuestsJournalEx3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> quests = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {

                string command = Console.ReadLine();

                if (command == "Retire!")
                {

                    break;
                }

                List<string> quest = command.Split(new string[] { " - " }, StringSplitOptions.RemoveEmptyEntries).ToList();

                string action = quest[0];


                if (action == "Start" && !(quests.Contains(quest[1])))
                {

                    quests.Add(quest[1]);

                }

                if (action == "Complete")
                {

                    if (quests.Contains(quest[1]))
                    {

                        quests.Remove(quest[1]);
                    }
                }

                if (action == "Side Quest")
                {

                    string newQuest = quest[1];
                    List<string> newQuestList = newQuest.Split(':').ToList();

                    if (quests.Contains(newQuestList[0]))
                    {

                        int indexOf = quests.IndexOf(newQuestList[0]);

                        quests.Insert(indexOf + 1, newQuestList[1]);
                    }
                }

                if (action == "Renew")
                {

                    if (quests.Contains(quest[1]))
                    {

                        quests.Remove(quest[1]);
                        quests.Add(quest[1]);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", quests));
        }
    }
}
