using Shop.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Api.Interfaces
{
    public interface IproductService // отримує екземпляри класу Product
    {
        IEnumerable<Product> GetALLProducts();

        void AddNewProduct(Product product);
    }
}
