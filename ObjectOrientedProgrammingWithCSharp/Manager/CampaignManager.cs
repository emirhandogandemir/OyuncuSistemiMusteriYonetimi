using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedProgrammingWithCSharp
{
    class CampaignManager : ICampaignManager
    {
        List<Campaign> campaigns = new List<Campaign>();
        public void Add(Campaign campaign)
        {
          campaigns.Add(campaign);
        }

        public void Delete(Campaign campaign)
        {
            campaigns.Remove(campaign);
        }

        public void GetAll()
        {
            foreach (var campaign in campaigns)
            {
                Console.WriteLine("Kampanya Adi :"+campaign.name);
                Console.WriteLine("Kampanyada indirim ucreti : "+campaign.discountedPrice);
            }
        }

        public void Update(Campaign lastCampaign, Campaign newCampaign)
        {
            campaigns.Remove(lastCampaign);
            campaigns.Add(newCampaign);
        }
    }
}
