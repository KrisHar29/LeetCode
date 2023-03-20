using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode
{
    public static class MaxConsecutiveOnes
    {
        //MaxConsecutiveOnes
        //Given a binary array nums, return the maximum number of consecutive 1's in the array.

 

        //Example 1:

        //Input: nums = [1,1,0,1,1,1]
        //        Output: 3
        //Explanation: The first two digits or the last three digits are consecutive 1s.The maximum number of consecutive 1s is 3.
        //Example 2:

        //Input: nums = [1,0,1,1,0,1]
        //        Output: 2
 

        //Constraints:

        //1 <= nums.length <= 105
        //nums[i] is either 0 or 1.


        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int max = 0;
            int count =0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    count++;
                }
                else
                {
                    if (max < count)
                    {
                        max = count;
                    }
                    count = 0;
                }
            }
            if (max < count)
            {
                max = count;
            }
            return max;
        }
    }
}
