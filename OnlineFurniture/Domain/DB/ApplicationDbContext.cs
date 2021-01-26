using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineFurniture.Domain.Model;
using Shop.Domain.Models;

namespace Shop.Database
{
    public class ApplicationDbContext :IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts  { get; set; }
        public DbSet<Basket> Basket { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<IdentityUser> Users { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                .HasKey(x => new { x.UserId});
            modelBuilder.Entity<Basket>()
                .HasKey(x => new { x.BasketId });
            modelBuilder.Entity<Customer>()
                .HasKey(x => new { x.UserId});
            modelBuilder.Entity<OrderProduct>()
                .HasKey(x => new { x.ProductId, x.OrderId });
           
        }
    }
}
