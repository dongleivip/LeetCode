using System;
using System.Collections.Generic;
using Xunit;

namespace LeetCode
{
    public class TwoSumTests
    {
        [Fact]
        public void ShouldFindTheCorrectIndexs()
        {
            var nums = new int[] { 5, 6, 5, 7 };
            var sum = 13;

            var result = TwoSum(nums, sum);

            Assert.Equal(1, result[0]);
            Assert.Equal(3, result[1]);
        }

        public int[] TwoSum(int[] nums, int target)
        {
            var dic = new Dictionary<int, int>();

            for (int i = 0; i <= nums.Length; i++)
            {
                var part = target - nums[i];
                if (dic.ContainsKey(part))
                {
                    return new int[] { dic[part], i };
                }
                dic[nums[i]] = i;
            }

            throw new Exception("Not found");
        }
    }
}
