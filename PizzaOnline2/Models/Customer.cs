using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOnline2.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string fullname { get; set; }
        public string addres { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
