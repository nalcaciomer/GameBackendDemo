using System;
using System.Collections.Generic;
using System.Text;
using GameBackendDemo.Abstract;
using GameBackendDemo.Entities;

namespace GameBackendDemo.Concrete
{
    public abstract class CampaignManager : ICampaignService
    {
        public virtual void Add(Campaign campaign)
        {
            Console.WriteLine("New campaign " + campaign.Name + " added to database!");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " deleted from database!");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " updated in database!");
        }
    }
}
