using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Sort
    {
        public static void Quick_Sort(int[] arr)
        {
            sort(arr,0,arr.Length-1);
        }

        private static void sort(int[] arr, int begin, int end)
        {
            if (begin >= end) return;
            var q = partition(arr,begin,end);
            sort(arr, begin, q - 1);
            sort(arr,q+1,end);
        }
        //2,6,5,8,7,4,3,11,10
        private static int partition(int[] arr, int begin, int end)
        {
            var key = arr[end];
            var i = begin;
            int temp;
            for (int j = begin; j < end; j++)
            {
                if (arr[j]<key)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                }
            }
           // temp = arr[i];
            arr[i] = key;
           // key = temp;
            return i;
        }
            // 快速排序，A 是数组，n 表示数组的大小
            //quick_sort(A, n)
            //        {
            //            quick_sort_c(A, 0, n - 1)
            //}
            //// 快速排序递归函数，p,r 为下标
            //quick_sort_c(A, p, r)
            //        {
            //            if p >= r then return

            //            q = partition(A, p, r) // 获取分区点
            //  quick_sort_c(A, p, q - 1)
            //  quick_sort_c(A, q + 1, r)
            //}

            //        partition(A, p, r)
            //        {
            //            pivot:= A[r]
            //  i:= p
            //  for j := p to r - 1 do
            //                {
            //                    if A[j] < pivot {
            //                        swap A[i] with A[j]
            //                      i:= i + 1
            //                    }
            //                }

            //    swap A[i] with A[r]
            //  return i


        }
}
