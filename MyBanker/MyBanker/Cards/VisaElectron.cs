using MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker.Cards
{
    public class VISAElectron : Card, IExpiryDate, IIsPayableInternational, IIsPayableOnline, IMonthlyLimit
    {
        private readonly string[] prifix = { "2400" };
        private DateTime expiryDate = DateTime.UtcNow.AddYears(5);
        private bool isPayableInternational = true;
        private bool isPayableOnline = true;
        private int monthlyLimit = 10000;


        public DateTime ExpiryDate { get { return expiryDate; } }
        public bool IsPayableInternational { get { return isPayableInternational; } }
        public bool IsPayableOnline { get { return isPayableOnline; } }
        public int MonthlyLimit { get { return monthlyLimit; } }

        public VISAElectron(string cardOwner, int age)
            : base(cardOwner, "ViasElectron", 0, age)
        {
            base.Prefix = prifix;
        }
        
        public override bool LegalAge(int age)
        {
            //The person getting this card has to be over 15.
            if (age <= 15)
                return false;
            return true;
        }
    }
}
