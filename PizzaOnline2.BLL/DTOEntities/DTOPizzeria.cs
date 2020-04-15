using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOnline.BLL.DTOEntities
{
    public class DTOPizzeria
    {
        public int Id { get; set; }
        public string NamePizzeria { get; set; }
        public string Address { get; set; }
        public ICollection<DTOOrder> Orders { get; set; }
    }
}
