using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{
    class RSA
    {
        ulong p;
        ulong q;
        ulong Open;
        ulong Secret;
        public struct Keys
        {
            public ulong openKey;
            public ulong secretKey;
        }
        public RSA(ulong a, ulong b)
        {
            p = a;
            q = b;
        }
        public RSA(ulong a, string s)
        {
            if ("Открытый" == s)
                Open = a;
            if ("Закрытый" == s)
                Secret = a;
        }
        public RSA()
        {
            p = 0;
            q = 0;
        }
        public Keys GetKeys()
        {
            ulong n = p * q;
            ulong Eiler = (p - 1) * (q - 1);
            ulong OpenKey;
            ulong[] RandomStorage;
            List<ulong> Random = new List<ulong>();
            string StringRandomRange = "1";
            int EilerLength = Eiler.ToString().Length;
            for (int i = 0; i < EilerLength / 2; ++i)
            {
                StringRandomRange += "0";
            }
            ulong RandomRange = Eiler-Convert.ToUInt64(StringRandomRange);
            for (ulong i = RandomRange; i <= Eiler; ++i)
            {
                if (1 == Euclid.FindGSD(i, Eiler))
                {
                    Random.Add(i);
                }
            }
            RandomStorage = Random.ToArray();
            Random rand = new Random();
            OpenKey = RandomStorage[rand.Next(0, RandomStorage.Length)];
            ulong SecretKey = ExtendedEuclid.FindReverse(OpenKey, Eiler);
            Keys keys = new Keys();
            keys.openKey = OpenKey;
            keys.secretKey = SecretKey;
            return keys;
        }
        public ulong[] Encription(ulong[] CodedLine, ulong module)
        {
            int CodedLineLength = CodedLine.Length;
            ulong[] CypherText = new ulong[CodedLineLength];            
            for (int i = 0; i < CodedLineLength; ++i)
            {                
                CypherText[i] = ExpByModule.Exponentiation(CodedLine[i],Open,module);
            }
            return CypherText;
        }
        public ulong[] Decription(ulong[] CypherText, ulong module)
        {
            int CypherTextLength = CypherText.Length;
            ulong[] OpenText = new ulong[CypherTextLength];
            for (int i = 0; i < CypherTextLength; ++i)
            {
                OpenText[i] = ExpByModule.Exponentiation(CypherText[i],Secret,module);
            }
            return OpenText;
        }       
    }
}
