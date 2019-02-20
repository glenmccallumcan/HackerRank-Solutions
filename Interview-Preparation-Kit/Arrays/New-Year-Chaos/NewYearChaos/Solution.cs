using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("NewYearChaos.UnitTests")]

namespace NewYearChaos
{
    

    public class Solution
    {
        static void minimumBribes(int[] q)
        {
            var bribes = GetMinBribes(q);

            if (bribes == -1)
            {
                Console.WriteLine("Too chaotic");
            } else
            {
                Console.WriteLine(bribes);
            }
        }

        internal static int GetMinBribes(int[] q)
        {
            int n = q.Length;
            int cnt = 0;

            for (int i = n - 1; i >= 0; i--)
            {
                if (q[i] != i + 1)
                {
                    if (((i - 1) >= 0) && q[i - 1] == (i + 1))
                    {
                        cnt++;
                        q[i - 1] = q[i];
                        q[i] = i + 1;
                    }
                    else if (((i - 2) >= 0) && q[i - 2] == (i + 1))
                    {
                        cnt += 2;
                        q[i - 2] = q[i - 1];
                        q[i - 1] = q[i];
                        q[i] = i + 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            return cnt;
        }
    }
}
