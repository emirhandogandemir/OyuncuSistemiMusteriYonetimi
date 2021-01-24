using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingWithCSharp
{
    class GameManager : IGameManager
    {
        List<Game> games = new List<Game>();
        public void Add(Game game)
        {
           games.Add(game);
        }

        public void Delete(Game game)
        {
            games.Remove(game);
        }

        public void GetGames()
        {
            foreach (var game in games)
            {
                Console.WriteLine("Oyun adi : "+ game.name);
                Console.WriteLine("Oyun turu : "+game.gameType);
                Console.WriteLine("oyun fiyati : "+game.price);
            }
        }

        public void Update(Game lastGame, Game newGame)
        {
            games.Remove(lastGame);
            games.Add(newGame);
        }
    }
}
