using Xunit;

namespace JumpingOnTheClouds.UnitTests
{
    public class SolutionTests
    {
        public class TheJumpingOnCloudsMethod
        {
            [Theory]
            [InlineData(new int[] { 0, 0, 1, 0, 0, 1, 0 }, 4)]
            [InlineData(new int[] { 0, 0, 0, 0, 1, 0 }, 3)]
            [InlineData(new int[] { 0, 1, 0, 0, 0, 1, 0 }, 3)]
            [InlineData(new int[] { 0, 0, 0, 1, 0, 0 }, 3)]
            public void ComputesCorrectResponse(int[] c, int numberConsetive)
            {
                Assert.Equal(Solution.jumpingOnClouds(c), numberConsetive);
            }

        }
    }
}
