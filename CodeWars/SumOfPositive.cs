using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    [TestFixture]
    public class SumOfPositiveTest
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = 15)]
        [TestCase(new int[] { 1, -2, 3, 4, 5 }, ExpectedResult = 13)]
        [TestCase(new int[] { -1, 2, 3, 4, -5 }, ExpectedResult = 9)]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, ExpectedResult = 0)]
        public static int ExampleTest(int[] arr)
        {
            return SumOfPositive.PositiveSum(arr);
        }
    }
    public class SumOfPositive
    {
        public static int PositiveSum(int[] arr)
        {
            // Your code here
            int sum = 0;
            foreach(int i in arr)
            {
                if(i > 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}