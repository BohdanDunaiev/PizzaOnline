using PizzaOnline.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOnline.DAL.Entities
{
    public class Delivery : IEntity<int>
    {
        public int Id { get; set; }
        public string NameDelivery { get; set; }
        public string Time { get; set; }
        public int Price { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
