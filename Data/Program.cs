using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class Program
    {
        static void Main(string[] args)
        {

            Compute cc = new Compute();
         var compute=   cc.GetResult("34+13-9+88-12-33-55+99+66+78");
            //34 +117+ 88- 4-198-55+99 +330+78

            ArrayStack arraystack = new ArrayStack(10);

            for (int i = 0; i < 10; i++)
            {
                arraystack.push(i.ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(arraystack.pop());
            }
            string source = "哈夫曼曼曼曼曼";

            Huffman hf = new Huffman();
            Dictionary<char, string> key = null;
            var hfCode = hf.StringToHuffmanCode(out key, source);

            Console.WriteLine("--------------------编码与解析");
            Console.WriteLine("编码: " + hfCode);

            var text = hf.ToText(hfCode, key);
            Console.WriteLine("解析: " + text);

            Console.ReadLine();

            Random r = new Random(4);
            Random rr = new Random(4);
            var a = r.Next();
            var aa = rr.Next();

            BloomFilter bloom = new BloomFilter(50000, 7);
            for (int i = 0; i < bloom.DataArrayLeng; i++)
            {
                bloom.Add(i.ToString());
            }
            while (true)
            {
                var c = Console.ReadLine();
                if (c == "e")
                {
                    break;

                }
                Stopwatch sw = new Stopwatch();
                sw.Start();
                var temp = bloom.isExist(c);
                sw.Stop();
                Console.WriteLine($"查找:{c}\n结果:{temp}\n总耗时:{sw.ElapsedTicks}\n错误概率:{bloom.getFalsePositiveProbability()}");
            }
        }
    }
}
