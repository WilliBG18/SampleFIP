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
            clientAcct.PercInvest(10000, .10);
            Assert.AreEqual(1000, clientAcct.AcctBalance(1000));
            Assert.AreEqual(10000, clientAcct.GetSalary(10000));
            Assert.AreEqual(1000, clientAcct.PercInvest(10000, .10));
            Assert.AreEqual(1000, clientAcct.Perc401k(10000, .10));
            Assert.AreEqual(1000, clientAcct.PercLISA(10000, .10));

        }
        [TestMethod]
        public void TestAcctBalance()
        {
            Portfolio clientAcct = new ClientAcct();
            clientAcct.AcctBalance(5000);
            Assert.AreEqual(5000, clientAcct.AcctBalance(5000));
        }
        [TestMethod]
        public void TestGetSalary()
        {
            Portfolio clientAcct = new ClientAcct();
            clientAcct.GetSalary(50000);
            Assert.AreEqual(50000, clientAcct.GetSalary(50000));
        }
        [TestMethod]
        public void TestPercInvest()
        {
            Portfolio clientAcct = new ClientAcct();
            clientAcct.PercInvest(50000, .05);
            Assert.AreEqual(2500, clientAcct.PercInvest(50000, .05));
        }
        [TestMethod]
        public void TestPerc401k()
        {
            Portfolio clientAcct = new ClientAcct();
            clientAcct.PercInvest(50000, .05);
            Assert.AreEqual(2500, clientAcct.PercInvest(50000, .05));
        }
        [TestMethod]
        public void TestPercLISA()
        {
            Portfolio clientAcct = new ClientAcct();
            clientAcct.PercInvest(50000, .05);
            Assert.AreEqual(2500, clientAcct.PercInvest(50000, .05));
        }
    }
}
