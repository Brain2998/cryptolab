using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{
    class ExtendedEuclid
    {
        public static ulong FindReverse(ulong element, ulong module)
        {
            if (0 == element || 0 == module || 1 == module)
                return 0;
            else
            {
                long[] u = new long[] { 0, 1, (long)module };
                long[] v = new long[] { 1, 0, (long)element };
                long q;
                long t;
                while ((1 != u[2] || 0 != u[2]) && 0 != v[2])
                {
                    q = u[2] / v[2];
                    for (int i = 0; i < 3; i++)
                    {
                        t = u[i] - v[i] * q;
                        u[i] = v[i];
                        v[i] = t;
                    }
                }
                if (1 != u[2])
                    return 0;
                else
                {
                    if (1 == u[2])
                    {
                        if (0 > u[0])
                        {
                            u[0] = (long)module + u[0];
                            return (ulong)u[0];
                        }
                        else
                            return (ulong)u[0];
                    }
                }
            }
            return 0;
        }        
    }
}
