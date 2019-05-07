using System;
using System.Collections.Generic;
using Xunit;

namespace FrequencyQueries.UnitTests
{
    public class SolutionTests
    {
        public static IEnumerable<object[]> QueryData
        {
            get
            {
                return new[]
                {
                        new object[]
                        {
                            new List<List<int>> {
                                new List<int>{ 1, 3 },
                                new List<int>{ 2, 3 },
                                new List<int>{ 3, 2 },
                                new List<int>{ 1, 4 },
                                new List<int>{ 1, 5 },
                                new List<int>{ 1, 5 },
                                new List<int>{ 1, 4 },
                                new List<int>{ 3, 2 },
                                new List<int>{ 2, 4 },
                                new List<int>{ 3, 2 }

                            } as Object,
                            new List<int>
                            {
                                0,
                                1,
                                1
                            }
                        }
                    };
            }
        }

        [Theory]
        [MemberData(nameof(QueryData))]
        public void ComputesCorrectResponse(List<List<int>> queries, List<int> result)
        {
            Assert.Equal(Solution.freqQuery(queries), result);
        }
    }
}
