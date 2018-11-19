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

        //[HttpPost]
        //public HttpResponseMessage AddProduct(Product product)
        //{

        //    HttpResponseMessage response = client.PostAsJsonAsync("api/products", product)
        //                                   .GetAwaiter().GetResult();
        //    response.EnsureSuccessStatusCode();

        //    return response;
        //}

        [HttpGet]
        public Product GetProduct()
        {
            Product product = new Product()
            {
                Name = "Gizmo",
                Price = 34m,
                Category = "pet"            

            };
            return product;
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