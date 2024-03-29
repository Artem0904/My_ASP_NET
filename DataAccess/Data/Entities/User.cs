﻿using DataAccess.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace DataAccess.Data.Entities
{
    public class User : IdentityUser
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public string Login { get; set; }
        //public string Email { get; set; }
        //public string Password { get; set; }
        //public int? Age { get; set; }
        //public ICollection<Product> Products { get; set; } = new HashSet<Product>();
        //public int? ContactInfoId { get; set; }
        //public ContactInfo? ContactInfo { get; set; }

        public DateTime Birthdate { get; set; }
        public ICollection<Order>? Orders { get; set; }
    }
}