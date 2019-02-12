using System;
using Xunit;

namespace SockMerchant.UnitTests
{
    public class SolutionTests
    {
        public class TheSockMerchantMethod
        {
            [Theory]
            [InlineData(9, new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 }, 3)]
            [InlineData(7, new int[] { 1, 2, 1, 2, 1, 3, 2 }, 2)]
            [InlineData(10, new int[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 }, 4)]
            public void ComputesCorrectResponse(int numSocks, int[] socks, int numPairsResult)
            {
                Assert.Equal(Solution.sockMerchant(numSocks, socks), numPairsResult);
            }

        }

    }
}
