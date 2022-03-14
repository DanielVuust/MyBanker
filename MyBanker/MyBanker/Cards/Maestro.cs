using MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker.Cards
{
    public class Maestro : Card, IExpiryDate, IIsPayableInternational, IIsPayableOnline
    {
        private readonly string[] prifix = { "5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763"};
        private DateTime expiryDate = DateTime.UtcNow.AddYears(5).AddMonths(8);
        private bool isPayableInternational = true;
        private bool isPayableOnline = true;

        public DateTime ExpiryDate { get { return expiryDate; } }
        public bool IsPayableInternational { get { return isPayableInternational; } }
        public bool IsPayableOnline { get { return isPayableOnline; } }

        public Maestro(string cardOwner, int age) 
            : base(cardOwner, "Maestro", 0, age)
        {
            base.Prefix = prifix;
        }
    }
}
