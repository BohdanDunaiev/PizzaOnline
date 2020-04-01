using Microsoft.EntityFrameworkCore;
using PizzaOnline2.Entities;

namespace PizzaOnline2
{
    public class AplicationContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<Pizzeria> Pizzeria { get; set; }  
        public AplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KING;Database=PizzaOnline;Trusted_Connection=True;");
            //Server = (localdb)\\mssqllocaldb
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasOne(p => p.Customer)
                .WithMany(t => t.Orders)
                .HasForeignKey(k => k.CustomerId);
            
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
    }
}
