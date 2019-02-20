using System;
using Xunit;

namespace NewYearChaos.UnitTests
{
    public class SolutionTests
    {
        public class TheMinimumBribesMethod
        {
            [Theory]
            [InlineData(new int[] { 2, 1, 5, 3, 4 }, 3)]
            [InlineData(new int[] { 2, 5, 1, 3, 4 }, -1)]
            [InlineData(new int[] { 1, 2, 3, 4, 5 }, 0)]
            [InlineData(new int[] { }, 0)]
            [InlineData(new int[] { 5, 1, 2, 3, 7, 8, 6, 4 }, -1)]
            [InlineData(new int[] { 1, 2, 5, 3, 7, 8, 6, 4 }, 7)]
            public static void ComputesCorrectResponse(int[] q, int minBribes)
            {
                Assert.Equal<int>(Solution.GetMinBribes(q), minBribes);
            }
        }
    }
}
