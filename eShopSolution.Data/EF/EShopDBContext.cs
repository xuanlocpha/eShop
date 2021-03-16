using eShopSolution.Data.Configurations;
using eShopSolution.Data.Entities;
using eShopSolution.Data.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.EF
{
    public class EShopDBContext : IdentityDbContext<AppUser,AppRole,Guid>
    {
        public EShopDBContext( DbContextOptions options) : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure using Fluent API

            modelBuilder.ApplyConfiguration(new AppConfigConfigurations());
            modelBuilder.ApplyConfiguration(new CategoryConfigurations());
            modelBuilder.ApplyConfiguration(new CategoryTranslationConfigurations());
            modelBuilder.ApplyConfiguration(new ContactConfigurations());
            modelBuilder.ApplyConfiguration(new CartConfigurations());

            modelBuilder.ApplyConfiguration(new LanguageConfigurations());
            modelBuilder.ApplyConfiguration(new OrderConfigurations());
            modelBuilder.ApplyConfiguration(new OrderDetailConfigurations());
            modelBuilder.ApplyConfiguration(new ProductConfigurations());
            modelBuilder.ApplyConfiguration(new ProductInCategoryConfigurations());
            modelBuilder.ApplyConfiguration(new ProductTranslationConfigurations());
            modelBuilder.ApplyConfiguration(new PromotionConfigurations());
            modelBuilder.ApplyConfiguration(new TransactionConfigurations());
            modelBuilder.ApplyConfiguration(new AppRoleConfigurations());
            modelBuilder.ApplyConfiguration(new AppUserConfigurations());

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AspUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AspUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AspUserLogins").HasKey(x => x.UserId);

            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AspRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AspUserTokens").HasKey(x => x.UserId);
            //Data Seeding
            modelBuilder.Seed();
            //base.OnModelCreating(modelBuilder);
          
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AppConfig> AppConfigs { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CategoryTranslation> CategoryTranslations { get; set; }
        public DbSet<ProductInCategory> ProductInCategories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ProductTranslation> ProductTranslations { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<AppUser> AppUsers{ get; set; }
        public DbSet<AppRole>AppRoles { get; set; }
    }
}
