using Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldSumCorrect()
        {
            Class1 class1 = new Class1();
            var total = class1.Sum(1, 1);
            Assert.AreEqual(total, 2);
        }

        [TestMethod]
        public void ShouldSubtractCorrect123()
        {
            Class1 class1 = new Class1();
            var total = class1.Subtract(1, 1);
            Assert.AreEqual(total, 0);
        }

        [TestMethod]
        public void ShouldSubtractCorrectAll()
        {
            Class1 class1 = new Class1() ;
            var total = class1.Subtract(1, 1);
            Assert.AreEqual(total, 0);
        }
    }
}
