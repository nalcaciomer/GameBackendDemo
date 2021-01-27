using System;
using System.Collections.Generic;
using System.Text;
using GameBackendDemo.Entities;

namespace GameBackendDemo.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
