using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class Solution119
    {
        //119. Pascal's Triangle II
        //Easy
        //3.6K
        //294
        //Companies
        //Given an integer rowIndex, return the rowIndexth(0-indexed)
        //row of the Pascal's triangle.

        //In Pascal's triangle, each number is the sum of the two
        //numbers directly above it as shown:

        //Example 1:

        //Input: rowIndex = 3
        //Output: [1,3,3,1]
        //Example 2:

        //Input: rowIndex = 0
        //Output: [1]
        //Example 3:

        //Input: rowIndex = 1
        //Output: [1,1]

        //Constraints:

        //0 <= rowIndex <= 33

        //Follow up: Could you optimize your algorithm to use only
        //O(rowIndex) extra space?

        public static IList<int> GetRow(int rowIndex)
        {
            //IList<IList<int>> output = new List<IList<int>>();
            //output.Add(new List<int> { 1 });
            //if (rowIndex == 0) return output[0];
            //output.Add(new List<int> { 1, 1 });
            //if (rowIndex == 1) return output[1];
            //for (int i = 2; i < rowIndex; i++)
            //{
            //    var previousRow = output.Last();
            //    var createRow = new List<int>();
            //    createRow.Add(1);

            //    for (int j = 1; j < i; j++)
            //    {
            //        createRow.Add(previousRow[j - 1] + previousRow[j]);
            //    }
            //    createRow.Add(1);
            //    output.Add(createRow);
            //}
            //return output[rowIndex];

            IList<int> currentRow = new List<int>();
            IList<int> previousRow = new List<int>();
            for (int i = 0; i <= rowIndex; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        currentRow.Add(1);
                    }
                    else
                    {
                        currentRow.Add(previousRow[j - 1] + previousRow[j]);
                    }
                }
                if (i == rowIndex)
                {
                    return currentRow;
                }
                previousRow = currentRow;
                currentRow = new List<int>();
            }
        }
    }
}
