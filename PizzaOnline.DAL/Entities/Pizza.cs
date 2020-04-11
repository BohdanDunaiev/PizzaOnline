using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOnline.DAL.Entities
{
    public class Pizza
    {
        public int Id { get; set; }
        public string NamePizza { get ; set; }  
        public int Size { get; set; }
        public int Price { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Ingredients> Ingredients { get; set; }
    }
}
