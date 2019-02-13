using System;

namespace CountingValleys
{
    public class Solution
    {
        public static int countingValleys(int n, string s)
        {
            int valleyCounter = 0;
            int runningElevation = 0;
            bool alreadyinValley = false;

            char[] steps = s.ToCharArray();

            foreach (char step in steps)
            {
                if (step == 'U')
                {
                    runningElevation++;
                }

                if (step == 'D')
                {
                    runningElevation--;
                }

                if (runningElevation < 0 && !alreadyinValley)
                {
                    valleyCounter++;
                    alreadyinValley = true;
                }

                if(runningElevation == 0)
                {
                    alreadyinValley = false;
                }
            }
            
            return valleyCounter;
        }
    }
}
