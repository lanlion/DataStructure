using System;
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
            List<int> list = new List<int> { 0,1,8,10,11,88,99,100,111,999};
            foreach (var item in list)
            {
                BitMap b = new BitMap(item);
                b.set(item);
                var a = b.get(item);
                var c = b.get(9);
            }
         
        }
    }
}
