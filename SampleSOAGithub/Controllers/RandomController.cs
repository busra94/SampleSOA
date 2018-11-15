using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RandomLib;
using SampleSOAGithub.Models;


namespace SampleSOAGithub.Controllers
{
    public class RandomController : Controller 
    {        
        IRandom random = new RandomServiceImpl();
        RandomInteger randomInteger; 

        private IRandom randomService;

        public IActionResult Index()
        {
            randomInteger = new RandomInteger();

            randomService = new RandomServiceImpl ();
            int randomInt= randomInteger.RandomInt = randomService.random();

            return View(randomInteger);
        }

        public IActionResult RandomMax(int maxRandom)
        {
            randomInteger = new RandomInteger();

            randomService = new RandomServiceImpl();

            randomInteger.RandomMax = randomService.randomMax(maxRandom);


            return View("Index", randomInteger);

        }
        //public IActionResult RandomArray()
        //{
        //    randomInteger = new RandomInteger();

        //    randomService = new RandomServiceImpl();

        //    randomInteger.Buffer = new Byte[10];
        //    randomService.randomArray(randomInteger.Buffer);
                        
        //    return View("Index", randomInteger);       

        //}

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