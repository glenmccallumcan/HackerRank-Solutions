using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    public static class Solution
    {
        public static long countInversions(int[] arr)
        {
            int[] temp = new int[arr.Length];

            return MergeSort(arr, temp, 0, arr.Length - 1);
        }

        private static long MergeSort(int[] numbers, int[] temp, int left, int right)
        {
            long leftInversions = 0;
            long rightInversions = 0;
            long mergeInversions = 0;
            if( left < right )
            {
                int centre = (left + right) / 2;
                leftInversions = MergeSort(numbers, temp, left, centre);
                rightInversions = MergeSort(numbers, temp, centre + 1, right);
                mergeInversions = Merge(numbers, temp, left, centre + 1, right);
            }

            return leftInversions + rightInversions + mergeInversions;
        }

        private static long Merge(int[] numbers, int[] temp, int leftPos, int rightPos, int rightEnd)
        {
            int leftEnd = rightPos - 1;
            int tempPos = leftPos;
            int numElements = rightEnd - leftPos + 1;
            long inversionCount = 0;

            while (leftPos <= leftEnd && rightPos <= rightEnd)
            {
                if (numbers[leftPos] <= numbers[rightPos])
                {
                    temp[tempPos++] = numbers[leftPos++];
                }
                else
                {
                    inversionCount += leftEnd - leftPos + 1;
                    temp[tempPos++] = numbers[rightPos++];
                }
            }

            while(leftPos <= leftEnd)
            {
                temp[tempPos++] = numbers[leftPos++];
            }
            
            while(rightPos <= rightEnd)
            {
                temp[tempPos++] = numbers[rightPos++];
            }

            for(int i = 0; i < numElements; i++, rightEnd--)
            {
                numbers[rightEnd] = temp[rightEnd];
            }

            return inversionCount;
        }
    }
}
