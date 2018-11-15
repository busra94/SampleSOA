using System;
using System.Collections.Generic;
using System.Text;

namespace RandomLib
{
    public interface IRandom
    {
        int random();
        int randomMax(int max);
      //  void randomArray(Byte[] buffer);
    }
}
