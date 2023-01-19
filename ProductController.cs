using Microsoft.AspNetCore.Mvc;
using Shop.Api.Models;
using System.Collections.Generic;
using Shop.Api.Interfaces;
using Shop.Api.Data;

namespace Shop.Api.Controllers
{
    // це взяли з базового класу
    [ApiController]
    [Route("[controller]")]
    // буде повертати значення користувачу 
    public class ProductController : ControllerBase
    {
        private readonly IproductService _productService;
        public ProductController(IproductService productService)
        {
            this._productService = productService;
        }



        // щоб отримати інформацію 
        [HttpGet] //перед функцією, яку використовуємо  щоб працював json файл
        public IEnumerable<Product> Get()
        {
            return _productService.GetALLProducts();
        }

        // щоб додати інформацію
        [HttpPost]
        public IActionResult Post(Product product)
        {
            _productService.AddNewProduct(product);
            return Created("", product);
        }

        // [HttpDelete]   // https://localhost:5001/Product&id =3              вписуємо в хром щоб видалити елемент
        // доробити видаляє продукт по ід
        /* public IActionResult Delete([FromQuery] int id)
         {
             // якщо такий є   return Ok();

             // якщо немає   return NotFounf();

         }*/


        // дописати метод має виводити продукт ід якого ми вказали
        /*[HttpGet("GetByIdd")]
        public IActionResult GetById(Product product)
        {
            var product = _productService.GetproductById();
            if (product == null)
                return NotFound();
            else
                return Ok();
        }*/

    }
}
