using SampleSOAGithub.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleSOAGithub.ServicesImpl
{
    public class RandomServicesImpl : IRandom
    {        public int random()
        {
            Random random = new Random();
            int randInt = random.Next();

            // while (randInt < 0) randInt = random.Next();

            return randInt;
        }
    }
}
