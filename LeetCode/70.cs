using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode
{
    public static class Solution70
    {
        //70. Climbing Stairs
        //Easy
        //17.5K
        //541
        //Companies
        //You are climbing a staircase.It takes n steps to reach the top.

        //Each time you can either climb 1 or 2 steps.In how many distinct ways can you climb to the top?

        //Example 1:

        //Input: n = 2
        //Output: 2
        //Explanation: There are two ways to climb to the top.
        //1. 1 step + 1 step
        //2. 2 steps
        //Example 2:

        //Input: n = 3
        //Output: 3
        //Explanation: There are three ways to climb to the top.
        //1. 1 step + 1 step + 1 step
        //2. 1 step + 2 steps
        //3. 2 steps + 1 step

        //Constraints:

        //1 <= n <= 45

        public static int ClimbStairs(int n)
        {
            //int count = 3;
            //int last = 1;
            //if (n == 1) { count = 1; }
            //if (n == 2) { count = 2; }
            //for (int i = 3; i < n; i++)
            //{
            //    last 
            //    count += i-2;
            //}
            //return count;


            int count = 1;
            int increment = 1;
            int holder = 1;
            if (n >= 2) { count = 2; }
            for (int i = 3; i <= n; i++)
            {
                holder = count;
                count += increment;
                increment = holder;
            }
            return count;
        }
    }
}
