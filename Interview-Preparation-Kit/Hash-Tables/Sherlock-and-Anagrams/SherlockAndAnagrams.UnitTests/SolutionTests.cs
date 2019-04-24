using System;
using Xunit;

namespace SherlockAndAnagrams.UnitTests
{
    public class SolutionTests
    {
        public class TheSherlockAndAnagramsMethod
        {
            [Theory]
            [InlineData("abba", 4)]
            [InlineData("abcd", 0)]
            [InlineData("ifailuhkqq", 3)]
            [InlineData("kkkk", 10)]
            [InlineData("cdcd", 5)]
            [InlineData("dbcfibibcheigfccacfegicigcefieeeeegcghggdheichgafhdigffgifidfbeaccadabecbdcgieaffbigffcecahafcafhcdg", 1464)]
            [InlineData("dfcaabeaeeabfffcdbbfaffadcacdeeabcadabfdefcfcbbacadaeafcfceeedacbafdebbffcecdbfebdbfdbdecbfbadddbcec", 2452)]
            [InlineData("gjjkaaakklheghidclhaaeggllagkmblhdlmihmgkjhkkfcjaekckaafgabfclmgahmdebjekaedhaiikdjmfbmfbdlcafamjbfe", 873)]
            [InlineData("fdbdidhaiqbggqkhdmqhmemgljaphocpaacdohnokfqmlpmiioedpnjhphmjjnjlpihmpodgkmookedkehfaceklbljcjglncfal", 585)]
            [InlineData("bcgdehhbcefeeadchgaheddegbiihehcbbdffiiiifgibhfbchffcaiabbbcceabehhiffggghbafabbaaebgediafabafdicdhg", 1305)]
            [InlineData("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", 166650)]
            [InlineData("mhmgmbbccbbaffhbncgndbffkjbhmkfncmihhdhcebmchnfacdigflhhbekhfejblegakjjiejeenibemfmkfjbkkmlichlkbnhc", 840)]
            [InlineData("fdacbaeacbdbaaacafdfbbdcefadgfcagdfcgbgeafbfbggdedfbdefdbgbefcgdababafgffedbefdecbaabdaafggceffbacgb", 2134)]
            [InlineData("bahdcafcdadbdgagdddcidaaicggcfdbfeeeghiibbdhabdhffddhffcdccfdddhgiceciffhgdibfdacbidgagdadhdceibbbcc", 1571)]
            [InlineData("dichcagakdajjhhdhegiifiiggjebejejciaabbifkcbdeigajhgfcfdgekfajbcdifikafkgjjjfefkdbeicgiccgkjheeiefje", 1042)]
            public void ComputesCorrectResponse(string s, int result)
            {
                Assert.Equal(Solution.sherlockAndAnagrams(s), result);
            }
        }
    }
}
