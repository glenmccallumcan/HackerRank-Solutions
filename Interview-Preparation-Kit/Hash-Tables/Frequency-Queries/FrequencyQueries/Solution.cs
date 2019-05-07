using System;
using System.Collections.Generic;

namespace FrequencyQueries
{
    public static class Solution
    {
        public static List<int> freqQuery(List<List<int>> queries)
        {
            const int insert = 1;
            const int delete = 2;
            const int freqCheck = 3;

            var numberCounts = new Dictionary<int, int>();
            var freqCounts = new Dictionary<int, int>();
            var output = new List<int>();

            foreach (List<int> query in queries)
            {
                var queryOperation = query[0];
                var queryValue = query[1];

                if (queryOperation == insert)
                {
                    var count = GetCountOfNumberInStructure(numberCounts, queryValue);
                    AddNumberToStructure(numberCounts, queryValue);
                    UpdateFrequency(freqCounts, count, increment:1);
                    continue;
                }

                if (queryOperation == delete)
                {
                    var count = GetCountOfNumberInStructure(numberCounts, queryValue);
                    if (count > 0)
                    {
                        RemoveNumberFromStructure(numberCounts, queryValue);
                        UpdateFrequency(freqCounts, count, increment: -1);
                    }
                    continue;
                }

                if (queryOperation == freqCheck)
                {
                    if (freqCounts.EnsureExists(queryValue)[queryValue] != 0)
                    {
                        output.Add(1);
                    }
                    else
                    {
                        output.Add(0);
                    }
                }
            }

            return output;
        }

        private static void UpdateFrequency(Dictionary<int, int> freqCounts, int freq, int increment)
        {
            freqCounts.EnsureExists(freq)[freq] = freqCounts[freq] - 1;//decrement frequency count
            freqCounts.EnsureExists(freq + increment)[freq + increment] = freqCounts[freq + increment] + 1;
        }

        private static void RemoveNumberFromStructure(Dictionary<int, int> numberCounts, int number)
        {
            AddNumberToStructure(numberCounts, number, -1);
        }

        private static void AddNumberToStructure(Dictionary<int, int> numberCounts, int number, int increment = 1)
        {
            numberCounts.EnsureExists(number)[number] = numberCounts[number] + increment;
        }

        private static int GetCountOfNumberInStructure (Dictionary<int, int> numberCounts, int number)
        {
            return numberCounts.EnsureExists(number)[number];
        }

        private static Dictionary<int, int> EnsureExists(
            this Dictionary<int, int> dict,
            int value)
        {
            if (!dict.ContainsKey(value))
            {
                dict.Add(value, 0);
            }

            return dict;
        }
    }
}
