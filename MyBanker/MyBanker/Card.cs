using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    public abstract class Card 
    {
        private string cardOwner;
        private string name;
        private string[] prefix = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        private string cardNumber;
        private string accountNumber;
        private int minSaldo;
        private int currentSaldo;
        private int age;
        private int cardNumberLength = 16;
        public string CardOwner { get { return cardOwner; } }
        public string Name { get { return name; } }
        public virtual string[] Prefix { get { return prefix; } set { prefix = value; } }
        public string CardNumber { get { return cardNumber; } }
        public string AccountNumber { get { return accountNumber; } }
        public int MinSaldo { get { return minSaldo; } set { minSaldo = value; } }
        public int CurrnetSaldo { get { return currentSaldo; } }
        public int Age { get { return age; } }
        public int CardNumberLength { get { return cardNumberLength; } set { cardNumberLength = value; } }

        public Card(string cardOwner, string name,  int minSaldo,  int age)
        {
            if (!LegalAge(age))
                throw new Exception("Not allowed at owners current age");
            this.cardOwner = cardOwner;
            this.name = name;
            this.minSaldo = minSaldo;
            this.age = age;
            //All card start with a saldo of 0.
            this.currentSaldo = 0;
            this.cardNumber = this.GenerateCardNumber();
            this.accountNumber = this.GenerateAccountNumber();
        }
        private string GenerateCardNumber()
        {
            string cardNumber = "";
            Random ran = new Random();

            //Gets a random prefix of the of the card num.
            int prefixIndex = ran.Next(0, prefix.Length);

            //Sets the random prefix to be the start of the card num.
            cardNumber += Prefix[prefixIndex];

            //Loops through untill the specific lenght is reached.
            while (cardNumber.Length < cardNumberLength)
            {
                cardNumber += ran.Next(9).ToString();
            }
            return cardNumber;
        }
        private string GenerateAccountNumber()
        {
            string accountNumber = "3520";
            Random ran = new Random();

            //Loops through untill 
            while (accountNumber.Length < 14)
            {
                accountNumber += ran.Next(9).ToString();
            }
            return accountNumber;
        }
        public virtual bool LegalAge(int age)
        {
            if (age < 18)
                return false;
            return true;
        }

    }
}
