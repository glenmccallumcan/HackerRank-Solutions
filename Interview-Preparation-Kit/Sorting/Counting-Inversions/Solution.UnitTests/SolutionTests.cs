using System;
using System.Collections.Generic;
using Xunit;

namespace Solution.UnitTests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 1, 1, 1, 2, 2 }, 0)]
        [InlineData(new int[] { 2, 1, 3, 1, 2 }, 4)]
        [InlineData(new int[] { 1, 5, 3, 7 }, 1)]
        [InlineData(new int[] { 3, 2, 1 }, 3)]
        [InlineData(new int[] { 7, 5, 3, 1 }, 6)]
        public void ComputesCorrectResponse(int[] arr, int result)
        {
            Assert.Equal(Solution.countInversions(arr), result);
        }
    }
}
