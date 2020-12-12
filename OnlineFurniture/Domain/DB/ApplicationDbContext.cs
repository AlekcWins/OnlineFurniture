using OnlineFurniture.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using OnlineFurniture.Domain.Model;
using OnlineFurniture.Domain.Model.Common;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OnlineFurniture.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }
        public DbSet<Category> Categories { get; set; }
        
       


    }
}