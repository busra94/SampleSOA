using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        HttpClient client = new HttpClient();

        List<Product> products = new List<Product>();

        //[HttpPost]
        //public string PostProduct(Product product)
        //{
        //    products.Add(product);

        //    if (!ModelState.IsValid)
        //        return "bad request";

        //    return "success";

        //}

        [HttpPost]
        public void AddProduct([FromBody]Product product)
        {           
            products.Add(product);

        }



        [HttpGet]
        public List<Product> GetProduct()
        {
            products.Add(
                new Product() {
                Name = "Gizmo",
                Price = 34m,
                Category = "Pet"
            });

            products.Add(
                new Product()
            {
                Name = "Shadowfax",
                Price = 1000,
                Category = "Pet"

            });
            return products;
        }

        //[HttpPut]
        //public bool UpdateProduct()
        //{
        //    return true;
        //}
        //[HttpDelete]
        //public bool DeleteProduct()
        //{
        //    return true;
        //}

    }
}