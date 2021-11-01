using System;
using System.Collections.Generic;
using System.Text;
using GameSalesDemo.Abstract;
using GameSalesDemo.Entities;

namespace GameSalesDemo.Concrete
{
    class SaleManager:ISaleService
    {
        public void WithoutCampaignBuy(Game game, Member member)
        {
            Console.WriteLine(member.UserName + " kullanıcısı " + game.GameName + " oyununu satın almıştır...");
        }

        public void WithCampaignBuy(Game game, Member member, Campaign campaign)
        {
            Console.WriteLine(member.UserName + " kullanıcısı " + game.GameName + " oyununu " + campaign.CampaignName +" ile indirimli satın almıştır...");
        }
    }
}
