using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("MinimumSwaps2.UnitTests")]

namespace MinimumSwaps2
{
    public class Solution
    {
        internal static int minimumSwaps2(int[] arr)
        {
            shiftLeft(arr); // so much easier to have the input array indexes match values when sorted
                            // rather than having -1 in certain places to check if the value matches
                            // the index

            var visited = new bool[arr.Length];

            var sortedDict = convertArrToDict(arr); // I suppose it doesn't matter where you start
                                                    // if you visit each node in the array eventually
                                                    // but it is kind of nice to go through in increasing
                                                    // value

                                                    

            int totalCycles = 0;

            foreach(var item in sortedDict)
            {
                if(visited[item.Key] || item.Key == item.Value)
                {
                    continue;
                }

                int cycleLength = 0;
                int indexInCycle = item.Key; // start at current place in the dict

                while (!visited[indexInCycle])
                {
                    visited[indexInCycle] = true;
                    indexInCycle = sortedDict[indexInCycle]; // move to the next node in the cycle
                    cycleLength += 1;
                }

                totalCycles += cycleLength - 1;
            }

            return totalCycles;
        }

        private static void shiftLeft(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i]--;
            }
        }

        internal static SortedDictionary<int, int> convertArrToDict(int[] arr)
        {
            var result = new SortedDictionary<int, int>();

            for(int i = 0; i < arr.Length; i++)
            {
                result.Add(arr[i], i);
            }
            return result;
        }

    }
}
