using NUnit.Framework;
using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork12;

namespace MyUnitTests
{
    [TestFixture]

    public class UnitTest1
    {

        [TestCase(1, "January")]
        [TestCase(2, "February")]
        [TestCase(3, "March")]
        [TestCase(4, "April")]
        [TestCase(5, "May")]
        [TestCase(6, "June")]
        [TestCase(7, "July")]
        [TestCase(8, "August")]
        [TestCase(9, "September")]
        [TestCase(10, "October")]
        [TestCase(11, "November")]
        [TestCase(12, "December")]
        public void TestReturnMonth(int numMonth, string expRes)
        {
            string actRes = new Month(true).ReturnMonth(numMonth);
            Assert.AreEqual(expRes, actRes);

        }
        
        [TestCase(5, 1)]
        [TestCase(366, 12)]
        [TestCase(97, 4)]
        [TestCase(60, 2)]

        public void TestReturnNumberOfMonthLeapYear(int numMonth, int expRes)
        {
            int actRes = new Month(true).ReturnNumberOfMonth(numMonth);
            Assert.AreEqual(expRes, actRes);

        }

        [TestCase(5, 1)]
        [TestCase(365, 12)]
        [TestCase(97, 4)]
        [TestCase(60, 3)]

        public void TestReturnNumberOfMonthNotLeapYear(int numMonth, int expRes)
        {
            int actRes = new Month(false).ReturnNumberOfMonth(numMonth);
            Assert.AreEqual(expRes, actRes);
        }
        
        [TestCase(100, "10 April")]
        [TestCase(365, "31 December")]
        public void TestReturnDateLeapYear(int day, string expRes)
        {
            string actRes = new Month(false).ReturnDate(day);
            Assert.AreEqual(expRes, actRes);
        }

        [TestCase(101, "10 April")]
        [TestCase(366, "31 December")]
        [TestCase(60, "29 February")]
        public void TestReturnDateNotLeapYear(int day, string expRes)
        {
            string actRes = new Month(true).ReturnDate(day);
            Assert.AreEqual(expRes, actRes);
        }




    }
}
