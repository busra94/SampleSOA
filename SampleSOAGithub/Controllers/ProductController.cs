using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleSOAGithub.Models;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace SampleSOAGithub.Controllers
{
    public class ProductController : Controller
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response;

        List<Product> products = new List<Product>();
        public IActionResult Index()
        {
            // GET PRODUCTS

            client.BaseAddress = new Uri("http://localhost:52692/");
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            response = client.GetAsync("api/product").GetAwaiter().GetResult();

            if (response.IsSuccessStatusCode)
            {
                products = response.Content.ReadAsAsync<List<Product>>()
                               .GetAwaiter().GetResult() ;

                
               // Product product = response.Content.ReadAsAsync<Product>().GetAwaiter().GetResult();
                
                
                //var responseAPI = response.Content.ReadAsStringAsync().Result;            

                Console.WriteLine(response);
                
                return View(products);
            }

            return View();
        }

        public Product AddProduct()
        {
            client.BaseAddress = new Uri("http://localhost:52692/");
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            Product product = new Product()
            {
                Name = "product3",
                Category = "category1",
                Price = 1000
            };

            products.Add(product);
            response = client.PostAsJsonAsync("api/product", product).Result;

            if (response.IsSuccessStatusCode)
            {
                return product;
                //return product;
            }
            else
            {
                return null;
            }



           // return View();
        }

        //public IActionResult AddProduct() {
        //    //ADD PRODUCT
        //    var horse = new Product() { Name = "Shadowfax", Category="pet", Price = 1000 };

        //    client.BaseAddress = new Uri("http://localhost:52692/");
        //    client.DefaultRequestHeaders.Clear();
        //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //    response = client.PostAsJsonAsync("api/products", horse).GetAwaiter().GetResult();

        //    if (response.IsSuccessStatusCode)
        //    {
        //        Uri url = response.Headers.Location;
        //    }


        //    return View(horse);
        //}
            
    }

}