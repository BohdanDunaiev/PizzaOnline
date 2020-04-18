using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace PizzaOnline.DAL.Entities
{
    public class User : IdentityUser
    {
        public string Addres { get; set; }
        public ICollection<Order> Orders { get; set; }
        public User()
        {
        }
    }
}
