using MyBanker.Cards;
using System;
using System.Collections.Generic;

namespace MyBanker
{
    class Program
    {
        static void Main(string[] args)
        {

            Card card = new Mastercard(new CardOwner("Daniel", 20), new Account(14));
            Console.WriteLine(card.GetAgeLimit());
            Console.WriteLine(card.GetCardName());
            Console.WriteLine(card.GetCardType());
            Console.WriteLine(card.GetCurrentSaldo());

        }
    }
}
