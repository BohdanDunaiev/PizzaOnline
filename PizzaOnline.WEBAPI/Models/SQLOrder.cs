using PizzaOnline.DAL.Interfaces.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOnline.Models
{
    public class SQLOrder : IEntity<int>
    {
        public int Id { get; set; }
        public int customerId { get; set; }
        public int pizzaId { get; set; } 
        public int pizzeriaId { get; set; }
        public int deliveryId { get; set; }
    }
}
