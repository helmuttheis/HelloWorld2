using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "Hallo world!";

            string output = toUpper.run(input);
            Assert.AreEqual(output, input,"not correct");
        }
    }
}
