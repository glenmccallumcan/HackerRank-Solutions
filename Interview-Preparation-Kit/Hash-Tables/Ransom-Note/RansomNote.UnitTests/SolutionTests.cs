using System;
using Xunit;

namespace RansomNote.UnitTests
{
    public class SolutionTests
    {
        public class TheCheckMagazineMethod
        {
            [Theory]
            [InlineData(new string[] { "ive", "got", "a", "lovely", "bunch", "of", "coconuts" },
                new string[] { "ive", "got", "some", "coconuts" },
                "No")]
            [InlineData(new string[] { "two", "times", "three", "is", "not", "four" },
                new string[] { "two", "times", "two", "is", "four" },
                "No")]
            public void ComputesCorrectResponse(string[] magazine, string[] note, string answer)
            {
                Assert.Equal(Solution.getCheckMagazineResult(magazine, note), answer);
            }
        }
    }
}
