using System;
using Xunit;

namespace TwoStrings.UnitTests
{
    public class SolutionTests
    {
        public class TheTwoStringsMethod
        {
            [Theory]
            [InlineData("hello", "world", "YES")]
            [InlineData("hi", "world", "NO")]
            public void ComputesCorrectResponse(string s1, string s2, string response)
            {
                Assert.Equal(Solution.twoStrings(s1, s2), response);
            }
        }
    }
}
