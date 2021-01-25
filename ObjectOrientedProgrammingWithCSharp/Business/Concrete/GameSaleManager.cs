using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using ObjectOrientedProgrammingWithCSharp.Interfaces;

namespace ObjectOrientedProgrammingWithCSharp.Manager
{
    class GameSaleManager : ISaleService
    {
        private IEntity _entity;

        public GameSaleManager(IEntity entity)
        {
            _entity = entity;
        }

        public void Sale(IEntity entity)
        {
            Console.WriteLine(_entity.Name + "oyunu satısı gerceklestirildi");
        }
    }
}