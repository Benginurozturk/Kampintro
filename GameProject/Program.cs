using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
                 GamerManager gamerManager = new GamerManager(new NewStateUserValidationManager());
                gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1995,
                FirstName = "BENGİNUR",
                LastName = "ÖZTÜRK",
                IdentityNumber = 12345
            });
            {
                GameSaleManager gameSale = new GameSaleManager();
                gameSale.GameSale(new Game { GameName = "CSGO", GamePrice = 150, SerialNumber = "1" }, new Gamer { FirstName = "Benginur" });

            }
                CampaignManager campaign = new CampaignManager();
                campaign.AddCampaign(new Campaign { CampaignName = "Efsane Cuma", Id = 2, CampaignDescription = "Avantajlı urünleri kaçırmayın", CampaignDuration = "7-11 Kasım Arası Geçerli" });
        }
    }
}
