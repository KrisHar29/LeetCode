using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class HeightChecker
    {
        public int HeightCheckerr(int[] heights)
        {
            int[] sortedH = heights.ToArray();
            Array.Sort(sortedH);
            int moved = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] != sortedH[i])
                {
                    moved++;
                }
            }
            return moved;
        }
    }
}
