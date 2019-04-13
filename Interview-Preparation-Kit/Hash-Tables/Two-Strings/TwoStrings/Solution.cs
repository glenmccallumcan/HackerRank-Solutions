using System;
using System.Linq;

namespace TwoStrings
{
    public class Solution
    {
        public static string twoStrings(string s1, string s2)
        {
            if(s1.ToCharArray().Intersect(s2.ToCharArray()).Any())
            {
                return "YES";
            }

            return "NO";
        }
    }
}
