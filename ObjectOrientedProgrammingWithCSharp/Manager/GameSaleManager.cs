using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using ObjectOrientedProgrammingWithCSharp.Interfaces;

namespace ObjectOrientedProgrammingWithCSharp.Manager
{
    class GameSaleManager : ISaleManager
    {
        private Player player;

        public void Sale(Player _player)
        {
            player = _player;
            Console.WriteLine("gecerli oyuncuya satis islemi tanımlanmıstır : "+player.name);
        }

      
    }
}
