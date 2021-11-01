using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesDemo.Entities
{
    class Game:IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string GameType { get; set; }
        public double Price { get; set; }
    }
}
