using System;
using Xunit;

namespace CountingValleys.UnitTests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(8, "UDDDUDUU", 1)]
        public void ComputesCorrectResponse(int n, string s, int numValleys)
        {

            Assert.Equal(Solution.countingValleys(n, s), numValleys);
        }
    }
}
