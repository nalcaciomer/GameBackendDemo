using System;
using System.Collections.Generic;
using System.Text;
using GameBackendDemo.Entities;

namespace GameBackendDemo.Abstract
{
    public interface ICampaignApplyService
    {
        void ApplyDiscount(Campaign campaign, Game game);
    }
}
