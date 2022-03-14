using MyBanker.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    class CreateCards
    {
        public List<Card> CreateCardList()
        {
            return new List<Card>()
            {
                new Maestro("Daniel", 28),
                new Mastercard("Peter", 18),
                new Hævekort("Morten", 5),
                new VisaDankort("Henning", 92),
                new VISAElectron("Jens", 16),
                //If you want to see the exeptions when the age is to low uncomment the line under here.
                //new Mastercard("Gunner", 17),
                //new Maestro("Gunner v2", 14)
            };
            
        }
    }
}
