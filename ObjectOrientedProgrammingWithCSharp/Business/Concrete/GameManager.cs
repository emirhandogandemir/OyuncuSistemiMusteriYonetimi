using ObjectOrientedProgrammingWithCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using ObjectOrientedProgrammingWithCSharp.DataAccess;

namespace ObjectOrientedProgrammingWithCSharp
{
    class GameManager : IGameService
    {
        private List<ILoggerService> _loggerServices;

        public GameManager(List<ILoggerService> loggerServices)
        {
            _loggerServices = loggerServices;
        }

        public void Add(IEntity game)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Add(game);
            }
        }

        public void Delete(IEntity game)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Delete(game);
            }
        }

      

        public void Update(IEntity game)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Update(game);
            }
        }
    }
}
