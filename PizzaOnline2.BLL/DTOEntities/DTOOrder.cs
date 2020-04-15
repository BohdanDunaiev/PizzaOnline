using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOnline.BLL.DTOEntities
{
    public class DTOOrder
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DTOCustomer Customer { get; set; }
        public int PizzaId { get; set; }
        public DTOPizza Pizza { get; set; }
        public int PizzeriaId { get; set; }
        public DTOPizzeria Pizzeria { get; set; }
        public DTODelivery Delivery { get; set; }
        public int DeliveryId { get; set; }
    }
}
