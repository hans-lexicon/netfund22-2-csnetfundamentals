using _00_Repetition.Models;
using Newtonsoft.Json;

namespace _00_Repetition.Services
{
    public class ProductService
    {
        private readonly string filePath = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\list.json";
        private List<Product> productList;
        private readonly FileService _fileService;

        public ProductService(FileService fileService)
        {
            _fileService = fileService;
            try
            {
                productList = JsonConvert.DeserializeObject<List<Product>>(_fileService.ReadFromFile(filePath)) ?? null!;
            }
            catch 
            {
                productList = new List<Product>();
            }
        }

        public void AddToList(Product product)
        {
            var _product = productList.FirstOrDefault(x => x.Name == product.Name);
            if (_product == null)
            {
                productList.Add(product);
                _fileService.SaveToFile(filePath, JsonConvert.SerializeObject(productList));
            }
        }

        public void RemoveFromList(int id)
        {
            var _product = productList.FirstOrDefault(x => x.Id == id);
            if (_product != null)
            {
                productList = productList.Where(x => x.Id != id).ToList();
                _fileService.SaveToFile(filePath, JsonConvert.SerializeObject(productList));
            }
        }

        public IEnumerable<Product> GetList()
        {
            return productList;
        }

        public Product Get(int id)
        {
            var _product = productList.FirstOrDefault(x => x.Id == id);
            if (_product != null)
            {
                return _product;
            }

            return null!;
        }
    }
}
