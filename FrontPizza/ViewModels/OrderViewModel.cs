using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontPizza.ViewModels
{
    public class OrderViewModel
    {
        public int id { get; set; }
        public int customerId { get; set; }
        public int pizzaId { get; set; }
        public int pizzeriaId { get; set; }
        public int deliveryId { get; set; }
    }
}
