using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{
    class EratosthenesSieve
    {
        ulong upperbound;
        public ulong UpperBound
        {
            get { return upperbound; }
            set { upperbound = value; }
        }
        public EratosthenesSieve(ulong n)
        {
            upperbound = n;
        }
        public uint[] Sieve()
        {
            ulong[] v = new ulong[(upperbound - 1) / 2];
            if (2 > upperbound)
                return null;
            else
            {
                return null;
            }
        }
    }
}
