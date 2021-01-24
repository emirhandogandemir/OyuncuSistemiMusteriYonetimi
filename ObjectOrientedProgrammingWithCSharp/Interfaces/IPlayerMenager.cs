using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingWithCSharp
{
    interface IPlayerMenager
    {

        void Add(Player player);// Player türünde ekleme olacağı için parametresi bu şekilde
        void Update(Player lastPlayerInfo,Player newPlayerInfo);// eski player ve guncellenmiş playeri parametre alarak işlemlerini ona göre yapacak
        void Delete(Player player);//Player türünde silme olacağı için parametresi bu şekilde

        void GetAllPlayer();// sistem üzerinde tüm playerleri getirecek


    }
}
