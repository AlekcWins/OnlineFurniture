using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using OnlineFurniture.Domain.Model;
using OnlineFurniture.Models;


namespace OnlineFurniture.Domain.DB
{
    public class ApplicationDbContext : ApiAuthorizationDbContext < ApplicationUser >
    {
        public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts  { get; set; }
        public DbSet<Basket> Basket { get; set; }
        public DbSet<Customer> Customers { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Basket>()
                .HasKey(x => new { x.BasketId });
            modelBuilder.Entity<Customer>()
                .HasKey(x => new { x.UserId});
            modelBuilder.Entity<OrderProduct>()
                .HasKey(x => new { x.ProductId, x.OrderId });
           
        }
    }
}
