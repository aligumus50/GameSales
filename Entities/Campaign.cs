using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesDemo.Entities
{
    class Campaign:IEntity
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public double CampaignDiscount { get; set; }
    }
}
