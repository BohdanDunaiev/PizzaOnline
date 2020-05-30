using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaOnline.DAL.Interface;

namespace PizzaOnline.DAL.Entities
{
    public class Pizzeria : IEntity<int>
    {
        public int Id { get; set; }
        public string NamePizzeria { get; set; }
        public string Address { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
