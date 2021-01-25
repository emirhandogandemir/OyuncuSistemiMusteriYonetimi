using System;
using System.Collections.Generic;
using System.Text;
using ObjectOrientedProgrammingWithCSharp.Interfaces;

namespace ObjectOrientedProgrammingWithCSharp
{
    class Campaign : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DiscountedPrice { get; set; }// ücretli fiyat
    }
}
