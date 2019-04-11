using System;
using System.Collections.Generic;
using ArrayManipulation;
using Xunit;

namespace ArrayManipulation.UnitTests
{
    public class SolutionTests
    {
        public class TheArrayManipulationMethod
        {
            public static int ArrayLength = 5;
            public static IEnumerable<object[]> QueryData
            {
                get
                {
                    return new[]
                    {
                        new object[]
                        {
                            5,
                            new int[3][] {new int[3] { 1, 2, 100 },
                                        new int[3] { 2, 5, 100 },
                                        new int[3] { 3, 4, 100 } } as Object,
                            200
                        }
                    };
                }
            }

            [Theory]
            [MemberData(nameof(QueryData))]
            public void ComputesCorrectResponse(int n, int[][] queries, long result)
            {
                Assert.Equal(Solution.arrayManipulation(n, queries), result);
            }
        }
    }
}
