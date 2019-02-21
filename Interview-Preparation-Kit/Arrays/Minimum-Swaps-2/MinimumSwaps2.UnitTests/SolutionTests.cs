using System;
using System.Collections.Generic;
using Xunit;

namespace MinimumSwaps2.UnitTests
{
    public class SolutionTests
    {
        public class TheMinimumSwaps2Method
        {
            [Theory]
            [InlineData(new int[] { 4, 3, 1, 2 }, 3)]
            [InlineData(new int[] { 2, 3, 4, 1, 5 }, 3)]
            [InlineData(new int[] { 1, 3, 5, 2, 4, 6, 7 }, 3)]
            public static void ComputesCorrectResponse(int[] arr, int answer)
            {
                Assert.Equal<int>(Solution.minimumSwaps2(arr), answer);
            }
        }

        public class TheConvertArrToDictMethod
        {
            public static IEnumerable<object[]> DictData
            {
                get
                {
                    return new[]
                    {
                        new object[]
                        {
                            new int[] { 4, 3, 1, 2 } as Object,
                            new Dictionary<int, int> { { 4, 0 }, { 3, 1 }, { 1, 2 }, { 2, 3 } }
                        }
                    };
                }
            }

            [Theory]
            [MemberData(nameof(DictData))]
            public static void ConvertsArrayToDict(int[] arr, Dictionary<int,int> output)
            {
                Assert.Equal(Solution.convertArrToDict(arr), output);
            }
        }
    }
}
