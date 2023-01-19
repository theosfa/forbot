using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Api.Models
{
    public class Product
    {
        public int id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Quntity { get; set; }

        public string Category { get; set; }

    }
}
