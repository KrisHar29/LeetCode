using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class Solution383
    {

    //        383. Ransom Note
    //Easy
    //3.8K
    //403
    //Companies
    //Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

    //Each letter in magazine can only be used once in ransomNote.


    //Example 1:

    //Input: ransomNote = "a", magazine = "b"
    //Output: false
    //Example 2:

    //Input: ransomNote = "aa", magazine = "ab"
    //Output: false
    //Example 3:

    //Input: ransomNote = "aa", magazine = "aab"
    //Output: true
 

    //Constraints:

    //1 <= ransomNote.length, magazine.length <= 105
    //ransomNote and magazine consist of lowercase English letters.
        public static bool CanConstruct(string ransomNote, string magazine)
        {
            for (int i = 0; i < ransomNote.Length; i++)
            {
                char r = ransomNote[i];

                int matchingIndex = magazine.IndexOf(r);

                if (matchingIndex == -1) { return false; }
                magazine = magazine.Substring(0, matchingIndex) + magazine.Substring(matchingIndex +1 );
            }
            return true;
        }
    }
}
