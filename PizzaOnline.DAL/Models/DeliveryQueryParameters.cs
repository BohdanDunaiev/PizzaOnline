using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOnline.DAL.Models
{
    public class DeliveryQueryParameters : QueryStringParameters
    {
        public uint MinPrice { get; set; }
        public uint MaxPrice { get; set; }

        public bool ValidYearRange => MaxPrice > MinPrice;
        public DeliveryQueryParameters()
        {
            OrderBy = "name";
        }
        public string Name { get; set; }
    }
}
