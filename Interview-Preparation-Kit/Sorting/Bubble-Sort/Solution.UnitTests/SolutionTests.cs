using System;
using System.Collections.Generic;
using Xunit;

namespace Solution.UnitTests
{
    public class SolutionTests
    {

        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 0, 1, 3 })]
        [InlineData(new int[] { 3, 2, 1 }, new int[] { 3, 1, 3 })]
        [InlineData(new int[] { 4, 2, 3, 1 }, new int[] { 5, 1, 4 })]
        public void ComputesCorrectResponse(int[] a, int[] result)
        {
            Assert.Equal(Solution.myCountSwaps(a), result);
        }
    }
}
