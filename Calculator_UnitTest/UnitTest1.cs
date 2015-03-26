using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace Calculator_UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void add_test()
        {
            var test_object = new Program();
            int expected = 5;
            int actual = test_object.add(2, 3);
            Assert.AreEqual<int>(expected, actual, "Did not get the right value from add method");
        }
        [TestMethod]
        public void subtract_test()
        {
            var test_object = new Program();
            int expected = 3;
            int actual = test_object.subtract(6, 3);
            Assert.AreEqual<int>(expected, actual, "Did not get the right value from subtract method");
        }
        [TestMethod]
        public void multiply_test()
        {
            var test_object = new Program();
            int expected = 15;
            int actual = test_object.multiply(5, 3);
            Assert.AreEqual<int>(expected, actual, "Did not get the right value from multiply method :)");
        }
        [TestMethod]
        public void divide_test()
        {
            var test_object = new Program();
            int expected = 3;
            int actual = test_object.divide(9, 3);
            Assert.AreEqual<int>(expected, actual, "Did not get the right value from divide method");
        }
    }
}
