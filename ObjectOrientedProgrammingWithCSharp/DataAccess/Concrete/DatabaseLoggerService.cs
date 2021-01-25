using ObjectOrientedProgrammingWithCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace ObjectOrientedProgrammingWithCSharp.DataAccess.Concrete
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Add(IEntity entity)
        {
            Console.WriteLine("Saved to db  : "+entity.Name);
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine("Delete to db  : " + entity.Name);
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine("Update to db  : " + entity.Name);
        }
    }
}
