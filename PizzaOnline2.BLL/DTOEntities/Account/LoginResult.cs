using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOnline2.BLL.DTOEntities
{
    public class LoginResult
    {
        public bool successful { get; set; }
        public string error { get; set; }
        public string token { get; set; }
    }
}
