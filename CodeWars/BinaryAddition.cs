using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    [TestFixture]
    public class AddBinaryTest
    {
        [Test]
        public void TestExample()
        {
            Assert.AreEqual("11", BinaryAddition.AddBinary(1, 2), "Should return \"11\" for 1 + 2");
        }
    }
    public static class BinaryAddition
    {
        public static string AddBinary(int a, int b)
        {
            int num = a + b;
            string binary = Convert.ToString(num, 2);
            return binary;
        }
    }
}
