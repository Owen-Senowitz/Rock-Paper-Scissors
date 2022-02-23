using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    [TestFixture]
    public class NumberOfPeopleInTheBusTest
    {
        [Test]
        public void FirstTest()
        {
            List<int[]> peopleList = new List<int[]>() { new[] { 10, 0 }, new[] { 3, 5 }, new[] { 5, 8 } };
            Assert.AreEqual(5, NumberOfPeopleInTheBus.Number(peopleList));
        }
        [Test]
        public void SecondTest()
        {
            List<int[]> peopleList = new List<int[]>() { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 10 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 10 } };
            Assert.AreEqual(17, NumberOfPeopleInTheBus.Number(peopleList));
        }
        [Test]
        public void ThirdTest()
        {
            List<int[]> peopleList = new List<int[]>() { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 8 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 8 } };
            Assert.AreEqual(21, NumberOfPeopleInTheBus.Number(peopleList));
        }
    }
    public class NumberOfPeopleInTheBus
    {
        public static int Number(List<int[]> peopleListInOut)
        {
            int finalCount = 0;
            for (int i = 0; i < peopleListInOut.Count; i++)
            {
                finalCount += peopleListInOut[i][0];
                finalCount -= peopleListInOut[i][1];
            }
            return finalCount;
        }
    }
}



