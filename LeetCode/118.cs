using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class Solution118
    {
        //118. Pascal's Triangle
        //Easy
        //9.5K
        //309
        //Companies
        //Given an integer numRows, return the first numRows of Pascal's triangle.

        //In Pascal's triangle, each number is the sum of the two numbers directly above it as shown:

        //Example 1:

        //Input: numRows = 5
        //Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]
        //Example 2:

        //Input: numRows = 1
        //Output: [[1]]

        //Constraints:

        //1 <= numRows <= 30

        public static IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> output = new List<IList<int>>();
            if (numRows > 0)
            {
                output.Add(new List<int> { 1 });
                if (numRows >1)
                { output.Add(new List<int> { 1, 1}); }
            }
            for (int i = 2; i < numRows; i++)
            {
                var previousRow = output.Last();
                var createRow = new List<int>();
                createRow.Add(1);
                
                for (int j = 1; j < i; j++)
                {
                    createRow.Add(previousRow[j - 1]+ previousRow[j]);
                }
                createRow.Add(1);
                output.Add(createRow);
            }
            return output;
        }
    }
}
