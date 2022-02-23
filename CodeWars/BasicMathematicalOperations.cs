using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class BasicMathematicalOperationsTest
    {
        [Test]
        public void StaticTests()
        {
            Assert.AreEqual(BasicMathematicalOperations.basicOp('+', 4, 7), 11);
            Assert.AreEqual(BasicMathematicalOperations.basicOp('-', 15, 18), -3);
            Assert.AreEqual(BasicMathematicalOperations.basicOp('*', 5, 5), 25);
            Assert.AreEqual(BasicMathematicalOperations.basicOp('/', 49, 7), 7);
        }
    }
    public static class BasicMathematicalOperations
    {
        public static double basicOp(char operation, double value1, double value2)
        {
            if (operation == '+')
                return value1 + value2;

            else if (operation == '-')
                return value1 - value2;

            else if (operation == '*')
                return value1 * value2;

            else if (operation == '/')
                return value1 / value2;
            return -1;
        }
    }
}
