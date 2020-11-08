using ProductsApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace ProductsApp1.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Cold War", Category = "Video Games", Price = 60.00M },
            new Product { Id = 2, Name = "Pecan Turtles", Category = "Candy", Price = 2.75M },
            new Product { Id = 3, Name = "Pants", Category = "Clothing", Price = 22.99M }
        };
        public ProductsController()
        {
        }
        public ProductsController(Product[] products)
        {
            this.products = products;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}