using System;
using System.Collections.Generic;
using System.Text;
using GameBackendDemo.Abstract;

namespace GameBackendDemo.Entities
{
    public class Game : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Types { get; set; } 
        public decimal Price { get; set; }
    }
}
