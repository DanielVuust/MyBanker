using MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    class CardOwner1 : ICardOwner
    {
        public int GetCardOwnerAge()
        {
            return 20;
        }

        public string GetCardOwnerName()
        {
            return "Daniel";
        }
    }
}
