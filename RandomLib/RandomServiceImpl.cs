using System;
using System.Collections.Generic;
using System.Text;

namespace RandomLib
{
    public class RandomServiceImpl : IRandom
    {
        // public int randInt; // public private ? 
        public Random randomNum;
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
        //public void randomArray(Byte[] buffer)
        //{            
        //    randomNum = new Random();

        //    randomNum.NextBytes(buffer);
            
        //}
    }
}
