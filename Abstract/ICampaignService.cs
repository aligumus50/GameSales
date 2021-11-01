using System;
using System.Collections.Generic;
using System.Text;
using GameSalesDemo.Entities;

namespace GameSalesDemo.Abstract
{
    interface ICampaignService
    {
        void Add(Campaign campaign);

        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
