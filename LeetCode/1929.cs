using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode
{
    public static class Solution1929
    {
        //1929. Concatenation of Array
        //Easy
        //2.2K
        //284
        //Companies
        //Given an integer array nums of length n, you want to create an array ans of length 2n where ans[i] == nums[i] and ans[i + n] == nums[i] for 0 <= i<n (0-indexed).

        //Specifically, ans is the concatenation of two nums arrays.

        //Return the array ans.

        //Example 1:

        //Input: nums = [1, 2, 1]
        //Output: [1,2,1,1,2,1]
        //Explanation: The array ans is formed as follows:
        //- ans = [nums[0], nums[1], nums[2], nums[0], nums[1], nums[2]]
        //- ans = [1, 2, 1, 1, 2, 1]
        //Example 2:

        //Input: nums = [1, 3, 2, 1]
        //Output: [1,3,2,1,1,3,2,1]
        //Explanation: The array ans is formed as follows:
        //- ans = [nums[0], nums[1], nums[2], nums[3], nums[0], nums[1], nums[2], nums[3]]
        //- ans = [1, 3, 2, 1, 1, 3, 2, 1]

        //Constraints:

        //n == nums.length
        //1 <= n <= 1000
        //1 <= nums[i] <= 1000
        // 0 1 2 3 4 5 
        // 2,3,4 ,2,3,4
        public static int[] GetConcatenation(int[] nums)
        {
            int[] list = new int[nums.Length*2];
            for (int i = 0; i < nums.Length; i++)
            {
                list[i] = nums[i];
                list[i + nums.Length] = nums[i];
            }
            return list;
        }
    }
}
