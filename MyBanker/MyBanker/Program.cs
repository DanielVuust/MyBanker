using MyBanker.Cards;
using System;
using System.Collections.Generic;

namespace MyBanker
{
    class Program
    {
        static void Main(string[] args)
        {

            Card card = new Mastercard(new CardOwner1(), new Account1());
            Console.WriteLine(card.GetAgeLimit());
            Console.WriteLine(card.GetCardName());
            Console.WriteLine(card.GetCardType());
            Console.WriteLine(card.GetCurrentSaldo());
            Console.WriteLine(card.GetType());

        }
    }
}
