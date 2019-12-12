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

        public int NumJewelsInStones(string J, string S)
        {
            var jewels = J.ToCharArray();

            var stones = S.ToCharArray()
                          .GroupBy(x => x)
                          .ToDictionary(y => y.Key, y => y.Count());

            var count = jewels.Sum(j => stones[j]);
            return count;
        }
    }
}