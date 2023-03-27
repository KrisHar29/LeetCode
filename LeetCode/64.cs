using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class Solution64
    {
        //64. Minimum Path Sum
        //Medium
        //10.3K
        //135
        //Companies
        //Given a m x n grid filled with non-negative numbers, find a path from top left to bottom right, which minimizes the sum of all numbers along its path.

        //Note: You can only move either down or right at any point in time.

        //Example 1:

        //Input: grid = [[1,3,1],[1,5,1],[4,2,1]]
        //Output: 7
        //Explanation: Because the path 1 → 3 → 1 → 1 → 1 minimizes the sum.
        //Example 2:

        //Input: grid = [[1,2,3],[4,5,6]]
        //Output: 12

        //Constraints:

        //m == grid.length
        //n == grid[i].length
        //1 <= m, n <= 200
        //0 <= grid[i][j] <= 100

        public static int MinPathSum(int[][] grid)
        {

            //====1st attempt====
            //var newGrid = (int[][])grid.Clone();
            //if (newGrid.Length == 1 && newGrid[0].Length == 1)
            //{
            //    return newGrid[newGrid.Length - 1][newGrid[0].Length - 1];
            //}
            //for (int i = 0; i < grid.Length; i++)
            //{
            //    for (int j = 0; j < grid[0].Length; j++)
            //    {
            //        if (i == 0 && j == 0 && j < grid[i].Length - 1)
            //        {
            //            continue;
            //        }
            //        else if (i == 0)
            //        {
            //            newGrid[i][j] = grid[i][j] + grid[i][j - 1];
            //        }
            //        else if (j == 0)
            //        {
            //            newGrid[i][j] = grid[i][j] + grid[i - 1][j];
            //        }
            //        else
            //        {
            //            if (newGrid[i - 1][j] >= newGrid[i][j - 1])
            //            {
            //                newGrid[i][j] = grid[i][j] + newGrid[i][j - 1];
            //            }
            //            else
            //            {
            //                newGrid[i][j] = grid[i][j] + newGrid[i - 1][j];
            //            }
            //        }
            //    }
            //}
            //return newGrid[newGrid.Length - 1][newGrid[0].Length - 1];


            //=====2nd refactored attempt=====
            if (grid.Length == 1 && grid[0].Length == 1)
            {
                return grid[grid.Length - 1][grid[0].Length - 1];
            }
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (i == 0 && j == 0 && j < grid[i].Length - 1)
                    {
                        continue;
                    }
                    else if (i == 0)
                    {
                        grid[i][j] += grid[i][j - 1];
                    }
                    else if (j == 0)
                    {
                        grid[i][j] += grid[i - 1][j];
                    }
                    else
                    {
                        if (grid[i - 1][j] >= grid[i][j - 1])
                        {
                            grid[i][j] += grid[i][j - 1];
                        }
                        else
                        {
                            grid[i][j] += grid[i - 1][j];
                        }
                    }
                }
            }
            return grid[grid.Length - 1][grid[0].Length - 1];
        }
    }
}
