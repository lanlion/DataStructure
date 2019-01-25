using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 8,10,99,999};// 01,04
            BitMap b = new BitMap(10000);
            byte[] bytes = new byte[10000];
            BitArray myBA1 = new BitArray(bytes);
            myBA1.Set(1, true);
            var aaa = myBA1.Get(1);
            foreach (var item in list)
            {
             
                b.set(item);
                var a = b.get(item);
                Console.WriteLine($"{item}:{a}");
            }
         
        }
    }
}
