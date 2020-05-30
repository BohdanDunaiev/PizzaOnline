using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOnline2.BLL.DTOEntities
{
    public class UserLoginDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
