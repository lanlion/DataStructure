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
            Console.WriteLine($"arr{string.Join(",", arr)}");
            Qsort(arr, 0, arr.Length - 1);
        }

        private static void Qsort(int[] arr, int low, int high)
        {
            if (low >= high) return;
            var q = partition(arr, low, high);
            Console.WriteLine($"low:{low}");
            Console.WriteLine($"high:{high}");
            Console.WriteLine($"partition:{q}");
            Console.WriteLine($"arr{string.Join(",",arr)}");
            Qsort(arr, low, q - 1);
            Qsort(arr, q + 1, high);
        }
        //9, 2,6,5,8,7,4,3,11,10
        //3, 2,6,5,8,7,4,9,11,10
        private static int partition(int[] arr, int low, int high)
        {
            // arr[0] = arr[low];
            var pivotkey = arr[low];
            while (low < high)
            {
                while (low < high && arr[high] >= pivotkey) --high;
                swap(arr, low, high);
                while (low < high && arr[low] <= pivotkey) ++low;
                swap(arr, low, high);
            }
            //arr[low] = arr[0];
            return low;
        }
        private static void swap(int[] arr, int a, int b)
        {
            if (a == b) return;
            int temp;
            temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }

    }
}
