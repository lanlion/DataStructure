using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class BitMap
    {
      
        private byte[] bytes;
        private int nbits;
        public BitMap(int nbits)
        {
            this.nbits = nbits;
            var n = nbits / 8 + 1;
            this.bytes = new byte[n];
        }
        public void set(int k)
        {
            if (k > nbits) return;
            int byteIndex = k / 8;
            int bitIndex = k % 8;
            bytes[byteIndex] |=(byte) (1<<bitIndex);//x|=y  等价于 x=x|y
        }
        public bool get(int k)
        {
            if (k > nbits) return false;
            int byteIndex = k / 8;
            int bitIndex = k % 8;
            return (bytes[byteIndex] & (1 << bitIndex)) != 0;
        }
    }
}
