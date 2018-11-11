using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RandomLib;


namespace SampleSOAGithub.Controllers
{
    public class RandomController : Controller 
    {        
        IRandom random = new RandomServiceImpl();
        private IRandom randomService;
        public IActionResult Index()
        {
            randomService = new RandomServiceImpl ();
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