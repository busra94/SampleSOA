using System;
using Microsoft.AspNetCore.Mvc;


namespace WebAPI.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class RandomController : ControllerBase
    {
        public Random randomNumber;

        [Route("api/Random/")]
        public int getRandom()
        {
            randomNumber = new Random();
            return randomNumber.Next();
        }

        //[Route("api/Random/{max}")]
        //public int getRandom(int max)
        //{
        //    int maximum = max;
        //    randomNumber = new Random();

        //    return randomNumber.Next(maximum);  // when using parameter here i get an error.
        //}
    }
}


/*
 *     public Random randomNum;
        public int random()
        {
            randomNum = new Random();           

            // while (randInt < 0) randInt = random.Next();

            return randomNum.Next(); ;
        }

        public int randomMax(int max)
        {
            randomNum = new Random();
            return randomNum.Next(max); 
        }
 */
