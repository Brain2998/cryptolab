using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{
    class IsPrime
    {
        public static bool Check(ulong n)
        {
            double sqrt = Math.Sqrt(n);
            for (ulong i = 2; i <= sqrt; ++i)
                if (n % i == 0)
                    return false;
            return true;
        }
    }
}
