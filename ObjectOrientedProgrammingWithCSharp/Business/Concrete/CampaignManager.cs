using ObjectOrientedProgrammingWithCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using ObjectOrientedProgrammingWithCSharp.DataAccess;

namespace ObjectOrientedProgrammingWithCSharp
{
    class CampaignManager : ICampaignService
    {
        private List<ILoggerService> _loggerServices;

        public CampaignManager(List<ILoggerService> loggerServices)
        {
            _loggerServices = loggerServices;
        }

        public void Add(IEntity campaign)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Add(campaign);
            }
        }

        public void Delete(IEntity campaign)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Delete(campaign);
            }
        }

      

        public void Update(IEntity Campaign)
        {
            foreach (var logger in _loggerServices)
            {
                
                logger.Update(Campaign);
            }
        }
    }
}
