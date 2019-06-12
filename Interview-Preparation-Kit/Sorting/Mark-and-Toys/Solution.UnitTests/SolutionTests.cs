using System;
using System.Collections.Generic;
using Xunit;

namespace Solution.UnitTests
{
    public class SolutionTests
    {


        [Theory]
        [InlineData(new int[] {1, 12, 5, 111, 200, 1000, 10}, 50, 4)]
        public void ComputesCorrectResponse(int[] toys, int money, int numberOfToys)
        {
            Assert.Equal(Solution.maximumToys(toys, money), numberOfToys);
        }
    }
}
