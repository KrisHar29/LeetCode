using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class CheckIfNAndItsDoubleExist
    {
        public static bool CheckIfExist(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j)
                    {
                        if(arr[j]*2 == arr[i])
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
