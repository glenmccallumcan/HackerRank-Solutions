using System;
using System.Linq;

namespace RepeatedString
{
    public class Solution
    {

        public static long repeatedString(string s, long n)
        {

            Func<string, int> getNumberOfAs = (str) => str.ToList<char>().Where<char>(x => x == 'a').Count<char>();

            // count the as in string
            long asInString = getNumberOfAs(s);

            // divide n by the length of the string
            long multiplesOfAs = n / s.Length;

            // times result by number of as in string -> first set of as
            long numberOfAs = multiplesOfAs * asInString;

            // mod n by the length of the string -> mod result
            long modResult =  n % s.Length;

            // count the number of as in the first modresult characters in the string
            return numberOfAs += getNumberOfAs(s.Substring(0, unchecked((int)modResult)));
        }

        
    }
}
