using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode
{
    public static class Solution283
    {
        //283. Move Zeroes
        //Easy
        //13.1K
        //330
        //Companies
        //Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

        //Note that you must do this in-place without making a copy of the array.

        //Example 1:

        //Input: nums = [0, 1, 0, 3, 12]
        //Output: [1,3,12,0,0]
        //Example 2:

        //Input: nums = [0]
        //Output: [0]

        //Constraints:

        //1 <= nums.length <= 104
        //-231 <= nums[i] <= 231 - 1

        //Follow up: Could you minimize the total number of operations done?


        public static void MoveZeroes(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0 && nums.Length > 1) 
                {
                    for (int j = i; j < nums.Length; j++)
                    {
                        
                        if (nums.Length - 1 == j)
                        {
                            nums[j] = 0;
                        }
                        else
                        {
                            nums[j] = nums[j + 1]; 
                        }
                    }
                }
                
            }
        }

        
    }
}
