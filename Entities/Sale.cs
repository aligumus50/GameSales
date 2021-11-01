using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesDemo.Entities
{
    class Sale:IEntity
    {
        public int Id { get; set; }
        public string MemberUserName { get; set; }
        public double PriceGame { get; set; }
    }
}
