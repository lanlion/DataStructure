using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Compute
    {
        private static readonly Stack<double> numStack = new Stack<double>();
        private static readonly Stack<char> operatorStack = new Stack<char>();
        private static readonly char[] operators = { '*', '/', '+', '-' };
        private static readonly Dictionary<char, int> levelInfo = new Dictionary<char, int>(operators.Length);

        public Compute()
        {
            numStack.Clear();
            operatorStack.Clear();
            levelInfo.Add('+', 1);
            levelInfo.Add('-', 1);
            levelInfo.Add('*', 2);
            levelInfo.Add('/', 2);
        }
        private double compute(double n1, double n2,char opera)
        {
            double d = 0;
            switch (opera)
            {
                case '*':
                    d = n1 * n2;
                    break;
                case '/':
                    d = n1 /n2;
                    break;
                case '+':
                    d = n1 + n2;
                    break;
                case '-':
                    d = n1 - n2;
                    break;
                default:
                    break;
            }
            return d;
        }
        public double GetResult(string str)
        {

            numStack.Clear();
            operatorStack.Clear();
            //34+13*9+88-12/3-33*6-55+99+66*5+78                  34+13*9+88-12/3-33*6-55+99
            var attar = str.ToCharArray();
            var tmp = str.Split(operators);
            var count = 0;
            foreach (var item in tmp)
            {
                numStack.Push(double.Parse(item));
                var num = item.Length;
                count += num;
                bool isEnd = count >= attar.Length;
                var opera = isEnd ? operatorStack.Peek() : attar[count];
                count++;

                if (operatorStack.Count > 0)
                {
                    var peek = operatorStack.Peek();
                    if (levelInfo[peek] >= levelInfo[opera])
                    {
                        var n2 = numStack.Pop();
                        var n1 = numStack.Pop();
                        var n3 = compute(n1, n2, operatorStack.Pop());
                        numStack.Push(n3);
                        if (operatorStack.Count > 0)
                        {
                            var peek1 = operatorStack.Peek();
                            var tempn2 = numStack.Pop();
                            var tempn1 = numStack.Pop();
                            var tempn3 = compute(tempn1, tempn2, operatorStack.Pop());
                            numStack.Push(tempn3);
                        }
                        if (!isEnd)
                        {
                            operatorStack.Push(opera);
                        }

                    }
                    else
                    {
                        operatorStack.Push(opera);
                    }


                }
                else
                {
                    operatorStack.Push(opera);
                }

            }
            // 34+13*9+88-12/3-33*6-55+99+66*5+78            34+205-4-198+44+408   489
           
            return numStack.Pop();
        }
    }
}
