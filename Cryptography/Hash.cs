using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{
    class Hash
    {
        public static ulong GetHash(ulong[] Text, ulong Key, ulong Module)
        {
            int TextLength = Text.Length;
            ulong Hash = 0;           
            for (int i = 0; i < TextLength; ++i)
            {
                Hash = (Hash ^ ExpByModule.Exponentiation(Text[i],Key,Module))%Module;
            }
            return Hash;
        }
    }
}
