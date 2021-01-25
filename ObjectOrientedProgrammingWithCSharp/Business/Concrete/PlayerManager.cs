using ObjectOrientedProgrammingWithCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ObjectOrientedProgrammingWithCSharp.Business.CheckCustomer;
using ObjectOrientedProgrammingWithCSharp.DataAccess;

namespace ObjectOrientedProgrammingWithCSharp
{
    class PlayerManager : IPlayerService
    {
      
        private List<ILoggerService> _loggerServices;
        private List<IPlayerCheckService> _playerCheckServices;
        public PlayerManager( List<ILoggerService> loggerServices, List<IPlayerCheckService> playerCheckServices)
        {
            
            _loggerServices = loggerServices;
            _playerCheckServices = playerCheckServices;
        }

        public void Add(IEntity player)
        {
            try
            {
                foreach (var playerCheck in _playerCheckServices)
                {
                    if (playerCheck.CheckIfRealPlayer((Player) player))
                    {
                       

                        foreach (var logger in _loggerServices)// degisiklik burada yapıldı
                        {
                            logger.Add(player);
                        }

                    }
                    else
                    {
                        Console.WriteLine("gecersiz player");
                    }

                }



            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
              
            }

           
        }

        public void Delete(IEntity player)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Delete(player);
            }
        }


        public void Update(IEntity player)
        {
            foreach (var logger in _loggerServices)
            {
              logger.Update(player);
            }
        }
    }
}
