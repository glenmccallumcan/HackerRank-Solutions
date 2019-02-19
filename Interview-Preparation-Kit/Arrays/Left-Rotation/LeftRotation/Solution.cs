using System;

namespace LeftRotation
{
    public class Solution
    {
        public static int[] rotLeft(int[] a, int d)
        {
            var temps = new int[d];

            // put all the ints removed from the front in an array
            for (int i = 0; i < d; i++)
            {
                temps[i] = a[i];
            }

            // shift remaining ints down
            for (int i = d; i < a.Length; i++)
            {
                a[i - d] = a[i];
            }

            // add rotated ints back on to the end
            int index = 0;
            for (int i = a.Length - d; i < a.Length; i++)
            {
                a[i] = temps[index++];
            }

            return a;
        }
    }
}
