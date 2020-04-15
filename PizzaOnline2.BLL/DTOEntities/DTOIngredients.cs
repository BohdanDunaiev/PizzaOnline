using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOnline.BLL.DTOEntities
{
    public class DTOIngredients
    {
        public int Id { get; set; }
        public int PizzaId { get; set; }
        public string Cheese { get; set; }
        public string Tomate { get; set; }
        public string Sausege { get; set; }
        public string Sous { get; set; }
        public DTOPizza PizzaIngreedients { get; set; }
    }
}
