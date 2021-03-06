using System;
using System.Collections.Generic;
using System.Text;
using GameSalesDemo.Entities;

namespace GameSalesDemo.Abstract
{
    interface IGameService
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
