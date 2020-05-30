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
            #region Order
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
            #endregion

            #region Ingredients
            modelBuilder.Entity<Ingredients>()
               .HasOne(p => p.PizzaIngreedients)
               .WithMany(t => t.Ingredients);

            modelBuilder.Entity<Ingredients>()
               .Property(p => p.PizzaId)
               .IsRequired();

            modelBuilder.Entity<Ingredients>()
               .Property(p => p.Id)
               .IsRequired();
            #endregion

            #region Customer
            modelBuilder.Entity<Customer>()
                .Property(p => p.LastName)
                .HasMaxLength(45);

            modelBuilder.Entity<Customer>()
                .Property(p => p.FirstName)
                .HasMaxLength(45);

            modelBuilder.Entity<Customer>()
                .Property(p => p.SecondName)
                .HasMaxLength(45);

            modelBuilder.Entity<Customer>()
                .Property(p => p.Adress)
                .HasMaxLength(45);

            modelBuilder.Entity<Customer>()
                .Property(p => p.PhoneNumber)
                .HasMaxLength(45);

            modelBuilder.Entity<Customer>()
                .HasOne<User>(u => u.User)
                .WithOne(c => c.Customer)
                .HasForeignKey<User>(c => c.CustomerId);
            #endregion

            #region Delivery
            modelBuilder.Entity<Delivery>()
                .Property(p => p.Id)
                .IsRequired();

            modelBuilder.Entity<Delivery>()
                .Property(p => p.NameDelivery)
                .HasMaxLength(45);

            modelBuilder.Entity<Delivery>()
                .Property(p => p.Time)
                .HasMaxLength(45);

            modelBuilder.Entity<Delivery>()
                .Property(p => p.Price)
                .HasMaxLength(45);
            #endregion

            #region Pizza
            modelBuilder.Entity<Pizza>()
                .Property(p => p.Id)
                .IsRequired();

            modelBuilder.Entity<Pizza>()
               .Property(p => p.NamePizza)
               .HasMaxLength(45);

            modelBuilder.Entity<Pizza>()
              .Property(p => p.Size)
              .HasMaxLength(45);

            modelBuilder.Entity<Pizza>()
              .Property(p => p.Price)
              .HasMaxLength(45);
            #endregion

            #region Pizzeria
            modelBuilder.Entity<Pizzeria>()
                .Property(p => p.Id)
                .IsRequired();

            modelBuilder.Entity<Pizzeria>()
               .Property(p => p.NamePizzeria)
               .HasMaxLength(45);

            modelBuilder.Entity<Pizzeria>()
              .Property(p => p.Address)
              .HasMaxLength(45);
            #endregion

            modelBuilder.Entity<Customer>().HasData(new Customer[]
            {
                new Customer{Id=1, FirstName="Admin", LastName="Admin", SecondName="Admin"}
            });
        }

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Delivery> Delivery { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<Pizzeria> Pizzeria { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}
