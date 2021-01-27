using System;
using System.Collections.Generic;
using System.Text;
using GameBackendDemo.Abstract;

namespace GameBackendDemo.Entities
{
    public class Campaign : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Discount { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
    }
}
