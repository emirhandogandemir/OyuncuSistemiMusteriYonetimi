using System;
using System.Collections.Generic;
using System.Text;
using ObjectOrientedProgrammingWithCSharp.Interfaces;
using ObjectOrientedProgrammingWithCSharp.Properties;

namespace ObjectOrientedProgrammingWithCSharp
{
    interface IGameService
    {

        void Add(IEntity entity);
        void Delete(IEntity entity);

        void Update(IEntity entity);

       
    }
}
