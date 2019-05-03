using System;
using System.Collections.Generic;
using System.Numerics;

namespace CountTriplets
{
    public static class Solution
    {
        public static long countTriplets(List<long> arr, long r)
        {
            if (arr.Count < 3)
            {
                return 0;
            }

            var occurrenceCounts = new Dictionary<BigInteger, BigInteger>();
            var pairCounts = new Dictionary<Tuple<BigInteger, BigInteger>, BigInteger>();
            BigInteger tripletCount = 0;

            for (int i = arr.Count - 1; i >= 0; i--)
            {
                var currentNumber = arr[i];
                BigInteger firstFollowXInTriplet = r * currentNumber;
                BigInteger secondFollowXInTriplet = r * firstFollowXInTriplet;

                if (ExistsPairThatCompletesTriplet(pairCounts, firstFollowXInTriplet, secondFollowXInTriplet))
                {
                    tripletCount += GetPairCount(pairCounts, firstFollowXInTriplet, secondFollowXInTriplet);
                }

                if (!LastNumberInArray(i, arr))
                {
                    var pairToAdd = new Tuple<BigInteger, BigInteger>(currentNumber, firstFollowXInTriplet);
                    
                    pairCounts.EnsureExists(pairToAdd)[pairToAdd] =
                        pairCounts[pairToAdd] +
                        occurrenceCounts.EnsureExists(firstFollowXInTriplet)[firstFollowXInTriplet];
                }

                occurrenceCounts.EnsureExists(currentNumber)[currentNumber]++;
            }

            return (long)tripletCount;
        }

        private static bool ExistsPairThatCompletesTriplet(
            Dictionary<Tuple<BigInteger, BigInteger>, BigInteger> pairs,
            BigInteger firstFollowingInTriplet,
            BigInteger secondFollowingInTriplet)
        {
            return pairs.ContainsKey(new Tuple<BigInteger, BigInteger>(firstFollowingInTriplet, secondFollowingInTriplet));
        }

        private static BigInteger GetPairCount(
            Dictionary<Tuple<BigInteger, BigInteger>, BigInteger> pairs,
            BigInteger firstFollowingInTriplet,
            BigInteger secondFollowingInTriplet)
        {
            return pairs[new Tuple<BigInteger, BigInteger>(firstFollowingInTriplet, secondFollowingInTriplet)];
        }

        private static bool LastNumberInArray(int i, List<long> arr)
        {
            return i == arr.Count - 1;
        }

        private static Dictionary<Tuple<BigInteger, BigInteger>, BigInteger> EnsureExists(
             this Dictionary<Tuple<BigInteger, BigInteger>, BigInteger> pairs,
             Tuple<BigInteger, BigInteger> pair)
        {
            if (!pairs.ContainsKey(pair))
                {
                    pairs.Add(pair, 0);
                }

            return pairs;
        }

        private static Dictionary<BigInteger, BigInteger> EnsureExists(
            this Dictionary<BigInteger, BigInteger> occurrences,
            BigInteger value)
        {
            if (!occurrences.ContainsKey(value))
            {
                occurrences.Add(value, 0);
            }

            return occurrences;
        }
    }
}
