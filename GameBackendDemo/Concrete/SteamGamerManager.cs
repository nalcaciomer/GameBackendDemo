using System;
using System.Collections.Generic;
using System.Text;
using GameBackendDemo.Abstract;
using GameBackendDemo.Entities;

namespace GameBackendDemo.Concrete
{
    public class SteamGamerManager : GamerManager
    {
        private IGamerCheckService _gamerCheckService;

        public SteamGamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public override void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                base.Add(gamer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }

        // Veritabanında güncelleme ve silme işlemleri için mernis kontrolü oluşturmadım.
        // Çünkü veritabanına kişi zaten mernisten kontrol edilerek ekleniyor.
        // Veritabanında güncellemek veya silmek isteniyorsa bu kişinin veritabanında olup olmadığıhı kontrol etmek yeterlidir.
    }
}
