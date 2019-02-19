using System;
using Xunit;

namespace LeftRotation.UnitTests
{
    public class SolutionTests
    {
        public class TheRotLeftMethod
        {
            [Theory]
            [InlineData(new int[] { 1, 2, 3, 4, 5 }, 4, new int[] { 5, 1, 2, 3, 4 } )]
            public static void ComputesCorrectResponse(int[] a, int d, int[] result)
            {
                Assert.Equal<int[]>(Solution.rotLeft(a, d), result);
            }
        }
    }
}
