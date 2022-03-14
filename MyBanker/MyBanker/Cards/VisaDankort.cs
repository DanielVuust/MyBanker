using MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker.Cards
{
    class VisaDankort : Card, IExpiryDate, IMonthlyLimit, IMaxCredit
    {
        private string[] prifix = { "4" };
        private DateTime expiryDate = DateTime.UtcNow.AddYears(5);
        private int monthlyLimit = 25000;
        private int maxCredit = 20000;


        public DateTime ExpiryDate { get { return expiryDate; } }
        public int MonthlyLimit { get { return monthlyLimit; } }
        public int MonthlyLimit { get { return monthlyLimit; } }
        public VisaDankort(string cardOwner, int age)
            : base(cardOwner, "VisaDankort", 0, age)
        {
            base.Prefix = prifix;
        }
    }
}
