using System;
using System.Collections.Generic;
using ObjectOrientedProgrammingWithCSharp.Business.CheckCustomer;
using ObjectOrientedProgrammingWithCSharp.DataAccess;
using ObjectOrientedProgrammingWithCSharp.DataAccess.Concrete;
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
           ILoggerService smsLoggerService = new SmsLoggerService();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            IPlayerCheckService playerCheckService = new MernisService();
            Player player1 = new Player { TcNo = "22222222222", Name = "Emirhan", Soyad = "dogandemir", DateOfBirth = new DateTime(2000, 1, 8), Id = 1 };
            Player player2 = new Player { TcNo = "33333333333", Name = "Hasan", Soyad = "Huseyin", DateOfBirth = new DateTime(2001, 1, 8), Id = 2 };
            Player player3 = new Player { TcNo = "44444444444", Name = "Murat", Soyad = "Hoca", DateOfBirth = new DateTime(1987, 6, 8), Id = 3 };
            IPlayerService playerService = new PlayerManager(new List<ILoggerService> { smsLoggerService, databaseLoggerService },
                new List<IPlayerCheckService> { playerCheckService }
            );
            playerService.Add(player1);
            playerService.Add(player2);
            playerService.Add(player3);

            IEntity erzurum = new Game
            {
                Id = 1,
                Price = 250,
                Name = "erzurum",
                GameType = "Macera ",
                StockAmount = 100
            };
            IEntity fallGuys = new Game
            {
                Id = 2,
                Price = 300,
                Name = "fallguys  ",
                GameType = "Eglence",
                StockAmount = 50
            };
            IGameService gameManager = new GameManager(new List<ILoggerService> { fileLoggerService });
            gameManager.Add(erzurum);
            gameManager.Add(fallGuys);

            IEntity campaign1= new Campaign{Id = 1,DiscountedPrice = 20,Name = "haftasonu indirimi"};
            IEntity campaign2 = new Campaign { Id = 1, DiscountedPrice = 100, Name = "yaz indirimi" };
            IEntity campaign3 = new Campaign { Id = 1, DiscountedPrice = 25, Name = "kıs indirimi" };
            ICampaignService campaignService= new CampaignManager(new List<ILoggerService>{databaseLoggerService});
            campaignService.Add(campaign1);
            campaignService.Add(campaign2);
            campaignService.Add(campaign3);
          
            ISaleService saleService= new GameSaleManager();
            ISaleService saleService2 = new GameSaleManager();
            saleService.Sale(erzurum);
            saleService2.Sale(fallGuys, campaign1);
          
            ;
        }
    }
}
