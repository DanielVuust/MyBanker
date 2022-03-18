using MyBanker.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    class Account : IAccount
    {
        private Random ran = new Random();
        private readonly string[] accountPrefix = new string[]
        {
            "3529"
        };
        private int accountNumLength;
        public Account(int accountNumLength)
        {
            this.accountNumLength = accountNumLength;
        }
        public string GetAccountNumber()
        {
            string accountNum = this.GetAccountNumber();
            while (accountNum.Length < accountNumLength)
            {
                accountNum += ran.Next(10);
            }
            return accountNum;
        }

        public string GetRegistrationNumber()
        {
            return accountPrefix[ran.Next(accountPrefix.Length)];
        }
    }
}
