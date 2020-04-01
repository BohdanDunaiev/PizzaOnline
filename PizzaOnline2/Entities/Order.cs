using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOnline2.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int PizzaId { get; set; }
        public Pizza Pizza { get; set; }
        public int PizzeriaId { get; set; }
        public Pizzeria Pizzeria { get; set; }
        public Delivery Delivery { get; set; }
        public int DeliveryId { get; set; }
    }
}
