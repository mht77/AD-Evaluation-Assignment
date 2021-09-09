using System;
using System.Collections.Generic;

namespace AD_Evaluation_Assignment
{
    public class Cards
    {
        public static readonly Dictionary<int, string> HighCards = new()
        {
            {11,"J"},
            {12,"Q"},
            {13,"K"},
            {14,"A"}
        };
        
        public static Card GenerateCard()
        {
            var numberForSuit = new Random().Next(0, 3);
            var res = ((Suits)numberForSuit).ToString();
            var numberForType = new Random().Next(2, 14);
            if (numberForType > 10)
            {
                res += HighCards[numberForType];
            }
            else
            {
                res += numberForType.ToString();
            }
            return new Card
            {
                Name = res,
                Suit = (Suits)numberForSuit
            };
        }
    }

    public enum Suits
    {
        S,
        H,
        C,
        D
    }

    public class Card
    {
        public string Name { get; set; }
        public Suits Suit;
    }
}