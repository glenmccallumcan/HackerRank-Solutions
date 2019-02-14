namespace JumpingOnTheClouds
{
    public class Solution
    {
        public static int jumpingOnClouds(int[] c)
        {
            int jumpCounter = 0;

            int i = 0;
            while(i < c.Length)
            {
                if(i == c.Length - 1 && c[i] == 0)
                {
                    break;
                }
                else if (i + 2 < c.Length && c[i + 2] == 0)
                {
                    jumpCounter++;
                    i = i + 2;
                }else if (i + 1 < c.Length && c[i + 1] == 0)
                {
                    jumpCounter++;
                    i = i + 1;
                }
            }
            return jumpCounter;
        }
    }
}
