﻿using DataAccess.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data
{
    public class ShopDbContext : IdentityDbContext<User>
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        public ShopDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(new[]
            {
                new Category() { Id = 1, Name = "Electronics" },
                new Category() { Id = 2, Name = "Sport" },
                new Category() { Id = 3, Name = "Fashion" },
                new Category() { Id = 4, Name = "Home & Garden" },
                new Category() { Id = 5, Name = "Transport" },
                new Category() { Id = 6, Name = "Toys & Hobbies" },
                new Category() { Id = 7, Name = "Musical Instruments" },
                new Category() { Id = 8, Name = "Art" },
                new Category() { Id = 9, Name = "Other" }
            });
            modelBuilder.Entity<City>().HasData(new[] 
            {
                new City() { Id = 1, Name = "Rivne"/*, CountryId = 1*/},
                new City() { Id = 2, Name = "Kiev" /*, CountryId = 1*/},
                new City() { Id = 3, Name = "Lviv" /*, CountryId = 1*/},
                new City() { Id = 4, Name = "Paris"/*, CountryId = 2*/}
            });

            modelBuilder.Entity<Country>().HasData(new[]
            {
                new Country() { Id = 1, Name = "Ukraine"},
                new Country() { Id = 2, Name = "French"}
            });
            modelBuilder.Entity<User>().HasData(new[]
            {
                new User() { Id = "07e54d3c-7ce2-43f0-8a19-70447ec2e478", UserName="default@gmail.com", Email="default@gmail.com", Birthdate=DateTime.Now.Date, PhoneNumber="+380980334755", Registerdate=DateTime.Now.Date},
            });

            modelBuilder.Entity<Product>().HasData(new[]
            {
                new Product() { Id = 1,UserId = "07e54d3c-7ce2-43f0-8a19-70447ec2e478", Name = "iPhone X", CategoryId = 1, CityId=1, Discount = 10, Price = 650, ImageUrl = "https://applecity.com.ua/image/cache/catalog/0iphone/ipohnex/iphone-x-black-1000x1000.png" },
                new Product() { Id = 2,UserId = "07e54d3c-7ce2-43f0-8a19-70447ec2e478", Name = "PowerBall", CategoryId = 2 , CityId=2, Price = 45.5M, ImageUrl = "https://http2.mlstatic.com/D_NQ_NP_727192-CBT53879999753_022023-V.jpg" },
                new Product() { Id = 3,UserId = "07e54d3c-7ce2-43f0-8a19-70447ec2e478", Name = "Nike T-Shirt", CategoryId = 3,  CityId=4, Discount = 15, Price = 189, InStock = true, ImageUrl = "https://www.seekpng.com/png/detail/316-3168852_nike-air-logo-t-shirt-nike-t-shirt.png" },
                new Product() { Id = 4,UserId = "07e54d3c-7ce2-43f0-8a19-70447ec2e478", Name = "Samsung S23", CategoryId = 1, CityId=1, Discount = 5, Price = 1200, InStock = true, ImageUrl = "https://sota.kh.ua/image/cache/data/Samsung-2/samsung-s23-s23plus-blk-01-700x700.webp" },
                new Product() { Id = 5,UserId = "07e54d3c-7ce2-43f0-8a19-70447ec2e478", Name = "Air Ball", CategoryId = 2, CityId=2, Price = 50, ImageUrl = "https://cdn.shopify.com/s/files/1/0046/1163/7320/products/69ee701e-e806-4c4d-b804-d53dc1f0e11a_grande.jpg" },
                new Product() { Id = 6,UserId = "07e54d3c-7ce2-43f0-8a19-70447ec2e478", Name = "MacBook Pro 2019", CategoryId = 1, CityId=3, Discount = 10, InStock = true, Price = 1200, ImageUrl = "https://newtime.ua/image/import/catalog/mac/macbook_pro/MacBook-Pro-16-2019/MacBook-Pro-16-Space-Gray-2019/MacBook-Pro-16-Space-Gray-00.webp" }
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var str = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OlxShop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(str);
        }
    }
}
