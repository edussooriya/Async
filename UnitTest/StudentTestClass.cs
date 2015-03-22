using System;
using Async;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class StudentTestClass
    {
        [TestMethod]
        public void TestMethodWidthdraw()
        {
            double current_balance = 0;
            int widthdraw = 100;
            double expected = 0;

            Async.Student student = new Student(12,"Asoka");
            student.Widthdraw(widthdraw);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void DepositFirstTime()
        {
           double amount = 100;
           Async.Student student = new Student(12, "Asoka");
           double actual = student.Diposit(amount);
           Assert.AreEqual(actual, amount);
        }

        [TestMethod]
        public void Deposit()
        {
            double amount = 100;
            double balance = 1000;
            double expected = 1100;
            Async.Student student = new Student(12, "Asoka");
            student.Diposit(balance);
            double actual = student.Diposit(amount);
            Assert.AreEqual(actual, expected);
        }

       
    }
}
