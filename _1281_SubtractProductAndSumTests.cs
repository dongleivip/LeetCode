using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LeetCode
{
    public class SubtractProductAndSumTests
    {
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

        [Theory]
        [InlineData(234, 15)]
        [InlineData(4421, 21)]
        public void VerifySubtractProductAndSum(int num, int expected)
        {
            var result = SubtractProductAndSum_v2(num);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_Version2()
        {
            var num = 705;

            var result = SubtractProductAndSum_v2(num);

            Assert.Equal(-12, result);
        }

        public int SubtractProductAndSum_v2(int n)
        {
            var product = 1;
            var sum = 0;

            while (n != 0)
            {
                var digit = n % 10;

                product *= digit;
                sum += digit;

                n = (int)(n / 10);
            }

            return product - sum;
        }
    }
}