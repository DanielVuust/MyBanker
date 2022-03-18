using MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MyBanker.Cards
{
    public class Mastercard : CreditCard
    {
        private readonly string[] cardNumPrefix = new string[]
        {
            "51", "52", "53", "54", "55"
        };
        private readonly int cardLength = 19;
        public Mastercard(ICardOwner cardOwner, IAccount account) 
            : base(cardOwner, account)
        {
        }

        public override string GetCardName()
        {
            return "Mastercard";
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
            return ran.Next(1, 200000);
        }

        public override int GetExpiryMonth()
        {
            return ran.Next(1, 13);
        }

        public override int GetExpiryYear()
        {
            return ran.Next(2022, 2027);
        }

        public override int GetCreditLimit()
        {
            return 40000;
        }

        public override int GetMonthlyLimit()
        {
            return 30000;
        }

        public override int GetDailyLimit()
        {
            return 10000;
        }
    }
}
