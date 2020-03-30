using Microsoft.EntityFrameworkCore;
using PizzaOnline2.Models;

namespace PizzaOnline2
{
    public class PizzaOnlineContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        //public DbSet<Delivery> Deliveries { get; set; }
        //public DbSet<Ingredients> Ingredients { get; set; }
        //public DbSet<Pizza> Pizza { get; set; }
        //public DbSet<Pizzeria> Pizzeria { get; set; }
        public PizzaOnlineContext(DbContextOptions<PizzaOnlineContext> options) : base(options)
        { }
    }
}
