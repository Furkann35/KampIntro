using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Manager
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("{0} eklendi", game.Name);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("{0} silindi", game.Name);
        }

        public void Update(Game game)
        {
            Console.WriteLine("{0} güncellendi,", game.Name);
        }
    }
}
