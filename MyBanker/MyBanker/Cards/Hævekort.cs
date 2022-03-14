using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker.Cards
{
    public class Hævekort : Card
    {
        private string[] prifix = { "2400" };

        public Hævekort(string cardOwner, int age)
            : base(cardOwner, "Hævekort", 0, age)
        {
            base.Prefix = prifix;
        }
        //Will always be true because its allowed to be over 18 when getting the card, though its primaryly used by people under 18.
        public override bool LegalAge(int age)
        {
            return true;
        }
    }
}
