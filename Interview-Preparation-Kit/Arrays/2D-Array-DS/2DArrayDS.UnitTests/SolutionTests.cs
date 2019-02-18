using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Extensions;

namespace _2DArrayDS.UnitTests
{
    public class SolutionTests
    {
        public class TheHourglassSumMethod
        {
            public static IEnumerable<object[]> HourglassData
            {
                get
                {
                    return new[]
                    {
                        new object[]
                        {
                            new int[6][] {new int[6] {-1, -1, 0, -9, -2, -2 },
                                        new int[6] { -2, -1, -6, -8, -2, -5 },
                                        new int[6] { -1, -1, -1, -2, -3, -4 },
                                        new int[6] { -1, -9, -2, -4, -4, -5 },
                                        new int[6] { -7, -3, -3, -2, -9, -9 },
                                        new int[6] { -1, -3, -1, -2, -4, -5 } } as Object,
                            -6
                        }
                    };
                }
            }
            
            [Theory]
            [MemberData(nameof(HourglassData))]
            public void ComputesCorrectResponse(int [][] arr, int sum)
            {
                Assert.Equal(Solution.hourglassSum(arr), sum);
            }
        }
    }
}
