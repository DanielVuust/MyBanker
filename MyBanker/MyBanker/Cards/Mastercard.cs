using MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MyBanker.Cards
{
    public class Mastercard : CreditCard
    {
        
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
            throw new NotImplementedException();
        }

        public override double GetCurrentSaldo()
        {
            throw new NotImplementedException();
        }

        public override int GetExpiryMonth()
        {
             Random ran = new Random();
            return ran.Next(1, 13);
        }

        public override int GetExpiryYear()
        {
            Random ran = new Random();

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
