using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace PizzaOnline.DAL.Entities
{
    public class AspNetUsers : IdentityUser
    {
        public string Addres { get; set; }
        public ICollection<Order> Orders { get; set; }
        public AspNetUsers()
        {
        }
    }
}
