using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution412
    {
        public static List<string> FizzBuzz(int n)
        {
            List<string> list = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                string output = "";
                if(i % 3 == 0 )
                {
                    output += "Fizz";
                }
                if (i % 5 == 0)
                {
                    output += "Buzz";
                }
                if (output.Length == 0 ) { output += i.ToString(); }
                list.Add(output);
            }
            return list;
        }
    }
}
