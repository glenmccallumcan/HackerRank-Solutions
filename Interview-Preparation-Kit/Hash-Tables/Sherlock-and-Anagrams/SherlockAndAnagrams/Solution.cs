using System;
using System.Collections.Generic;
using System.Linq;

namespace SherlockAndAnagrams
{
    public class Solution
    {
        public static int sherlockAndAnagrams(string s)
        {
            if(s.ToCharArray().Distinct().Count() == s.ToCharArray().Length)
            {
                return 0;
            }

            var substrings = new Dictionary<string, int>();
           
            for(int subLength = 1; subLength < s.Length; subLength++)
            {
                int index = 0;
                
                while (index + subLength -1 < s.Length)
                {
                    var sub = new string(s.Substring(index, subLength).ToCharArray().OrderBy(c => c).ToArray());

                    if(!substrings.ContainsKey(sub))
                    {
                        substrings.Add(sub, 0);
                    }

                    substrings[sub] = substrings[sub] + 1;

                    index++;
                }
            }

            Dictionary<string, int> anagrams = substrings.Where(pair => pair.Value > 1).ToDictionary(pair => pair.Key, pair => pair.Value);

            int sum = 0;
            foreach (var a in anagrams)
            {
                sum += unchecked((int)(factorial(a.Value) / (factorial(a.Value - 2)*factorial(2))));
            }

            return sum;
        }

        private static long factorial(int input)
        {
            long i;
            long ans = 1;

            for (i = 2; i <= input; i++)
                ans *= i;
            return ans;
        }
    }
}
