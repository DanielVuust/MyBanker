using System;
using System.Collections.Generic;
using System.Text;
using MyBanker.Interfaces;

namespace MyBanker.Cards
{
    public class Hævekort : Card, ITransactionCardType
    {
        private readonly string[] cardNumPrefix = new string[]
        {
            "2400"
        };
        private readonly int cardLength = 16;
        public Hævekort(ICardOwner cardOwner, ICardType cardType, IAccount account) : base(cardOwner, account)
        {
        }

        public override string GetCardName()
        {
            return "Hævekort";
        }

        public override CardType GetCardType()
        {
            return CardType.DebitCard;
        }

        public override int GetAgeLimit()
        {
            return 0;
        }

        public override string GenerateNumber()
        {
            string cardNum = cardNumPrefix[ran.Next(cardNumPrefix.Length)];
            while (cardNum.Length <= cardLength)
            {
                cardNum += ran.Next(0, 10);
            }

            return cardNum;
        }

        public override double GetCurrentSaldo()
        {
            return ran.Next(2000, 20000);
        }
    }
}
