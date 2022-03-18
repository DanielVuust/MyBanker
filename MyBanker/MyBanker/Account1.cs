using MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    class Account1 : IAccount
    {
        public string GetAccountNumber()
        {
            return "200";
        }

        public string GetRegistrationNumber()
        {
            return "3000";
        }
    }
}
