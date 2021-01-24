using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingWithCSharp.Interfaces
{
    interface ISaleManager 
    {
        // bu satışların yapılacağı interfacedir
        // bunu interface olarak tanımladım çünkü zamanı geldiğinde sadece oyun satmaktan başka şeylerde eklenebileceğini düşündüm

        void Sale(Player player);


    }
}
