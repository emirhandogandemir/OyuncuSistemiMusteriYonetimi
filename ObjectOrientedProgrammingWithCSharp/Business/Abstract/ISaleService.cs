using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace ObjectOrientedProgrammingWithCSharp.Interfaces
{
    interface ISaleService
    {
       
        void Sale(IEntity game,IEntity campaign);

        void Sale(IEntity game);
    }
}
