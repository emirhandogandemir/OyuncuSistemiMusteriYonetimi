using ObjectOrientedProgrammingWithCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingWithCSharp.DataAccess.Concrete
{
    class FileLoggerService : ILoggerService
    {
        public void Add(IEntity entity)
        {
            Console.WriteLine("Saved to File  : " + entity.Name);
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine("Delete to File  : " + entity.Name);
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine("Update to File  : " + entity.Name);
        }
    }
}
