using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    class Order
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public string GameName { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
    }
}
