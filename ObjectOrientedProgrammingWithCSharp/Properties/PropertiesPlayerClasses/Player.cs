using System;
using System.Collections.Generic;
using System.Text;
using ObjectOrientedProgrammingWithCSharp.Interfaces;

namespace ObjectOrientedProgrammingWithCSharp
{
    class Player : IEntity
    {
        // oyuncu özellik classı
        public int Id { get; set; }
        public string Name { get; set; }
        public string Soyad { get; set; }
        public string  TcNo { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
