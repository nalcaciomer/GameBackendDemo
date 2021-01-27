using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using GameBackendDemo.Abstract;
using GameBackendDemo.Entities;

namespace GameBackendDemo.Concrete
{
    public abstract class GamerManager : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine("New gamer " + gamer.UserName + " added to database!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.UserName + " updated in database!");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.UserName + " deleted from database!");
        }
    }
}
