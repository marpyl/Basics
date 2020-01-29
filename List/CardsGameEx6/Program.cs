﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGameEx6
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.Cards Game
            //You will be given two hands of cards, which will be integer numbers.Assume that you have two players. You have to
            //find out the winning deck and respectively the winner.
            //You start from the beginning of both hands. Compare the cards from the first deck to the cards from the second
            //deck.The player, who has the bigger card, takes both cards and puts them at the back of his hand -the second
            //player’s card is last, and the first person’s card(the winning one) is before it (second to last) and the player with
            //the smaller card must remove the card from his deck. If both players’ cards have the same values - no one wins, and
            //the two cards must be removed from the decks.The game is over, when one of the decks is left without any cards.
            //You have to print the winner on the console and the sum of the left cards: &quot; Player { one / two}
            //            wins!Sum:
            //{ sum}
            //            &quot;.

            //Input Output
            //20 30 40 50
            //10 20 30 40

            //First player wins!Sum: 240

            //10 20 30 40 50
            //50 40 30 30 10

            //Second player wins!Sum: 50

            List<int> firstPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();

            

            while (firstPlayer.Count != 0 && secondPlayer.Count !=0)
            {
                int currentFirst = firstPlayer[0];
                int currentSecond = secondPlayer[0];


                if (currentFirst == currentSecond)
                {
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }
                else if (currentFirst > currentSecond)
                {

                    firstPlayer.Add(currentFirst);
                    firstPlayer.Add(currentSecond);
                    secondPlayer.RemoveAt(0);
                    firstPlayer.RemoveAt(0);
                 

                }
                else if (currentSecond > currentFirst)
                {
                    secondPlayer.Add(currentSecond);
                    secondPlayer.Add(currentFirst);
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                    
                }
            }
            int sum = 0;

            if (firstPlayer.Count > secondPlayer.Count)
            {
                sum = firstPlayer.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                sum = secondPlayer.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
            
          
        }
    }
}
