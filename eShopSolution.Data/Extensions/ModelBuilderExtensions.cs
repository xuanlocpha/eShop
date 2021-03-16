using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed( this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
              new AppConfig() { Key = "HomeTitle", Value = "This is home page of eShopSolution" },
              new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of eShopSolution" },
              new AppConfig() { Key = "HomeDescription", Value = "This is description of eShopSolution" }
              );


            modelBuilder.Entity<Product>().HasData(
         new Product()
         {
             Id = 1,
             DateCreated = DateTime.Now,
             OriginalPrice = 250000,
             Price = 39000,
             Stock = 0,
             ViewCount = 0,
         });
            modelBuilder.Entity<ProductTranslation>().HasData(
                 new ProductTranslation()
                 {
                     Id = 1,
                     ProductId = 1,
                     Name = "Samsung Note 10+",
                     LanguageId = "vi",
                     SeoAlias = "Samsung Note 10+",
                     SeoDescription = "Samsung Note 10+",
                     SeoTitle = "Samsung Note 10+ new ",
                     Details = "Samsung Note 10+ new",
                     Description = "Samsung Note 10+ đên với camera 48MP"
                 },
                    new ProductTranslation()
                    {
                        Id = 2,
                        ProductId = 1,
                        Name = "Samsung Note 10+",
                        LanguageId = "en",
                        SeoAlias = "Samsung-Note-10+",
                        SeoDescription = "Samsung-Note-10+",
                        SeoTitle = "Samsung-Note-10+",
                        Details = "Samsung-Note-10+",
                        Description = "Samsung-Note-10+"
                    });
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                );


            modelBuilder.Entity<Language>().HasData(
               new Language() { Id = "vi", Name = "Tiếng Việt", IsDefault = true },
               new Language() { Id = "en", Name = "English", IsDefault = false });

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowHome = 1,
                    ParentId = 1,
                    SortOrder = 1,
                    Status = Status.Active,
                },
                 new Category()
                 {
                     Id = 2,
                     IsShowHome = 1,
                     ParentId = 1,
                     SortOrder = 2,
                     Status = Status.Active
                 });

            modelBuilder.Entity<CategoryTranslation>().HasData(
                  new CategoryTranslation() { Id = 1, CategoryId = 1, Name = "Áo nam", LanguageId = "vi", SeoAlias = "ao-nam", SeoDescription = "Sản phẩm áo thời trang nam", SeoTitle = "Sản phẩm áo thời trang nam" },
                  new CategoryTranslation() { Id = 2, CategoryId = 1, Name = "Men Shirt", LanguageId = "en", SeoAlias = "men-shirt", SeoDescription = "The shirt products for men", SeoTitle = "The shirt products for men" },
                  new CategoryTranslation() { Id = 3, CategoryId = 2, Name = "Áo nữ", LanguageId = "vi", SeoAlias = "ao-nu", SeoDescription = "Sản phẩm áo thời trang nữ", SeoTitle = "Sản phẩm áo thời trang women" },
                  new CategoryTranslation() { Id = 4, CategoryId = 2, Name = "Women Shirt", LanguageId = "en", SeoAlias = "women-shirt", SeoDescription = "The shirt products for women", SeoTitle = "The shirt products for women" }
                    );


            // any guid
            var roleId = new Guid("B09219DB-8402-414A-8938-60D964AC45FB");
            var adminId = new Guid("82A0B7C3-551B-44A7-8DB2-A7352E41C547");
           

            // any guid, but nothing is against to use the same one 

            // AspNetRole
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = adminId,
                Name = "Admin1",
                NormalizedName = "admin 1",
                Description = "Administrator role"
            });



            // AspNetUser
            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "User",
                NormalizedUserName = "Xuân Lộc",
                Email = "xuanloc.hcm2018@gmail.com",
                NormalizedEmail = "xuanloc.hcm2018@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                SecurityStamp = string.Empty,
                DisplayName = " Xuân Lộc",
                Gender = Gender.Male,
               
            });

        }
    }
}
