using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleSOAGithub.Services;
using SampleSOAGithub.Models;
using SampleSOAGithub.ServicesImpl;

namespace SampleSOAGithub.Controllers.Random
{
    public class RandomController : Controller 
    {
        private IRandom randomService;
        public IActionResult Index()
        {
            randomService = new RandomServicesImpl();
            int number = randomService.random();          
            return View(number);
        }
        public IRandom getRandomService()
        {
            return randomService;
        }

        public void setRandomService(IRandom randomService)
        {
            this.randomService = randomService;
   
        }  
    }
}