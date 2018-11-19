using System;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using SampleSOAGithub.Models;

namespace SampleSOAGithub.Controllers
{
    public class RandomController : Controller
    {
        private const string BASE_URL = "http://localhost:52692/";
        public IActionResult Index()
        {
            var client = new HttpClient(); 
            // Creating a new HttpClient instance per request can exhaust the available sockets). So you should consider removing Using(). using(var cli = new HttpClient()){//....}

            client.BaseAddress = new Uri(BASE_URL);

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); // BAAKK

            HttpResponseMessage responseRandom = client.GetAsync("api/random").GetAwaiter().GetResult();

            if (responseRandom.IsSuccessStatusCode)
            {
                var responseAPI = responseRandom.Content.ReadAsStringAsync().Result;

                RandomInteger random = new RandomInteger();
                random.RandomInt = Convert.ToInt32(responseAPI);

                return View(random);
            }

            return View();
        }

        //Produce maximum number        
        //public IActionResult Get()
        //{
        //    using (var client = new HttpClient())
        //    {

        //        client.BaseAddress = new Uri(BASE_URL);

        //        client.DefaultRequestHeaders.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); // BAAKK

        //        HttpResponseMessage responseMaxRandom = client.GetAsync("api/random/" ).GetAwaiter().GetResult();

        //        if (responseMaxRandom.IsSuccessStatusCode)
        //        {
        //            var responseAPI = responseMaxRandom.Content.ReadAsStringAsync().Result;

        //            RandomInteger random = new RandomInteger();
        //            random.RandomMax = Convert.ToInt32(responseAPI);

        //            return View("Index",random);
        //        }

        //    }
        //    return View();
        //}
    }
}