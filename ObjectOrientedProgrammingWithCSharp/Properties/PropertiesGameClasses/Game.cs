using System;
using System.Collections.Generic;
using System.Text;
using ObjectOrientedProgrammingWithCSharp.Interfaces;
using ObjectOrientedProgrammingWithCSharp.Properties;

namespace ObjectOrientedProgrammingWithCSharp
{
    class Game : IEntity
    {
        // oyun özellik classı
        public int Id { get; set; }
        public string Name { get; set; }
        public string GameType { get; set; }
        public int Price { get; set; }
        public int StockAmount { get; set; }

    }
}
