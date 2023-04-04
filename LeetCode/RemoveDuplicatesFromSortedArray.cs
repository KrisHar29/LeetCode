using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class RemoveDuplicatesFromSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int k = 1;
            int passed = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != passed)
                {
                    nums[k] = nums[i];
                    k++;
                }
                passed = nums[i];
            }
            return k;
        }
    }
}
