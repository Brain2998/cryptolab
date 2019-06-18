using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{
    class ExpByModule
    {           
        public static ulong Exponentiation(ulong based, ulong exp, ulong module)
        {
            ulong result = 1, z = based % module;
            while (0!=exp)
            {
                if (0!=(exp & 1))
                    result = (result * z) % module;
                z = (z * z) % module;
                exp >>= 1;
            }
            return result;
        }
    }            
}
