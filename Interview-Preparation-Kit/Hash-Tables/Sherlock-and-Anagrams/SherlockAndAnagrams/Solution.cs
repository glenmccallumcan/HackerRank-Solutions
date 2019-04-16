using System;
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

            var counter = 0;
            
            for(int i = 1; i < s.Length; i++)
            {
                counter += countAllAnagramsOfLength(s, i);
            }

            return counter;
        }

        public static int countAllAnagramsOfLength(string s, int anagramLength)
        {
            var index = 0;
            int counter = 0;

            while(anagramLength != 0 && (index + anagramLength -1) < s.Length)
            {
                var sub = s.Substring(index, anagramLength);
                counter += countAnagramsToRightOf(s, sub, index + 1);
                index++;
            }
            return counter;
        }

        public static int countAnagramsToRightOf(string s, string sub, int startIndex)
        {
            int left = startIndex;
            int counter = 0;

            while (sub.Length != 0 && left + sub.Length - 1 < s.Length)
            {
                if(areAnagrams(sub, s.Substring(left, sub.Length)))
                {
                    counter++;
                }

                left++;
            }

            return counter;
        }

        public static bool areAnagrams(string left, string right)
        {
            if(left.ToCharArray().OrderBy(c => c).SequenceEqual(right.ToCharArray().OrderBy(c => c)))
            {
                return true;
            }

            return false;
        }
    }
}
