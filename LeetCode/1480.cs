using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution1480
    {
        //1480.Running Sum of 1d Array

        //Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).

        //Return the running sum of nums.

        //Example 1:

        //Input: nums = [1, 2, 3, 4]
        //Output: [1,3,6,10]
        //Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].
        //Example 2:

        //Input: nums = [1, 1, 1, 1, 1]
        //Output: [1,2,3,4,5]
        //Explanation: Running sum is obtained as follows: [1, 1+1, 1+1+1, 1+1+1+1, 1+1+1+1+1].
        //Example 3:

        //Input: nums = [3, 1, 2, 10, 1]
        //Output: [3,4,6,16,17] 

        //Constraints:

        //1 <= nums.length <= 1000
        //- 10 ^ 6 <= nums[i] <= 10 ^ 6

        //ANSWER:
        //int[] nums = { 1, 2, 3, 4 };

        //int[] output = RunningSum(nums);

        public static int[] RunningSum(int[] nums)
        {
            int[] _runningSum = new int[nums.Length];
            _runningSum[0] = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                _runningSum[i] = nums[i] + _runningSum[i - 1];
            }
            return _runningSum;
        }

    }
}
