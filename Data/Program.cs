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
