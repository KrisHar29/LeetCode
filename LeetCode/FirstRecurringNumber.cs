using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class FirstRecurringNumber
    {
        public static int FirstRecurring(int[] numberList)
        {
            // ===how i would normally do===
            //int number = numberList[0];
            //for (int i = 1; i < numberList.Length; i++)
            //{
            //    if (number == numberList[i])
            //    {
            //        return number;
            //    }
            //    number = numberList[i];
            //}
            //return -1;

            //=== using a hashtable ===
            // but this has the difference of
            // 1st recurring character "seen"
            Hashtable h = new Hashtable();
            for (int i = 0; i < numberList.Length; i++)
            {
                if (h.ContainsKey(numberList[i]))
                {
                    return numberList[i];
                }
                h[numberList[i]] = numberList[i];
            }
            return -1;
        }
    }
}
