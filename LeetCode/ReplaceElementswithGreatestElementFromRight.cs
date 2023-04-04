using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class ReplaceElementswithGreatestElementFromRight
    {
        public static int[] ReplaceElements(int[] arr)
        {
            int greatest = 0;
            if(arr.Length ==1)
            {
                arr[0] = -1;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length -1)
                {
                    arr[i] = -1;
                }
                else
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[j] > greatest)
                        {
                            greatest = arr[j];
                        }
                    }
                    arr[i] = greatest;
                    greatest = 0;
                }
            }
            return arr;
        }
    }
}
