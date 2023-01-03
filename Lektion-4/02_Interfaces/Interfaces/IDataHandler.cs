using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Interfaces.Interfaces
{
    internal interface IDataHandler<T> where T : class
    {
        void CreateOne(T model);
        T GetOne(string id);
        IEnumerable<T> GetAll();
        T UpdateOne(string id, T model);
        bool DeleteOne(string id);
    }
}
