using System;
using System.Collections.Generic;

namespace RansomNote
{
    public class Solution
    {
        static void checkMagazine(string[] magazine, string[] note)
        {
            Console.Out.WriteLine(getCheckMagazineResult(magazine, note));
        }

        public static string getCheckMagazineResult(string[] magazine, string[] note)
        {
            var magazineWords = new Dictionary<string, int>();

            foreach (var word in magazine)
            {
                if(!magazineWords.ContainsKey(word))
                {
                    magazineWords.Add(word, 0);
                }

                magazineWords[word] = magazineWords[word] + 1;
            }

            foreach (var word in note)
            {
                if (!magazineWords.ContainsKey(word))
                {
                    return "No";
                }

                if (magazineWords[word] < 1)
                {
                    return "No";
                }

                magazineWords[word] = magazineWords[word] - 1;
            }

            return "Yes";
        }
    }
}
