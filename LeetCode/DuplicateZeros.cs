using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class DuplicateZeros
    {
        public static void DuplicateZeroos(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - count; i++)
            {
                if (arr[i] == 0)
                {
                    count++;
                }
            }


            for (int z = arr.Length-1 - count; z >= 0; z--)
            {
                if (count== 0) { break; }
                if (arr[z] == 0)
                {
                    count--;
                    for (int k = arr.Length-1; k > z; k--)
                    {
                        arr[k] = arr[k-1];
                    }
                }
            }
        }
    }
}
