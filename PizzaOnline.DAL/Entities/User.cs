using Microsoft.AspNetCore.Identity;

namespace PizzaOnline.DAL.Entities
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
        public User()
        {
        }
    }
}
