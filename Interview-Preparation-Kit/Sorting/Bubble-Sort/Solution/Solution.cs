using System;
using System.Collections.Generic;

namespace Solution
{
    public class Solution
    {
        public static void countSwaps(int[] a)
        {
            var answer = myCountSwaps(a);

            if (answer.Length != 3)
            {
                throw new NotSupportedException();
            }

            Console.WriteLine($"Array is sorted in {answer[0]} swaps.");
            Console.WriteLine($"First Element: {answer[1]}");
            Console.WriteLine($"Last Element: {answer[2]}");
        }

        public static int[] myCountSwaps(int[] a)
        {
            var n = a.Length;
            var counter = 0;

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n - 1; j++)
                {
                    // Swap adjacent elements if they are in decreasing order
                    if (a[j] > a[j + 1])
                    {
                        swap(a, j, j + 1);
                        counter++;
                    }
                }
            }

            return new int[] { counter, a[0], a[n - 1] };
        }

        private static void swap(int[] array, int index1, int index2)
        {
            var temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}
