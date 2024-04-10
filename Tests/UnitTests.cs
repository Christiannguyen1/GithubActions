using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above

        [Test]
        public void Subtract_Valid()
        {
            Assert.AreEqual(1, Program.Subtract("1", "2"));
            Assert.AreEqual(0, Program.Subtract("2", "2"));
            Assert.AreEqual(10, Program.Subtract("15", "5"));
        }

        [Test]
        public void Multiply_Valid()
        {
            Assert.AreEqual(1, Program.Multiply("1", "1"));
            Assert.AreEqual(0, Program.Multiply("1", "0"));
            Assert.AreEqual(15, Program.Multiply("5", "3"));
        }

        [Test]
        public void Divide_Valid()
        {
            Assert.AreEqual(1, Program.Divide("1", "1"));
            Assert.AreEqual(0, Program.Divide("0", "1"));
            Assert.AreEqual(5, Program.Divide("10", "2"));
        }

        [Test]
        public void Power_Valid()
        {
            Assert.AreEqual(1, Program.Power("1", "1"));
            Assert.AreEqual(1, Program.Power("10", "0"));
            Assert.AreEqual(8, Program.Power("2", "3"));
        }


    }
}
