using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    [TestFixture]
    public class GreetTest
    {
        [Test]
        public void ShouldReturnHelloWorld()
        {
            Assert.AreEqual("hello world!", HelloWorld.greet());
        }
    }
    public static class HelloWorld
    {
        // Write a public static method "greet" that returns "hello world!"
        public static string greet()
        {
            return "hello world!";
        }
    }
}
