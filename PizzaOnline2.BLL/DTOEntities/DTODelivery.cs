using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOnline.BLL.DTOEntities
{
    public class DTODelivery
    {
        public int Id { get; set; }
        public string NameDelivery { get; set; }
        public string Time { get; set; }
        public int Price { get; set; }
    }
}
