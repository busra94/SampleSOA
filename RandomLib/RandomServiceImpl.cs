using System;
using System.Collections.Generic;
using System.Text;

namespace RandomLib
{
    public class RandomServiceImpl : IRandom
    {
        public int random()
        {
            Random random = new Random();
            int randInt = random.Next();

            // while (randInt < 0) randInt = random.Next();

            return randInt;
        }
    }
}
