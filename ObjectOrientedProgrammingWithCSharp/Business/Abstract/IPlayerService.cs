using System;
using System.Collections.Generic;
using System.Text;
using ObjectOrientedProgrammingWithCSharp.Interfaces;

namespace ObjectOrientedProgrammingWithCSharp
{
    interface IPlayerService
    {

        void Add(IEntity entity);
        void Update(IEntity entity);
        void Delete(IEntity entity);

        


    }
}
