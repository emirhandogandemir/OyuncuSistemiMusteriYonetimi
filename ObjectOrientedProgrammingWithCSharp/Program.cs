using System;
using System.Collections.Generic;
using ObjectOrientedProgrammingWithCSharp.Interfaces;
using ObjectOrientedProgrammingWithCSharp.Manager;
using ObjectOrientedProgrammingWithCSharp.Properties;

namespace ObjectOrientedProgrammingWithCSharp
{
    class Program
    {
        // burada sınıflardan örnekler oluşturup kontrol ettim kısaca switc-case yapısına girmedim 
        static void Main(string[] args)
        {
          Player player1 = new ChildPlayer
          {
              id =1,
              name = "Emirhan",
              soyad = "dogandemir",
              tcNo = "11111111111",
              birtdayYear =  2000,
              Age = 15,
              
          };
          Player player2 = new OldPlayer
          {
              id = 2,
              name = "hasan",
              soyad = "huseyin",
              tcNo = "111111111",
              birtdayYear = 1976,
              yearsOfExperience = 23
          };
            PlayerManager playerManager= new PlayerManager();
            playerManager.Add(player1);
            playerManager.Add(player2);
            playerManager.GetAllPlayer();

            Game game1 = new Game
            {
                id = 1,
                name = "Erzurum",
                gameType = "Macera",
                price = 500,

            };
            Game game2 = new Game
            {
                id = 2,
                name = "PUBG",
                gameType = "Macera",
                price = 600,

            };
            GameManager game = new GameManager();
            game.Add(game1);
            game.Add(game2);
            game.GetGames();

            Campaign campaign1 = new Campaign
            {
                id = 1,
                name = "İndirimleri",
                discountedPrice = 100

            };

            ISaleManager saleManager= new GameSaleManager();
            saleManager.Sale(player1);// parametre olarak oyuncu verildi satıs işlemi tanımlandı


            Campaign campaign2 = new Year_EndCampaign
            {
                id = 1,
                name = "İndirimleri",
                discountedPrice = 100,
                days = new List<string>
                {
                    "pazartesi",
                    "sali",
                    "carsamba"
                }
                
            };


        }
    }
}
