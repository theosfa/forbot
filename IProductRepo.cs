using Shop.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Api.Interfaces
{
    public interface IProductRepo
    {
        public IEnumerable<Product> GetAllProducts(); //отримує екземпляри класу Product

        void Add(Product product);
    }
}
