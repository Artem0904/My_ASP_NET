﻿using System.Reflection;
using DataAccess.Data.Entities;
namespace DataAccess.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public bool InStock { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public Category? Category { get; set; }
        public int CityId { get; set; }
        public City? City { get; set; }
        public string UserId { get; set; }
        public User? User { get; set; }
    }
}