using System;
using System.Collections.Generic;

namespace SockMerchant
{
    public class Solution
    {
        public static int sockMerchant(int n, int[] ar)
        {
            var sockCount = new Dictionary<int, int>();

            foreach (int sock in ar)
            {
                if (sockCount.ContainsKey(sock))
                {
                    sockCount[sock]++;
                    continue;
                }

                sockCount.Add(sock, 1);
            }

            int pairCount = 0;

            foreach (var sockColour in sockCount)
            {
                pairCount += sockColour.Value / 2;
            }

            return pairCount;
        }
    }
}
