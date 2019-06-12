using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    public static class Solution
    {
        // Complete the maximumToys function below.
        public static int maximumToys(int[] prices, int k)
        {
            var orderedPrices = prices.OrderBy(p => p);

            var count = 0;
            var spent = 0;
            foreach(var price in orderedPrices)
            {
                if (spent + price > k)
                {
                    break;
                }
                else
                {
                    count++;
                    spent += price;
                }
            }

            return count;
        }
    }
}
