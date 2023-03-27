using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Solution1108
    {
        //1108. Defanging an IP Address
        //Easy
        //1.6K
        //1.7K
        //Companies
        //Given a valid(IPv4) IP address, return a defanged version of that IP address.

        //A defanged IP address replaces every period "." with "[.]".

        //Example 1:

        //Input: address = "1.1.1.1"
        //Output: "1[.]1[.]1[.]1"
        //Example 2:

        //Input: address = "255.100.50.0"
        //Output: "255[.]100[.]50[.]0"

        //Constraints:

        //The given address is a valid IPv4 address.

    
        public  string DefangIPaddr(string address)
        {
            if (address.Contains("."))
            {
                address = address.Replace(".", "[.]");
            }
            return address;
        }
        
    }
}
