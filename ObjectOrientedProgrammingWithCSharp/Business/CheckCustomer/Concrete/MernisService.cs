using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingWithCSharp.Business.CheckCustomer
{
    class MernisService : IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            if ((player.TcNo.Length < 12) && (player.TcNo.Length > 10))
            {
                Console.WriteLine(player.Name +" "+ player.Soyad + "Mernis dogrulaması başarılı");
                return true;
            }
            else
            {
                Console.WriteLine(player.Name + " " + player.Soyad + "Mernis dogrulaması başarısız");
                return false;
            }
        }
    }
}
