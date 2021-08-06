using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryString
{
    class BinaryStringChecker
    {
        public bool IsGood(string binaryString)
        {
            int oneCount = 0;
            int zeroCount = 0;
            for (var i = 0; i < binaryString.Length; i++)
            {
                if (binaryString[i] == '1')
                {
                    oneCount++;
                }
                else
                {
                    zeroCount++;
                }

                if (oneCount < zeroCount)
                {
                    return false;
                }
            }

            return oneCount == zeroCount;
        }
    }
}
