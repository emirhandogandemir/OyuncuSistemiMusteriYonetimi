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
        private IEntity _player;
        public GameSaleManager(IEntity player)
        {
            _player = player;
        }

        public void Sale(IEntity game,IEntity campaign)
        {
            Console.WriteLine(_player.Name +" kişisine "+game.Name+" oyunu satılırken  "+ campaign.Name +" adlı indirim gerceklestirildi ");
        }

        public void Sale(IEntity game)
        {
            Console.WriteLine(_player.Name + " kişisine " + game.Name + " oyunu satıldı , bu oyunda indirimimiz mevcut degil ");
        }
    }
}