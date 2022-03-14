using MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker.Cards
{
    class Mastercard : Card, IExpiryDate, IDailyLimit, IMonthlyLimit, IMaxCredit
    {
        private string[] prifix = { "51", "52", "53", "54", "55" };
        private DateTime expiryDate = DateTime.UtcNow.AddYears(5);
        private int dailyLimit = 5000;
        private int monthlyLimit = 30000;
        private int maxCredit = 40000;

        public DateTime ExpiryDate { get { return expiryDate; } }
        public int DailyLimit { get { return dailyLimit; } }
        public int MonthlyLimit { get { return monthlyLimit; } }
        public int MaxCredit { get { return maxCredit; } }

        public Mastercard(string cardOwner, int age)
                    : base(cardOwner, "Mastercard", 0, age)
        {
            base.CardNumberLength = 19;
            base.MinSaldo = maxCredit * -1;
            base.Prefix = prifix;
        }
    }
}
