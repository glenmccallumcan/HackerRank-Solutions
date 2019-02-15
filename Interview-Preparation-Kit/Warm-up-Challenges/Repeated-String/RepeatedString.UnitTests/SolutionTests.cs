using System;
using Xunit;

namespace RepeatedString.UnitTests
{
    public class SolutionTests
    {
        public class TheRepeatedStringMethod
        {
            [Theory]
            [InlineData("a", 1000000000000, 1000000000000)]
            [InlineData("aba", 10, 7)]
            public void ComputesCorrectResponse(string s, long n, long result)
            {
                Assert.Equal(Solution.repeatedString(s, n), result);
            }
        }
    }
}
