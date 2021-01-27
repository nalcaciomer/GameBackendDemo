using System;
using System.Collections.Generic;
using System.Text;
using GameBackendDemo.Entities;

namespace GameBackendDemo.Abstract
{
    public interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
