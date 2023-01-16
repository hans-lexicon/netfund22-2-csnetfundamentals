using WebApp.Models;

namespace WebApp.ViewModels
{
    public class HomeIndexViewModel
    {
        public string PageTitle { get; set; } = "Welcome to Fixxo";
        public IEnumerable<Product> FeaturedProducts { get; set; }
    }
}
