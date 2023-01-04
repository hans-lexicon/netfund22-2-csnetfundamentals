namespace WebApi.Models
{
    public class Product
    {
        public string Id { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Category { get; set; } = null!;
        public string ImageName { get; set; } = null!;
        public int Rating { get; set; }
        public decimal Price { get; set; }
    }
}
