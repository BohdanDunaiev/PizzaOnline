using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaOnline.DAL.Interface;

namespace PizzaOnline.DAL.Entities
{
    public class Ingredients : IEntity<int>
    {
        public int Id { get; set; }
        public string Dough { get; set; }
        public string Cheese { get; set; }
        public string Tomate { get; set; }
        public string Meet { get; set; }
        public string Sous { get; set; }
        public string Additionally { get; set; }
        public ICollection<Pizza> Pizza { get; set; }
    }
}
