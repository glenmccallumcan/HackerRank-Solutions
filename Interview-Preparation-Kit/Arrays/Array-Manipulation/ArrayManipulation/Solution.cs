using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulation
{
    public class Solution
    {
        public static long arrayManipulation(int n, int[][] queries)
        {
            var prefixSumArray = new long[n];

            foreach (var operation in queries )
            {
                int a = operation[0] - 1;
                int b = operation[1];
                int k = operation[2];

                prefixSumArray[a] += k;
                if (b < n)
                {
                    prefixSumArray[b] -= k;
                }
            }

            long sum = 0;
            long max = 0;
            for(int i = 0;i<prefixSumArray.Length;i++)
            {
                sum += prefixSumArray[i];
                max = sum > max ? sum : max;
            }

            return max;
        }
    }

    
}
