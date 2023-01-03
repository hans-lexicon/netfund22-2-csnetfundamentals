using _02_Interfaces.Interfaces;
using _02_Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Interfaces.Services
{
    internal class ProductService : IDataHandler<Product>
    {
        public void CreateOne(Product model)
        {
            throw new NotImplementedException();
        }

        public Product GetOne(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product UpdateOne(string id, Product model)
        {
            throw new NotImplementedException();
        }

        public bool DeleteOne(string id)
        {
            throw new NotImplementedException();
        }
    }
}
