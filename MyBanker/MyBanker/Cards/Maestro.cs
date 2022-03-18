using MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker.Cards
{
    public class Maestro : DebitCard, IInternationalCardType, IOnlineCardType
    {
        private readonly string[] cardNumPrefix = new string[]
        {
        "5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763"
        };
        private readonly int cardLength = 16;
        public Maestro(ICardOwner cardOwner, IAccount account) 
            : base(cardOwner, account)
        {
        }

        public override string GetCardName()
        {
            return "Maestro";
        }

        public override int GetAgeLimit()
        {
            return 18;
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
            return ran.Next(0, 20000);
        }

        public override int GetExpiryMonth()
        {
            return ran.Next(1, 13);
        }

        public override int GetExpiryYear()
        {
            return ran.Next(2022, 2027);
        }

        public bool IsPayableInternational()
        {
            return true;
        }

        public bool IsPayableOnline()
        {
            return true;
        }
    }
}
