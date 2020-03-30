using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOnline2.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Addres { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
