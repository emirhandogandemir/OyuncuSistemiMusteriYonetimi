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
        private List<Player> _player;
        private List<ILoggerService> _loggerServices;
        private List<IPlayerCheckService> _playerCheckServices;
        public PlayerManager(List<Player> player, List<ILoggerService> loggerServices, List<IPlayerCheckService> playerCheckServices)
        {
            _player = player;
            _loggerServices = loggerServices;
            _playerCheckServices = playerCheckServices;
        }

        public void Add(IEntity player)
        {
            try
            {
                foreach (var playerCheck in _playerCheckServices)
                {
                    if (playerCheck.CheckIfRealPerson((Player) player))
                    {
                        _player.Add((Player)player);
                    }
                    else
                    {
                        Console.WriteLine("gecersiz player");
                    }

                }


                foreach (var logger in _loggerServices)
                {
                    logger.Add(player);
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

        public void GetAllPlayer()
        {
            foreach (var logger in _loggerServices)
            {
                Console.WriteLine(" KAYITLI OYUNCULAR : "+logger);
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
