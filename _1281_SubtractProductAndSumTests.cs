using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LeetCode
{
    public class SubtractProductAndSumTests
    {
        [Theory]
        [InlineData(234, 15)]
        [InlineData(4421, 21)]
        public void VerifySubtractProductAndSum(int num, int expected)
        {
            var result = SubtractProductAndSum(num);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ShouldReturnOneForTwentyThree()
        {
            var num = 23;

            var result = SubtractProductAndSum(num);

            Assert.Equal(1, result);
        }

        public int SubtractProductAndSum(int n)
        {
            var list = new List<int>();

            var pow = 0;

            while (true)
            {
                var basic = (int)(n / Math.Pow(10, pow));
                if (basic < 1)
                {
                    break;
                }

                var digit = basic % 10;
                list.Add(digit);
                pow++;
            }

            var product = list.Aggregate((pre, next) => pre * next);
            var sum = list.Sum();

            return product - sum;
        }
    }
}