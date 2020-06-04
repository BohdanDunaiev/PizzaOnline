using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaOnline.DAL.Interface;

namespace PizzaOnline.DAL.Entities
{
    public class Pizza : IEntity<int>
    {
        public int Id { get; set; }
        public int IngredientsId { get; set; }
        public string NamePizza { get ; set; }  
        public int Size { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public ICollection<Order> Orders { get; set; }
        public Ingredients Ingredient { get; set; }
    }
}
