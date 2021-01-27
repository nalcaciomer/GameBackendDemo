using System;
using System.Collections.Generic;
using System.Text;
using GameBackendDemo.Entities;

namespace GameBackendDemo.Abstract
{
    public interface IGamerCheckService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
