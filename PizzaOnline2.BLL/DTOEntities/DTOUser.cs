using Microsoft.AspNetCore.Identity;
using PizzaOnline.BLL.DTOEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOnline2.BLL.DTOEntities
{
    public class DTOUser : IdentityUser
    {
        public string Addres { get; set; }
        public ICollection<DTOOrder> DTOOrders { get; set; }
        public DTOUser()
        {
        }
    }
}
