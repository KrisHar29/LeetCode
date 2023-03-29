using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Transactions;

namespace LeetCode
{
    internal class Solution121
    {
        //121. Best Time to Buy and Sell Stock
        //Easy
        //24.4K
        //763
        //Companies
        //You are given an array prices where prices[i] is the price of a given stock on the ith day.

        //You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

        //Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.

        //Example 1:

        //Input: prices = [7, 1, 5, 3, 6, 4]
        //Output: 5
        //Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        //Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
        //Example 2:

        //Input: prices = [7,6,4,3,1]
        //        Output: 0
        //Explanation: In this case, no transactions are done and the max profit = 0.

        //Constraints:

        //1 <= prices.length <= 105
        //0 <= prices[i] <= 104

        //====this solution timed out againt their 10000 day input===
        //public int MaxProfit(int[] prices)
        //{
        //    int profit = 0;
        //    int holder = 0;
        //    int min = 0;
        //    while (prices.Length > 1)
        //    {
        //        holder = prices[prices.Length - 1];
        //        //prices.RemoveAt(holder);
        //        Array.Resize(ref prices, prices.Length - 1);
        //        min = prices.Min();
        //        if (holder - min > profit)
        //        {
        //            profit = holder - min;
        //        }
        //    }
        //    if (profit > 0)
        //    {
        //        return profit;
        //    }
        //    return 0;
        //}


        //=== solution 2 using pointer at start and end, which is much more ineffcient ===
        //public int MaxProfit(int[] prices)
        //{
        //    int left = 0;
        //    int right = prices.Length - 1;
        //    int _MaxProfit = 0;
        //    while (left < right)
        //    {
        //        if (prices[left] > prices[right] && prices[left] > prices[left+1])
        //        {
        //            left++;
        //        }
        //        else if (prices[left] > prices[right] && prices[right] < prices[right - 1])
        //        {
        //            right--;
        //        }
        //        else if (prices[left] < prices[right] && _MaxProfit < prices[right] - prices[left])
        //        {
        //            _MaxProfit= prices[right] - prices[left];
        //        }
        //        else if (prices[left] < prices[right] && _MaxProfit >= prices[right] - prices[left])
        //        {
        //            if (prices[right-1] > prices[left])
        //            {
        //                right--;
        //            }
        //            else { left++; }
        //        }
        //    }
        //    return _MaxProfit;
        //}

        //===solution 3===
        public int MaxProfit(int[] prices)
        {
            int profit = 0;
            if (prices.Length == 1)
            {
                return profit;
            }
            int buyPrice = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                profit = Math.Max(profit, prices[i] - buyPrice);
                buyPrice = Math.Min(buyPrice, prices[i]);
            }
            return profit;
        }
    }
}
