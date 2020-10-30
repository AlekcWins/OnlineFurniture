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
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Product>(b =>
            {
                
                b.ToTable("Products");
                EntityId(b);
                b.Property(x => x.Name)
                .HasColumnName("Name")
                .IsRequired();
                b.Property(x => x.Price)
                .HasColumnName("Price")
                .IsRequired();
                b.Property(x => x.Description)
                .HasColumnName("Description")
                .IsRequired();
                b.Property(x => x.Producer)
                .HasColumnName("Producer")
                .IsRequired();
                b.Property(x => x.Width)
                .HasColumnName("Width")
                .IsRequired();
                b.Property(x => x.Length)
                .HasColumnName("Length")
                .IsRequired();
                b.Property(x => x.Height)
                .HasColumnName("Height")
                .IsRequired();
                b.Property(x => x.Material)
                .HasColumnName("Material")
                .IsRequired();
                b.Property(x => x.Category)
                .HasColumnName("Category")
                .IsRequired();
            });

            builder.Entity<Category>(b =>
            {
                b.HasOne(x => x.CategoryName)
                .WithMany()
                .IsRequired();
              
            });
            builder.Entity<Stock>(b =>
            {
                b.Property(x => x.Product)
                .HasColumnName("Name")
                .IsRequired();
                b.Property(x => x.Quantity)
                .HasColumnName("Quantity")
                .IsRequired();

            });

            builder.Entity<Order>(b =>
            {
                b.Property(x => x.Basket)
                .HasColumnName("Order")
                .IsRequired();
                b.Property(x => x.User)
                .HasColumnName("User")
                .IsRequired();
            });
            builder.Entity<User>(b =>
            {
                b.Property(x => x.Role)
                .HasColumnName("Role")
                .IsRequired();
                b.Property(x => x.Surname)
                .HasColumnName("Surname")
                .IsRequired();
                b.Property(x => x.Name)
                .HasColumnName("Name")
                .IsRequired();
                b.Property(x => x.Patronymic)
                .HasColumnName("Patronymic")
                .IsRequired();
                b.Property(x => x.Address)
                .HasColumnName("Address")
                .IsRequired();
                b.Property(x => x.Phone)
                .HasColumnName("Phone")
                .IsRequired();
            });
            builder.Entity<Basket>(b =>
            {
                b.Property(x => x.Product)
                .HasColumnName("Name")
                .IsRequired();
                b.Property(x => x.Quantity)
                .HasColumnName("Quantity")
                .IsRequired();

            });
        }
        private static void EntityId<TEntity>(EntityTypeBuilder<TEntity> builder)
            where TEntity : Entity
        {
            builder.Property(x => x.Id)
                .HasColumnName("Id")
                .IsRequired();
            builder.HasKey(x => x.Id)
                .HasAnnotation("Npgsql:Serial", true);
         }
    }
}