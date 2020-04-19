using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PizzaOnline.DAL.Entities;

namespace PizzaOnline.DAL
{
    public class UserApplicationContext : IdentityDbContext<AspNetUsers>
    {
        public UserApplicationContext(DbContextOptions<UserApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
