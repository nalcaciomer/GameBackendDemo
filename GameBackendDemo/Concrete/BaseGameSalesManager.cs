using System;
using System.Collections.Generic;
using System.Text;
using GameBackendDemo.Abstract;
using GameBackendDemo.Entities;

namespace GameBackendDemo.Concrete
{
    public abstract class BaseGameSalesManager : IGameSalesService
    {
        public void Sell(Game game, Gamer gamer)
        {
            if (gamer.Balance > game.Price)
            {
                gamer.OwnedGames.Add(game);
                gamer.Balance -= game.Price;
                Console.WriteLine(game.Name + " oyunu " + gamer.UserName + " kullanıcısına başarılı bir şekilde satılmıştır!");
                Console.WriteLine("Hesabınızda kalan bakiye: " + gamer.Balance);
            }
            else
            {
                Console.WriteLine("Hesabınızda yeterli bakiye bulunmamaktadır!");
                Console.WriteLine(game.Name + " satın alabilmek için hesabınıza minimum " + (game.Price - gamer.Balance) + " TL yatırmalısınız!");
            }
        }
    }
}
