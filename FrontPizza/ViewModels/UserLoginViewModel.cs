using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontPizza.ViewModels
{
    public class UserLoginViewModel
    {
        public string userName { get; set; }
        public string password { get; set; }
        public bool rememberMe { get; set; }
    }
}
