using Microsoft.AspNetCore.Identity;
using PizzaOnline.DAL.Interface;
using System.Collections.Generic;

namespace PizzaOnline.DAL.Entities
{
    public class Customer : IEntity<int>
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public byte[] Photo { get; set; }
        public User User { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
