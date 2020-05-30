using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace PizzaOnline.DAL.Entities
{
    public class User : IdentityUser<int>
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
