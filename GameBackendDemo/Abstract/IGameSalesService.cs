using System;
using System.Collections.Generic;
using System.Text;
using GameBackendDemo.Entities;

namespace GameBackendDemo.Abstract
{
    public interface IGameSalesService
    {
        void Sell(Game game, Gamer gamer);
    }
}
