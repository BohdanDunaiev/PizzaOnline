using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOnline.BLL.DTOEntities
{
    public class DTOCustomer
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Addres { get; set; }
        public ICollection<DTOOrder> Orders { get; set; }
    }
}
