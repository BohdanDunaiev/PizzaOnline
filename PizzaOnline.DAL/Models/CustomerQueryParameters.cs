using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOnline.DAL.Models
{
    public class CustomerQueryParameters : QueryStringParameters
    {
        public string LastName { get; set; }
    }
}
