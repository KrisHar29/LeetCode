using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode
{
    internal class Solution217
    {
        //217. Contains Duplicate
        //Easy
        //8.7K
        //1.1K
        //Companies
        //Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

        //Example 1:

        //Input: nums = [1,2,3,1]
        //        Output: true
        //Example 2:

        //Input: nums = [1,2,3,4]
        //        Output: false
        //Example 3:

        //Input: nums = [1,1,1,3,3,4,3,2,4,2]
        //Output: true

        //Constraints:

        //1 <= nums.length <= 105
        //-109 <= nums[i] <= 109

        public bool ContainsDuplicate(int[] nums)
        {
            //===although this works the edge case of 100000 nums times out on the time complexity===
            //Dictionary<int, int> dict = new Dictionary<int, int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if(dict.Values.Contains(nums[i]))
            //    {
            //        return true;
            //    }
            //    dict.Add(i, nums[i]);
            //}
            //return false;

            //==hashset passess time complexity
            HashSet<int> seen = new HashSet<int>();
            foreach (int i in nums)
            {
                if (!seen.Add(i))
                {
                    return true;
                }
            }
            return false;

            //linq?

        }
    }
}
