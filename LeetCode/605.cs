using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace LeetCode
{
    public static class Solution605
    {
        //        605. Can Place Flowers
        //        Easy
        //4.2K
        //780
        //Companies
        //You have a long flowerbed in which some of the plots are planted, and some are not.However, flowers cannot be planted in adjacent plots.

        //Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, and an integer n, return if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule.



        //Example 1:

        //Input: flowerbed = [1, 0, 0, 0, 1], n = 1
        //Output: true
        //Example 2:

        //Input: flowerbed = [1, 0, 0, 0, 1], n = 2
        //Output: false



        //Constraints:

        //1 <= flowerbed.length <= 2 * 104
        //flowerbed[i] is 0 or 1.
        //There are no two adjacent flowers in flowerbed.
        //0 <= n <= flowerbed.length

        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int length = flowerbed.Length - 1;
            if (n == 0) { return true; }
            if (n == 1 && flowerbed.Length == 1)
            {
                if (flowerbed[0] == 0)
                {
                    return true;
                }
            }
            if (length > 0)
            {
                if (flowerbed[0] == 0 && flowerbed[1] == 0)
                {
                    flowerbed[0] = 1;
                    --n;
                }
                for (int i = 1; i < length; i++)
                {
                    if (flowerbed[i - 1] == 0 && flowerbed[i] == 0 && flowerbed[i + 1] == 0)
                    {
                        flowerbed[i] = 1;
                        --n;
                    }
                }
                if (flowerbed[length - 1] == 0 && flowerbed[length] == 0)
                {
                    flowerbed[length] = 1;
                    --n;
                }
                return n <= 0;
            }
            return false;
        }
    }
}
