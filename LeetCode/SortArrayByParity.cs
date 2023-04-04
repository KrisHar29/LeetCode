using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class SortArrayByParity
    {
        public int[] SortArrayByParityy(int[] nums)
        {
            for (int lastEven = 0, currentLoc = 0; currentLoc < nums.Length; currentLoc++)
            {
                if ((nums[currentLoc] % 2) == 0)
                {
                    int temp = nums[lastEven];
                    nums[lastEven++] = nums[currentLoc];
                    nums[currentLoc] = temp;
                }
            }
            return nums;
        }
    }
}
