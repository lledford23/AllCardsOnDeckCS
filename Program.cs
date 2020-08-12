using System;
using System.Collections.Generic;
using System.Linq;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Magic of Cards!");

            var deck = new List<string>();
            var suitList = new List<string>() { "Clubs", "Spades", "Diamonds", "Hearts" };
            var rankList = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "King", "Queen", "Jack" };


            for (var indexOfSuitList = 0; indexOfSuitList < suitList.Count(); indexOfSuitList++)
            {

                var suit = suitList[indexOfSuitList];

                for (var indexOfRankList = 0; indexOfRankList < rankList.Count(); indexOfRankList++)
                {

                    var rank = rankList[indexOfRankList];


                    deck.Add($"{rank} of {suit}");

                }
            }

            var cardsInDeck = deck.Count;

            var randomNumberGenerator = new Random();

            for (var rightIndex = cardsInDeck - 1; rightIndex > 0; rightIndex--)
            {

                var leftIndex = randomNumberGenerator.Next(rightIndex);


                var leftCard = deck[rightIndex];


                var rightCard = deck[leftIndex];


                deck[rightIndex] = rightCard;


                deck[leftIndex] = leftCard;
            }

            Console.WriteLine(deck[0]);
            Console.WriteLine(deck[1]);

        }
    }
}