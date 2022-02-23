using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    [TestFixture]
    public class AbbreviateaTwoWordNameTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("S.H", AbbreviateaTwoWordName.AbbrevName("Sam Harris"));
            Assert.AreEqual("P.F", AbbreviateaTwoWordName.AbbrevName("Patrick Feenan"));
            Assert.AreEqual("E.C", AbbreviateaTwoWordName.AbbrevName("Evan Cole"));
            Assert.AreEqual("P.F", AbbreviateaTwoWordName.AbbrevName("P Favuzzi"));
            Assert.AreEqual("D.M", AbbreviateaTwoWordName.AbbrevName("David Mendieta"));
        }
    }
    public class AbbreviateaTwoWordName
    {
        public static string AbbrevName(string name)
        {
            string[] buf = name.Split(' ');

            var firstName = buf.First();
            var lastName = buf.Last();

            var oneUpper = Char.ToUpper(firstName.First());
            var twoUpper = Char.ToUpper(lastName.First());

            return $"{oneUpper}.{twoUpper}";
        }
    }
}