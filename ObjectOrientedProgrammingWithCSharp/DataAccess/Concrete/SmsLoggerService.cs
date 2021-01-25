using ObjectOrientedProgrammingWithCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingWithCSharp.DataAccess.Concrete
{
    class SmsLoggerService : ILoggerService
    {
        public void Add(IEntity entity)
        {
            Console.WriteLine("Saved to SMS  :" + entity.Name);
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine("Delete to SMS  : " + entity.Name);
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine("Update to SMS  : " + entity.Name);
        }
    }
}
