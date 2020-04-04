using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOnline2.DAL.Entities
{
    public class Pizzeria
    {
        public int Id { get; set; }
        public string NamePizzeria { get; set; }
        public string Address { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
