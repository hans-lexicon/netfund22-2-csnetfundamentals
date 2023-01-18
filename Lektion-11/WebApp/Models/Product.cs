﻿namespace WebApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = null!;

        public string Tag { get; set; } = null!;
        public string Category { get; set; } = null!;

    }
}
