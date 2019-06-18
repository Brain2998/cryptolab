using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{
    class Coding
    {        
        public static ulong[] Encoding(string OpenText)
        {
            int OpenTextLength = OpenText.Length;
            ulong[] CodedLine = new ulong[OpenTextLength];
            for (int i = 0; i < OpenTextLength; ++i)
            {
                CodedLine[i] = OpenText[i];
            }
            return CodedLine;
        }
        public static string Decoding(ulong[] OpenText)
        {
            int OpenTextLength = OpenText.Length;
            string DecodedLine = "";
            for (int i = 0; i < OpenTextLength; ++i)
            {
                DecodedLine += Convert.ToChar(OpenText[i]);
            }
            return DecodedLine;
        }
    }
}
