
// 빠른 소트 평션 만들기    
// Path: quicksort.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks 

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 3, 8, 4, 9, 1, 6, 2, 7 };
            QuickSort(arr, 0, arr.Length - 1);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static void QuickSort(int[] arr, int left, int right)
        {
            int pivot, l_hold, r_hold;
            l_hold = left;
            r_hold = right;
            pivot = arr[left];
            while (left < right)
            {
                while ((arr[right] >= pivot) && (left < right))
                    right--;
                if (left != right)
                {
                    arr[left] = arr[right];
                    left++;
                }
                while ((arr[left] <= pivot) && (left < right))
                    left++;
                if (left != right)
                {
                    arr[right] = arr[left];
                    right--;
                }
            }
            arr[left] = pivot;
            pivot = left;
            left = l_hold;
            right = r_hold;
            if (left < pivot)
                QuickSort(arr, left, pivot - 1);
            if (right > pivot)
                QuickSort(arr, pivot + 1, right);
        }
    }
}


