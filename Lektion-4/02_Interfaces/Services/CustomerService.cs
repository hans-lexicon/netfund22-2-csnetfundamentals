using _02_Interfaces.Interfaces;
using _02_Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Interfaces.Services
{
    internal class CustomerService : IDataHandler<Customer>
    {
        public void CreateOne(Customer model)
        {
            var customer = new Customer()
            {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email
            };
        }

        public Customer GetOne(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer UpdateOne(string id, Customer model)
        {
            throw new NotImplementedException();
        }

        public bool DeleteOne(string id)
        {
            throw new NotImplementedException();
        }
    }
}
