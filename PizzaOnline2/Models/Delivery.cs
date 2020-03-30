using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOnline2.Models
{
    public class Delivery
    {
        public int Id { get; set; }
        public string nameDelivery { get; set; }
        public DateTime time { get; set; }
        public int price { get; set; }
    }
}
