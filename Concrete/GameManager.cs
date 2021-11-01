using System;
using System.Collections.Generic;
using System.Text;
using GameSalesDemo.Abstract;
using GameSalesDemo.Entities;

namespace GameSalesDemo.Concrete
{
    class GameManager:IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Sisteme oyun başarılı şekilde kaydedildi: " + game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun başarılı şekilde güncellendi: " + game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Sistemden oyun başarılı şekilde silindi: " + game.GameName);
        }
    }
}
