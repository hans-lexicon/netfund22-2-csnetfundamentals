namespace WebApp.Models.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Product> FeaturedProducts { get; set; } = null!;
        public IEnumerable<Product> OutgoingProducts { get; set; } = null!;
    }
}
