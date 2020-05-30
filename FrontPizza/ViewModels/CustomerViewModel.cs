using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontPizza.ViewModels
{
    public class CustomerViewModel
    {
        public int id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string adress { get; set; }
        public string phoneNumber { get; set; }
        public byte[] photo { get; set; }
    }
}
