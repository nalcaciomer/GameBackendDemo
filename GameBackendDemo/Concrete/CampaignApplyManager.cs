using System;
using System.Collections.Generic;
using System.Text;
using GameBackendDemo.Abstract;
using GameBackendDemo.Entities;

namespace GameBackendDemo.Concrete
{
    public class CampaignApplyManager : ICampaignApplyService
    {
        public void ApplyDiscount(Campaign campaign, Game game)
        {
            if (campaign.StartDateTime <= DateTime.Today && DateTime.Today <= campaign.EndDateTime)
            {
                game.Price -= (game.Price * campaign.Discount / 100);
            }
            else
            {
                Console.WriteLine("Kampanyanın süresi dışında olunduğu için indirim gerçekleştirilemiyor!");
            }
        }
    }
}
