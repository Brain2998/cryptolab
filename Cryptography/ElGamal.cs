using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{
    class ElGamal
    {
        ulong p, x, g, y;
        public ulong k, a;
        public ElGamal(ulong P, ulong G, ulong X)
        {
            p = P;
            g = G;
            x = X;
        }
        public ElGamal(ulong G, ulong P, ulong Y, bool d)
        {
            g = G;
            p = P;
            y = Y;
        }
        public ulong GetOpenKey()
        {
            y = ExpByModule.Exponentiation(g,x,p);
            return y;
        }
        public ulong GetK()
        {
            ulong[] RandomStorage;
            List<ulong> Random = new List<ulong>();
            string StringRandomRange = "1";
            ulong decP = p - 1;
            int EilerLength = decP.ToString().Length;
            for (int i = 0; i < EilerLength / 2; ++i)
            {
                StringRandomRange += "0";
            }
            ulong RandomRange = decP - Convert.ToUInt64(StringRandomRange);            
            for (ulong i = RandomRange; i < decP; ++i)
            {
                if (1 == Euclid.FindGSD(i, decP))
                {
                    Random.Add(i);
                }
            }
            RandomStorage=Random.ToArray();
            Random rand = new Random();
            k = RandomStorage[rand.Next(0, RandomStorage.Length)];
            return k;
        }
        public ulong GetFirstCypherPart()
        {
            a = ExpByModule.Exponentiation(g,k,p);
            return a;
        }
        public ulong[] Encription(ulong[] CodedLine)
        {
            int CodedLineLength = CodedLine.Length;
            ulong[] CypherText = new ulong[CodedLineLength];
            ulong Y = ExpByModule.Exponentiation(y, k, p);
            for (int i = 0; i < CodedLineLength; ++i)
            {
                CypherText[i] = (CodedLine[i] * Y) % p;
            }
            return CypherText;
        }
        public ulong[] Decryption(ulong[] CypherText)
        {
            int CypherTextLength = CypherText.Length;
            ulong[] OpenText = new ulong[CypherTextLength];
            ulong reverse_a = ExpByModule.Exponentiation(a, p - 1 - x, p);
            for (int i = 0; i < CypherTextLength; ++i)
            {
                OpenText[i] = (CypherText[i] * reverse_a) % p;
            }
            return OpenText;
        }       
     }
}
