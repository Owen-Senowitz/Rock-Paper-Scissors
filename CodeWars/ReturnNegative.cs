using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    [TestFixture]
    public class ReturnNegativeTest
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(-42, ReturnNegative.MakeNegative(42));
        }
    }
    public static class ReturnNegative
    {
        public static int MakeNegative(int number)
        {
            // Code?
            if (number > 0)
                return number * -1;
            else
                return number;
        }
    }
}
