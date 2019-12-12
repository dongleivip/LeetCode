using System;
using System.Linq;
using Xunit;

namespace LeetCode
{
    public class _771_NumJewelsInStonesTests
    {
        [Fact]
        public void ShouldReturnThree()
        {
            var J = "aA";
            var S = "aAAbbbb";

            var result = NumJewelsInStones(J, S);
            Assert.Equal(3, result);
        }

        [Fact]
        public void ShouldReturnZero()
        {
            var J = "z";
            var S = "ZZ";

            var result = NumJewelsInStones(J, S);
            Assert.Equal(0, result);
        }

        public int NumJewelsInStones(string J, string S)
        {
            var jewels = J.ToCharArray();

            var stones = S.ToCharArray()
                          .GroupBy(x => x)
                          .ToDictionary(y => y.Key, y => y.Count());

            return jewels.Sum(j => stones.ContainsKey(j) ? stones[j] : 0);
        }

        [Fact]
        public void ShouldReturnThree_v2()
        {
            var J = "aA";
            var S = "aAAbbbb";

            var result = NumJewelsInStones_v2(J, S);
            Assert.Equal(3, result);
        }

        [Fact]
        public void ShouldReturnZero_v2()
        {
            var J = "z";
            var S = "ZZ";

            var result = NumJewelsInStones_v2(J, S);
            Assert.Equal(0, result);
        }

        public int NumJewelsInStones_v2(string J, string S)
        {
            var jewels = J.ToCharArray();
            var stones = S.ToCharArray();

            return jewels.Sum(j => stones.Count(s => s == j));
        }
    }
}