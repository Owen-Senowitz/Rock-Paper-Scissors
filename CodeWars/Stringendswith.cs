using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    [TestFixture]
    public class StringendswithTest
    {
        private static object[] sampleTestCases = new object[]
        {
      new object[] {"samurai", "ai", true},
      new object[] {"sumo", "omo", false},
      new object[] {"ninja", "ja", true},
      new object[] {"sensei", "i", true},
      new object[] {"samurai", "ra", false},
      new object[] {"abc", "abcd", false},
      new object[] {"abc", "abc", true},
      new object[] {"abcabc", "bc", true},
      new object[] {"ails", "fails", false},
      new object[] {"fails", "ails", true},
      new object[] {"this", "fails", false},
      new object[] {"abc", "", true},
      new object[] {":-)", ":-(", false},
      new object[] {"!@#$%^&*() :-)", ":-)", true},
      new object[] {"abc\n", "abc", false},
        };

        [Test, TestCaseSource("sampleTestCases")]
        public void SampleTest(string str, string ending, bool expected)
        {
            Assert.AreEqual(expected, Stringendswith.Solution(str, ending));
        }
    }
    public class Stringendswith
    {
        public static bool Solution(string str, string ending)
        {
            // TODO: complete
            return str.EndsWith(ending);
        }
    }
}
