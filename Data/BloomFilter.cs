using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    /// <summary>
    /// 布隆过滤器（Bloom Filter），Burton Howard Bloom在1970年提出的，它结合了位图和Hash表两者的优点，位图的优点是节省空间，但是只能处理整型值一类的问题，无法处理字符串一类的问题，而Hash表却恰巧解决了位图无法解决的问题，然而Hash太浪费空间。针对这个问题，布隆提出了一种基于二进制向量和一系列随机函数的数据结构-布隆过滤器。它的空间利用率和时间效率是很多算法无法企及的，但是它也有一些缺点，就是会有一定的误判率并且不支持删除操作。
    /// </summary>
    /// public BitArray _BloomArray;
   
    public class BloomFilter
    {
        public BitArray _BloomArray;
        public Int64 BloomArryLength { get; }
        public Int64 DataArrayLeng { get; }
        public Int64 BitIndexCount { get; }
        public BloomFilter( int DataArrayLeng, int bitIndexCount)
        {
            var bloomLength = DataArrayLeng * 10;
            _BloomArray = new BitArray(bloomLength);
            this.BloomArryLength = bloomLength;
            this.DataArrayLeng = DataArrayLeng;
            this.BitIndexCount = bitIndexCount;
        }
        public void Add()
        {

        }

        public int GetHashCode(object value)
        {
            return value.GetHashCode();
        }
    }
}
