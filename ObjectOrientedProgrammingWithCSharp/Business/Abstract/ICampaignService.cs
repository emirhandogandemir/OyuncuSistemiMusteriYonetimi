using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using ObjectOrientedProgrammingWithCSharp.Interfaces;

namespace ObjectOrientedProgrammingWithCSharp
{
    interface ICampaignService
    {
        void Add(IEntity entity);
        void Update(IEntity entity);
        void Delete(IEntity entity);

       

    }
}
