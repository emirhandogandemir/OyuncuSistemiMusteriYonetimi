using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ObjectOrientedProgrammingWithCSharp
{
    interface ICampaignManager
    {
        void Add(Campaign campaign);
        void Update(Campaign lastCampaign,Campaign newCampaign);
        void Delete(Campaign campaign);

        void GetAll();

    }
}
