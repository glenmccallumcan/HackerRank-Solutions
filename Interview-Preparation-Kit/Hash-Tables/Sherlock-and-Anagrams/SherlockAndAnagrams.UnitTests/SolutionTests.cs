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
            public void ComputesCorrectResponse(string s, int result)
            {
                Assert.Equal(Solution.sherlockAndAnagrams(s), result);
            }
        }

        public class TheAreAnagramsMethod
        {
            [Theory]
            [InlineData("abc", "bcd", false)]
            [InlineData("a", "a", true)]
            [InlineData("a", "b", false)]
            [InlineData("ab", "ba", true)]
            public void ComputesCorrectResponse(string left, string right, bool result)
            {
                Assert.Equal(Solution.areAnagrams(left, right), result);
            }
        }

        public class countAnagramsOfLength
        {
            [Theory]
            [InlineData("abc", "a", 0, 1)]
            [InlineData("abc", "a", 1, 0)]
            [InlineData("a", "", 0, 0)]
            [InlineData("abba", "ab", 1, 1)]
            [InlineData("abba", "ab", 2, 1)]
            [InlineData("abba", "ab", 3, 0)]
            public void ComputesCorrectResponse(string s, string sub, int startIndex, int result)
            {
                Assert.Equal(Solution.countAnagramsToRightOf(s, sub, startIndex), result);
            }
        }

        public class countAllAnagramsOfLength
        {
            [Theory]
            [InlineData("abc", 0, 0)]
            [InlineData("abc", 1, 0)]
            [InlineData("abc", 2, 0)]
            [InlineData("abc", 3, 0)]
            [InlineData("abc", 4, 0)]
            [InlineData("a", 1, 0)]
            [InlineData("abba", 1, 2)]
            [InlineData("abba", 2, 1)]
            [InlineData("abba", 3, 1)]
            public void ComputesCorrectResponse(string s, int anagramLength, int result)
            {
                Assert.Equal(Solution.countAllAnagramsOfLength(s, anagramLength), result);
            }
        }
    }
}
