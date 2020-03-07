using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOnline.DAL.Models
{
    public class OrderJoin
    {
        public int Id { get; set; }
        public string  fullname { get; set; }
        public string addres { get; set; }
        public int size { get; set; }
        public int pricePizza { get; set; }
        public string namePizza { get; set; }
        public string address { get; set; }
        public string nameDelivery { get; set; }
        public int price { get; set; }
    }
}
