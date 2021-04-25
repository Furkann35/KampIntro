using GameProject.Manager;
using GameProject.Entities;
using System;
namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Entities.Gamer
            {
                Id = 1,
                BirthYear = 2000,
                FirstName = "Furkan",
                LastName = "Yücel",
                IdentityNumber = 12345
            });
            GameManager gameManager = new GameManager();
            gameManager.Add(new Game
            {
                Id = 1,
                Name = "Valorant",
                Price = 300
            });
            OrderManager orderManager = new OrderManager();
            orderManager.Sale(new Order
            {
                Id = 1,
                UserId = 1,
                UserName = "Furkan",
                GameId = 1,
                GameName = "Valorant"
            }) ;
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign
            {
                Id = 1,
                CampaignName = "1 alana 1 bedava",
                
            });
        }
    }
}
