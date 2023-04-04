using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class Solution414
    {
        public static int ThirdMax(int[] nums)
        {
            //int count = 0;
            //int maximum = 0;
            //if(nums.Length == 1)
            //{
            //    return nums[0];
            //}
            //Array.Sort(nums, (x,y) => -x.CompareTo(y));
            //if (nums[0] != nums[1])
            //{
            //    maximum= nums[0];
            //    count++;
            //}
            //int last = nums[0];
            //for (int i = 1; i < nums.Length; i++)
            //{
            //    if (i == nums.Length-1)
            //    {
            //        if (nums[i] != last)
            //        {
            //            count++;
            //            if(maximum == 0)
            //            {
            //                maximum = nums[i];
            //            }
            //            if (count == 3)
            //            {
            //                maximum = nums[i];
            //            }
            //        }
            //    }
            //    else
            //    {
            //        if (nums[i] != last && nums[i] != nums[i+1])
            //        {
            //            count++;
            //            if (count == 3)
            //            {
            //                maximum = nums[i];
            //            }
            //            if (maximum == 0)
            //            {
            //                maximum = nums[i];
            //            }
            //        }
            //    }
            //    last= nums[i];

            //}
            //return maximum;

            nums = nums.Distinct().OrderByDescending(n => n).ToArray();
            if (nums.Length >= 3)
                return nums[2];
            return nums[0];
        }
    }
}
