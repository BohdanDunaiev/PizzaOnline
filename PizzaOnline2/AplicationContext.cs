using Microsoft.EntityFrameworkCore;
using PizzaOnline2.Entities;

namespace PizzaOnline2
{
    public class AplicationContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        //public DbSet<Ingredients> Ingredients { get; set; }
        //public DbSet<Pizza> Pizza { get; set; }
        //public DbSet<Pizzeria> Pizzeria { get; set; }
        //app conntext
        //public AplicationContext(DbContextOptions<AplicationContext> options) : base(options)
        //{ }
        public AplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PizzaOnline;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Product>()
            //    .HasOne(p => p.ProductType)
            //    .WithMany(t => t.Products)
            //    .HasForeignKey(p => p.ProductTypeId);

            //modelBuilder.Entity<Order>()
            //    .HasOne(p => p.Product)
            //    .WithMany(t => t.Orders)
            //    .HasForeignKey(p => p.ProductId);

            modelBuilder.Entity<Order>()
                .HasOne(p => p.Customer)
                .WithMany(t => t.Orders)
                .HasForeignKey(p => p.CustomerId);

            modelBuilder.Entity<Order>()
               .HasOne(p => p.Delivery)
               .WithMany(t => t.Orders)
               .HasForeignKey(p => p.DeliveryId);
        }
    }
}
