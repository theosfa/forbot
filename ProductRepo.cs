using Shop.Api.Interfaces;
using Shop.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Api.Data
{
    // містить базу данних і повертає всі її елементи
    public class ProductRepo : IProductRepo
    {
        // замість цього маэ бути база данних
        private static List<Product> _products = new List<Product>
        {
          new Product{ id =1, Category = "Rover", Name = "" },
          new Product{ id =1, Category = "Rover", Name = "" },

    };

        public void Perewirka()
        {
            _products.Contains();            
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        // тут дописати перевірку чи існує такий продукт
       /* public void GetproductById()
        { 
        
        }*/

        public IEnumerable<Product> GetAllProducts()
        {
              return _products; //взяти дані з бд замість цього
        }
    }
}
