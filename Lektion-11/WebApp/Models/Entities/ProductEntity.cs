namespace WebApp.Models.Entities
{
    public class ProductEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = null!;

        public int TagId { get; set; }
        public TagEntity Tag { get; set; } = null!;

        public int CategoryId { get; set; }
        public CategoryEntity Category { get; set; } = null!;
    
    }
}
