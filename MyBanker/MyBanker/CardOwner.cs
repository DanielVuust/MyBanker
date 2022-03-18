using MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    class CardOwner : ICardOwner
    {
        private string name;
        private int age;
        public CardOwner(string name, int age)
        {

        }
        public int GetCardOwnerAge()
        {
            return age;
        }

        public string GetCardOwnerName()
        {
            return name;
        }
    }
}
