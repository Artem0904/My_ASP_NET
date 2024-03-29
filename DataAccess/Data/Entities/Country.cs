﻿namespace DataAccess.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<City> Cities { get; set; } = new HashSet<City>();
    }
}
