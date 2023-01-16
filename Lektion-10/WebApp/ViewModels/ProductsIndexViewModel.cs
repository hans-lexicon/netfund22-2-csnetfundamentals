using WebApp.Models;

namespace WebApp.ViewModels
{
    public class ProductsIndexViewModel
    {
        public string PageTitle { get; set; }
        public PathString Breadcrumb { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
