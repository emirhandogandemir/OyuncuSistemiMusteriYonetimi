using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingWithCSharp
{
    class PlayerManager : IPlayerMenager
    {
        List<Player> players= new List<Player>();
      
        public void Add(Player player)
        {
          players.Add(player);

        }

        public void Delete(Player player)
        {
            players.Remove(player);
            Console.WriteLine("Oyuncu silindi ");
        }

        public void GetAllPlayer()
        {
            foreach (var player in players)
            {
                Console.WriteLine(" FirstName : " + player.name);
                Console.WriteLine("LastName : "+player.soyad);
            }
        }

     

        public void Update(Player lastPlayer, Player newPlayer)
        {
            players.Remove(lastPlayer);
            players.Add(newPlayer);
        }
    }
}
