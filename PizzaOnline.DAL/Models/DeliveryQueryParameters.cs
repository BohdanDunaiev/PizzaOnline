using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOnline.DAL.Models
{
    public class DeliveryQueryParameters : QueryStringParameters
    {
        public DeliveryQueryParameters()
        {
            OrderBy = "name";
        }
    }
}
