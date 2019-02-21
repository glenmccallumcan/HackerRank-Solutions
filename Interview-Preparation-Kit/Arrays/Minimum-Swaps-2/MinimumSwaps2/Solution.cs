using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("MinimumSwaps2.UnitTests")]

namespace MinimumSwaps2
{
    public class Solution
    {
        internal static int minimumSwaps(int[] arr)
        {
            var arrayLookup = convertArrToDict(arr);
            var counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != i + 1)
                {
                    var correctIndex = arrayLookup[i + 1];

                    //swap in the dict
                    arrayLookup[i + 1] = i;
                    arrayLookup[arr[i]] = correctIndex;

                    //swap in the array
                    int temp = arr[i];
                    arr[i] = arr[correctIndex];
                    arr[correctIndex] = temp;

                    //increment counter
                    counter++;
                }
            }
            
            return counter;
        }

        internal static Dictionary<int, int> convertArrToDict(int[] arr)
        {
            var result = new Dictionary<int, int>();

            for(int i = 0; i < arr.Length; i++)
            {
                result.Add(arr[i], i);
            }
            return result;
        }

    }
}
