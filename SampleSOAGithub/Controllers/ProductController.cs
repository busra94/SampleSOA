using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleSOAGithub.Models;
using System.Net.Http.Headers;

namespace SampleSOAGithub.Controllers
{
    public class ProductController : Controller
    {
        //public IActionResult Index(Product product)
        //{
        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = new Uri("http://localhost:52692/");
        //    client.DefaultRequestHeaders.Clear();
        //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //    var response = 
        //    product = new Product {
        //        Name = "Phone",
        //        Price = 1500m,
        //        Category = "Electronic"                
        //    };
        //    return View();
        //}

        public IActionResult Index()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:52692/");
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/product").GetAwaiter().GetResult();

            if (response.IsSuccessStatusCode)
            {
                Product product = response.Content.ReadAsAsync<Product>().GetAwaiter().GetResult();

                //var responseAPI = response.Content.ReadAsStringAsync().Result;            

                Console.WriteLine(response);

                
                return View(product);
            }

            return View();
        }
    }

}