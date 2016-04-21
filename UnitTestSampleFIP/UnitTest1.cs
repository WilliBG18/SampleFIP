using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleFIP;

namespace UnitTestSampleFIP
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestClientAcct()
        {
            Portfolio clientAcct = new ClientAcct();
           
            clientAcct.AcctBalance(1000);
            clientAcct.GetSalary(10000);
            clientAcct.PercInvest(.10);
            Assert.AreEqual(1000, clientAcct.AcctBalance(1000));
            Assert.AreEqual(10000, clientAcct.GetSalary(10000));
            Assert.AreEqual(.10, clientAcct.PercInvest(.10));

        }
    }
}
