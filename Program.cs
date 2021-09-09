using System;
using System.Collections.Generic;

namespace AD_Evaluation_Assignment
{
    class Program
    {
        public static Dictionary<Suits, int> GeneratedCardsSuits = new Dictionary<Suits, int>()
        {
            {Suits.S,0},
            {Suits.C,0},
            {Suits.D,0},
            {Suits.H,0},
        };

        public static readonly List<Card> GeneratedCards = new List<Card>();
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("please type g for generating or e for exit ");
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "g")
                {
                    Console.Clear();
                    var card = Cards.GenerateCard();
                    GeneratedCards.Add(card);
                    GeneratedCardsSuits[card.Suit]++;
                    Console.WriteLine("Name: "+ card.Name);
                    Console.WriteLine("Generated Cards Suits:");
                    foreach (var generatedCard in GeneratedCardsSuits)
                    {
                        Console.WriteLine(generatedCard);
                    }
                    Console.WriteLine("Generated Cards:");
                    foreach (var generatedCard in GeneratedCards)
                    {
                        Console.WriteLine(generatedCard.Name);
                    }
                }
                else if (input == "e")
                {
                    break;
                }
            }
        }
    }
}