using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PizzaOnline.DAL.Entities;

namespace PizzaOnline.DAL
{
    public class AplicationContext : IdentityDbContext<User, Role, int>
    {
        public AplicationContext(DbContextOptions<AplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Order>()
                .HasOne(p => p.Customer)
                .WithMany(t => t.Orders);

            modelBuilder.Entity<Order>()
               .HasOne(p => p.Delivery)
               .WithMany(t => t.Orders);

            modelBuilder.Entity<Order>()
                .HasOne(p => p.Pizza)
                .WithMany(t => t.Orders);

            modelBuilder.Entity<Order>()
                .HasOne(p => p.Pizzeria)
                .WithMany(t => t.Orders);

            modelBuilder.Entity<Ingredients>()
                .HasOne(p => p.PizzaIngreedients)
                .WithMany(t => t.Ingredients);
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Delivery> Delivery { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<Pizzeria> Pizzeria { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}
