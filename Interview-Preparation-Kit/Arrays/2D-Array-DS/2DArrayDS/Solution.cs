using System;

namespace _2DArrayDS
{
    public class Solution
    {
        public static int hourglassSum(int[][] arr)
        {
            int maxHourglassSum = int.MinValue;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    maxHourglassSum =
                        getHourglassSum(arr, i, j) > maxHourglassSum ?
                            getHourglassSum(arr, i, j) :
                            maxHourglassSum;
                }
            }
            return maxHourglassSum;
        }

        static int getHourglassSum(int[][] arr, int i, int j)
        {
            return arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                            + arr[i + 1][j + 1]
                + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
        }
    }
}
