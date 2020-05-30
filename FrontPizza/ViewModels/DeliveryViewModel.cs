using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontPizza.ViewModels
{
    public class DeliveryViewModel
    {
        public int id { get; set; }
        public string nameDelivery { get; set; }
        public string time { get; set; }
        public int price { get; set; }
    }
}
