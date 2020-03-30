using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOnline2.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int customerId { get; set; }
        public int pizzaId { get; set; }
        public int pizzeriaId { get; set; }
        public int deliveryId { get; set; }
        public Customer customer { get; set; }
    }
}
