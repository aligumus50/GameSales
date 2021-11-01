using System;
using System.Collections.Generic;
using System.Text;
using GameSalesDemo.Entities;

namespace GameSalesDemo.Abstract
{
    interface ISaleService
    {
        void WithoutCampaignBuy(Game game, Member member);
        void WithCampaignBuy(Game game, Member member, Campaign campaign);
    }
}
