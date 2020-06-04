using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOnline.BLL.DTOEntities
{
    public class DTOPizza
    {
        public int Id { get; set; }
        public int IngredientsId { get; set; }
        public string NamePizza { get ; set; }  
        public int Size { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
    }
}
