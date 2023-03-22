using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace LeetCode
{
    public class Solution2492
    {
        //2492. Minimum Score of a Path Between Two Cities
        //Medium
        //788
        //150
        //Companies
        //        You are given a positive integer n representing n cities numbered from 1 to n.You are also given a 2D array roads where roads[i] = [ai, bi, distancei] indicates that there is a bidirectional road between cities ai and bi with a distance equal to distancei. The cities graph is not necessarily connected.
        //        The score of a path between two cities is defined as the minimum distance of a road in this path.

        //Return the minimum possible score of a path between cities 1 and n.

        //Note:

        //A path is a sequence of roads between two cities.
        //It is allowed for a path to contain the same road multiple times, and you can visit cities 1 and n multiple times along the path.
        //The test cases are generated such that there is at least one path between 1 and n.

        //Example 1:

        //Input: n = 4, roads = [[1, 2, 9], [2,3,6], [2,4,5], [1,4,7]]
        //Output: 5
        //Explanation: The path from city 1 to 4 with the minimum score is: 1 -> 2 -> 4. The score of this path is min(9,5) = 5.
        //It can be shown that no other path has less score.
        //Example 2:

        //Input: n = 4, roads = [[1,2,2],[1,3,4],[3,4,7]]
        //Output: 2
        //Explanation: The path from city 1 to 4 with the minimum score is: 1 -> 2 -> 1 -> 3 -> 4. The score of this path is min(2,2,4,7) = 2.

        //Constraints:

        //2 <= n <= 105
        //1 <= roads.length <= 105
        //roads[i].length == 3
        //1 <= ai, bi <= n
        //ai != bi
        //1 <= distancei <= 104
        //There are no repeated edges.
        //There is at least one path between 1 and n.


        // ===== This solution is rather ambiguous=====
        // as it says no repeated edges however you
        // need to go back over locations to path
        // so, im unfamiliar with some of the items to
        // complete here is what i tried to get work
        // but it errors when running on leetcode website

        public int MinScore(int n, int[][] roads)
        {
            List<int> minDistance = new List<int>();
            List<int> locations= new List<int>();
            Array.Sort(roads);
            int[][] unsorted = new int[roads.Length][];
            int count = 0;
            for (int i = 0; i < roads.Length; i++)
            {
                int value = roads[i][0];
                int value2 = roads[i][1];
                int distance = roads[i][2];
                if (locations.Contains(value) || locations.Contains(value2))
                {
                    locations.Add(value);
                    locations.Add(value2);
                    minDistance.Add(distance);
                }
                else
                {
                    unsorted[i] = new int[] { value, value2, distance };
                }
            }
            Array.Sort(unsorted);
            while (unsorted[0] != null && count < roads.Length)
            {
                Array.Sort(unsorted);
                for (int i = 0; i < unsorted.Length; i++)
                {
                    if (unsorted[i] != null)
                    {
                        int value = roads[i][0];
                        int value2 = roads[i][1];
                        int distance = roads[i][2];
                        if (locations.Contains(value) || locations.Contains(value2))
                        {
                            locations.Add(value);
                            locations.Add(value2);
                            minDistance.Add(distance);
                            unsorted[i] = unsorted[unsorted.Length - 1];
                        } 
                    }
                    count++;
                }
            }
            if (minDistance == null) { return 0; }
            else { return minDistance.Min(); }
        }

    }
}
