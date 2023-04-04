using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class MergeSortedArray
    {
        //public static int[] MergeSortedArrays(int[] array, int[] array2)
        //{
        //    int[] result = new int[array.Length + array2.Length];
        //    foreach (int[] item in array)
        //    {
        //        result += array[item];
        //    }
        //    {
        //        result += array[i];
        //    }
        //}


        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int countM = 0;
            int countN = 0;
            int[] copyOfNums1 = new int[m];
            for (int o = 0; o < m; o++)
            {
                copyOfNums1[o] = nums1[o];
            }
            for (int i = 0; i < m+n; i++)
            {
                if (n > countN && m > countM)
                {
                    if (copyOfNums1[countM] > nums2[countN])
                    {
                        nums1[i] = nums2[countN];
                        countN++;
                    }
                    else
                    {
                        nums1[i] = copyOfNums1[countM];
                        countM++;
                    }
                }
                else if (n > countN)
                {
                    nums1[i] = nums2[countN];
                    countN++;
                }
                else
                {
                    nums1[i] = copyOfNums1[countM];
                    countM++;
                }
               
            }
        }
    }

    
}
