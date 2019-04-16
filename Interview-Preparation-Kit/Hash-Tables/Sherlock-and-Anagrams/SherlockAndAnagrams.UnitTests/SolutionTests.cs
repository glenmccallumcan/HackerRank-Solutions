using System;
using Xunit;

namespace SherlockAndAnagrams.UnitTests
{
    public class SolutionTests
    {
        public class TheSherlockAndAnagramsMethod
        {
            [Theory]
            [InlineData("abba", 4)]
            [InlineData("abcd", 0)]
            [InlineData("ifailuhkqq", 3)]
            [InlineData("kkkk", 10)]
            [InlineData("cdcd", 5)]
            public void ComputesCorrectResponse(string s, int result)
            {
                Assert.Equal(Solution.sherlockAndAnagrams(s), result);
            }
        }
    }
}
