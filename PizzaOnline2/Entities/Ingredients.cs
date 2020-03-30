using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOnline2.Entities
{
    public class Ingredients
    {
        public int Id { get; set; }
        public int pizzaId { get; set; }
        public string cheese { get; set; }
        public string tomate { get; set; }
        public string sausege { get; set; }
        public string sous { get; set; }
    }
}
