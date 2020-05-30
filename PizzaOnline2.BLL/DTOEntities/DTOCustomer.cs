using Microsoft.AspNetCore.Identity;
using PizzaOnline.BLL.DTOEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOnline2.BLL.DTOEntities
{
    public class DTOCustomer
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public byte[] Photo { get; set; }
    }
}
