using System;
using System.Collections.Generic;
using GameBackendDemo.Adapters;
using GameBackendDemo.Concrete;
using GameBackendDemo.Entities;

namespace GameBackendDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Oyun Tanımlama
            Game game1 = new Game{Id = 1, Name = "PlayerUnknown's Battlegrounds", Price = (decimal) 87, 
                Types = new List<string>(){"Survival", "Shooter", "Multiplayer"}};
            // Oyuncu Tanımlama -
            // Kendi doğru bilgilerinizi girerek ve bir alt satırda new MernisServiceAdapter() ile mernisten kontrol sağlayabilirsiniz. 
            GamerManager gamerManager = new SteamGamerManager(new GamerCheckManager());
            Gamer gamer1 = new Gamer
            {
                Id = 1,
                NationalityId = "1234567890",
                FirstName = "Ömer",
                LastName = "Nalçacı",
                DateOfBirth = new DateTime(2021, 1, 27),
                UserName = "nalcaciomer",
                Password = "0123456789",
                Eposta = "example@outlook.com",
                Balance = (decimal)100,
                OwnedGames = new List<Game>()
            };
            gamerManager.Add(gamer1);
            // Kampanya Tanımlama -
            // 31 ve 37 satırlarını yorum satırı haline getirip kampanyanın uygulanıp uygulanmadığını kontrol edebilirsiniz.
            Campaign campaign1 = new Campaign { Id = 1, Name = "Black Friday", Discount = 10,
                StartDateTime = new DateTime(2021, 01, 27), EndDateTime = new DateTime(2021, 01, 31) };
            CampaignManager campaignManager = new SteamCampaignManager();
            campaignManager.Add(campaign1);
            // Kampanya İndiriminin Oyuna Uygulanması
            CampaignApplyManager campaignApplyManager = new CampaignApplyManager();
            campaignApplyManager.ApplyDiscount(campaign1, game1);

            // Oyunun oyuncuya satışının simule edilmesi
            BaseGameSalesManager gameSalesManager = new SteamGameSalesManager();
            gameSalesManager.Sell(game1,gamer1);

            Console.WriteLine(gamer1.UserName + " kullanıcısının sahip olduğu oyunlar: ");
            foreach (var game in gamer1.OwnedGames)
            {
                Console.WriteLine(game.Name);
            }

            
        }
    }
}
