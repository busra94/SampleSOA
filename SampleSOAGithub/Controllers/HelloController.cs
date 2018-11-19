using System;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;

namespace SampleSOAGithub.Controllers
{
    public class HelloController : Controller
    {
        private const string BASE_URL = "http://localhost:52692";
        public IActionResult Index()
        {
            using(var client = new HttpClient())
            {               
                // passing service base url
                client.BaseAddress = new Uri(BASE_URL);

                client.DefaultRequestHeaders.Clear();

                // define request data format 
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // sending request to find web api REST service resource Get using HttpClient
                HttpResponseMessage response = client.GetAsync("api/Hello").GetAwaiter().GetResult(); // with getAwaiter we make async method sync!!!!

                // checking the response is successful or not which is sent using HttpClient
                if (response.IsSuccessStatusCode)
                {
                    // storing the response details received from web api
                    var apiResponse = response.Content.ReadAsStringAsync().Result;

              
                    // deserializing the response received from web api 
                    // message = JsonConvert.DeserializeObject(apiResponse);
                    return View("Index", apiResponse);
                }
        
                return View("Index", "request failed");
                               
            }            
        }
    }
}