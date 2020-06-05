using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOnline2.BLL.DTOEntities
{
    public class DTOIngredients
    {
        public int Id { get; set; }
        public string Dough { get; set; }
        public string Cheese { get; set; }
        public string Tomate { get; set; }
        public string Meet { get; set; }
        public string Sous { get; set; }
        public string Additionally { get; set; }
    }
}
