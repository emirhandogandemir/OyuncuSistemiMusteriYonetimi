using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingWithCSharp
{
    interface IGameManager
    {
        
        void Add(Game game);// oyun türünde ekleme 
        void Delete(Game game);// oyun türünde silme

        void Update(Game lastGameInfo,Game newGameInfo);// eski oyun , yeni oyun
        
        void GetGames();// butun oyunları getir
    }
}
