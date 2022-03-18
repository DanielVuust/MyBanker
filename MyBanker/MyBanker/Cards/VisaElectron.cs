using MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker.Cards
{
    public class VISAElectron : DebitCard, IInternationalCardType, IOnlineCardType
    {
        public VISAElectron(ICardOwner cardOwner, IAccount account) 
            : base(cardOwner, account)
        {

        }
        public override string GenerateNumber()
        {
            string[] cardNumPrefix = new string[] 
            {
            "4026", "417500", "4508", "4844", "4913", "4917"
            };
            string cardNum = cardNumPrefix[ran.Next(cardNumPrefix.Length)];
            while (cardNum.Length <= 16)
            {
                cardNum += ran.Next(0, 10);
            }

            return cardNum;
        }

        public override int GetAgeLimit()
        {
            return 15;
        }

        public override string GetCardName()
        {
            return "Visa Electron";
        }

        

        public override double GetCurrentSaldo()
        {
            return ran.Next(10000);
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
