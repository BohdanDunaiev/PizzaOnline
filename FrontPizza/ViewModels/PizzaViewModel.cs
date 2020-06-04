using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontPizza.ViewModels
{
    public class PizzaViewModel
    {
        public int id { get; set; }
        public int ingredientsId { get; set; }
        public string namePizza { get; set; }
        public int size { get; set; }
        public int price { get; set; }
        public string image { get; set; }
    }
}
