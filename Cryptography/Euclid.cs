using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{
    class Euclid
    {
        public static ulong FindGSD(ulong a, ulong b)
        {
            ulong max, min;
            if (a > b)
            {
                max = a;
                min = b;
            }
            else
            {
                min = a;
                max = b;
            }
            ulong mod = max % min;
            max = min;
            min = mod;
            while (0 != mod)
            {
                mod = max % min;
                max = min;
                min = mod;
            }
            return max;
        }
    }
}
