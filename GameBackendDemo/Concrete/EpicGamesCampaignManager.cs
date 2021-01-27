using System;
using System.Collections.Generic;
using System.Text;
using GameBackendDemo.Entities;

namespace GameBackendDemo.Concrete
{
    public class EpicGamesCampaignManager : CampaignManager
    {
        public override void Add(Campaign campaign)
        { // Burada amacım EpicGames' in Steam ile mücadele edebilmesi için +10 fazladan indirim uygulamasını simüle etmek.
            campaign.Discount += (decimal) 10;
            base.Add(campaign);
        }
    }
}
