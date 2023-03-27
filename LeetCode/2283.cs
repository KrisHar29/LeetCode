using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCode
{
    public static class Solution2283
    {
        //2283. Check if Number Has Equal Digit Count and Digit Value
        //Easy
        //423
        //47
        //Companies
        //You are given a 0-indexed string num of length n consisting of digits.

        //Return true if for every index i in the range 0 <= i<n, the digit i occurs num[i] times in num, otherwise return false.

        //Example 1:

        //Input: num = "1210"
        //Output: true
        //Explanation:
        //num[0] = '1'. The digit 0 occurs once in num.
        //num[1] = '2'. The digit 1 occurs twice in num.
        //num[2] = '1'. The digit 2 occurs once in num.
        //num[3] = '0'. The digit 3 occurs zero times in num.
        //The condition holds true for every index in "1210", so return true.
        //Example 2:

        //Input: num = "030"
        //Output: false
        //Explanation:
        //num[0] = '0'. The digit 0 should occur zero times, but actually occurs twice in num.
        //num[1] = '3'. The digit 1 should occur three times, but actually occurs zero times in num.
        //num[2] = '0'. The digit 2 occurs zero times in num.
        //The indices 0 and 1 both violate the condition, so return false.

        //Constraints:

        //n == num.length
        //1 <= n <= 10
        //num consists of digits.
        public static bool DigitCount(string num)
        {
            //int digitCount = 0;
            //Hashtable hash = new Hashtable();
            //for (int i = 0; i < num.Length; i++)
            //{
            //    hash.Add(i, num[i]);
            //}
            //foreach (DictionaryEntry pair in hash)
            //{
            //    foreach (DictionaryEntry number in hash)
            //    {
            //        if (pair.Key == number.Value)
            //        {
            //            digitCount++;
            //        }
            //    }
            //    if (digitCount != Convert.ToInt32(pair.Value))
            //    {
            //        return false;
            //    }
            //    digitCount = 0;
            //}
            //return true;
            int numLength = num.Length;
            int validNum = 0;
            int[] total = new int[10];
            foreach (char c in num)
            {
                total[(int)char.GetNumericValue(c)]++;
            }
            for (int i = 0; i < numLength; i++)
            {
                if ((int)char.GetNumericValue(num[i]) == total[i])
                {
                    validNum++;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
