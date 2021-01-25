using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Transactions;
using ObjectOrientedProgrammingWithCSharp.Interfaces;

namespace ObjectOrientedProgrammingWithCSharp.Manager
{
    class GameSaleManager : ISaleService
    {
        
        public void Sale(IEntity game,IEntity campaign)
        {
            Console.WriteLine(game.Name+" oyunu satılırken  "+ campaign.Name +" adlı indirim gerceklestirildi " +" toplam indirim miktarı : ");
        }

        public void Sale(IEntity game)
        {
            Console.WriteLine(game.Name + " oyunu satıldı bu oyunda indirimimiz mevcut degil ");
        }
    }
}