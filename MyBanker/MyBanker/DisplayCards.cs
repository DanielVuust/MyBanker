using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    public class DisplayCards
    {
        public void DisplayAllCards(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                this.DisplayCard(card);
            }
        }
        private void DisplayCard(Card card)
        {
            Console.WriteLine($"Card {card.Name}-----------------------");
            Console.WriteLine($"Card Owner {card.CardOwner}");
            Console.WriteLine($"Card Age {card.Age}");
            Console.WriteLine($"Card Number {card.CardNumber}");
            Console.WriteLine($"Card Number Length {card.CardNumberLength}");
            Console.WriteLine($"Card Account num {card.AccountNumber}");
            Console.WriteLine($"Card Currnet Saldo {card.CurrnetSaldo}");
            Console.WriteLine($"Card Min Saldo {card.MinSaldo}");
            Console.WriteLine();
        }
    }
}
