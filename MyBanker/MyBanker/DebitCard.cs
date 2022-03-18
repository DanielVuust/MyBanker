using System;
using System.Collections.Generic;
using System.Text;
using MyBanker.Interfaces;

namespace MyBanker
{
    public abstract class DebitCard : Card, IExpiryingCardType
    {
        protected DebitCard(ICardOwner cardOwner, IAccount account) 
            : base(cardOwner, account)
        {
        }

        public sealed override CardType GetCardType()
        {
            return CardType.DebitCard;
        }

        public abstract int GetExpiryMonth();

        public abstract int GetExpiryYear();
    }
}
