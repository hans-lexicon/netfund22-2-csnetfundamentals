using WebApp.Models;

namespace WebApp.ViewModels
{
    public class ProductsDetailsViewModel
    {
        public string PageTitle { get; set; }
        public PathString Breadcrumb { get; set; }
        public Product Product { get; set; }
    }
}
