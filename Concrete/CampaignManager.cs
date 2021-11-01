using System;
using System.Collections.Generic;
using System.Text;
using GameSalesDemo.Abstract;
using GameSalesDemo.Entities;

namespace GameSalesDemo.Concrete
{
    class CampaignManager:ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Sisteme yeni kampanya eklendi: " + campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Sistemden kampanya güncellendi: " + campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Sistemden kampanya silindi: " + campaign.CampaignName);
        }
    }
}
