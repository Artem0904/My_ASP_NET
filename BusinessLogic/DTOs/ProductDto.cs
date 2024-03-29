﻿using System; 
namespace BusinessLogic.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public string? Description { get; set; }
        public bool InStock { get; set; }
        public string ImageUrl { get; set; }
        //public int? UserId { get; set; }
        //public string? UserName { get; set; }   ////TODO: User Name is required! NOT NULL
    }
}  
