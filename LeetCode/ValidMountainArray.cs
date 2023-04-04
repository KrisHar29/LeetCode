using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class ValidMountainArray
    {
        public static bool ValidMounArray(int[] arr)
        {
            int last = 1;
            int countUp = 0;
            if (arr.Length < 3)
            {
                return false;
            }
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] < arr[i] && last > 0)
                {
                    countUp++;
                }
                else if (arr[i - 1] > arr[i] && countUp > 0)
                {
                    last--;
                }
                else if (arr[i - 1] < arr[i] && last < 0)
                {
                    return false;
                }
                else { return false; }
            }
            if (countUp > 0 && last < 1)
            {
                return true;
            }
            return false;
        }
    }
}
