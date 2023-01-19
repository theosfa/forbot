using Shop.Api.Interfaces;
using Shop.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Api.Services
{
    // щоб вивести екземпляри класу Product
    public class ProductService : IproductService
    {
        private readonly IProductRepo productRepo;

        public ProductService(IProductRepo productRepo) // отримує екземпляри класу Product
        {
            this.productRepo = productRepo;
        }

        public void AddNewProduct(Product product)
        {
            // перевіряємо чи всі поля заповнені
            // перевіряємо чи немає такого продукту в базі, якщо є, збільшуємо кількість

            productRepo.Add(product);
        }

        public IEnumerable<Product> GetALLProducts() //повертає екземпляри класу Product
        {
            return productRepo.GetAllProducts();
        }
    }
}
