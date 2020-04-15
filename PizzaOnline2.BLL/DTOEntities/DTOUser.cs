using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOnline2.BLL.DTOEntities
{
    public class DTOUser : IdentityUser
    {
        public int Year { get; set; }
        public DTOUser()
        {
        }
    }
}
