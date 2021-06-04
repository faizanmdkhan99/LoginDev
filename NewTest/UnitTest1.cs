using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LoginDev;
namespace NewTest
{
    [TestClass]
    public class UnitTest1
    {
        Program obj = new Program();
        [DataRow("admin","pass123")]
   
        [TestMethod]
        public void TestMethod1(string user,string pass)
        {
            bool actual = obj.CheckDetails(user,pass);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
    }
}
