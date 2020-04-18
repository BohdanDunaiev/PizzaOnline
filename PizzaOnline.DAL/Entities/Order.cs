using System;

namespace PizzaOnline.DAL.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public int PizzaId { get; set; }
        public Pizza Pizza { get; set; }
        public int PizzeriaId { get; set; }
        public Pizzeria Pizzeria { get; set; }
        public Delivery Delivery { get; set; }
        public int DeliveryId { get; set; }
    }
}
