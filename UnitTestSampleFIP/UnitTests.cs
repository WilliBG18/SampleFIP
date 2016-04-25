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
            Assert.AreEqual(1000,  clientAcct.AcctBalance(1000));
            Assert.AreEqual(10000, clientAcct.GetSalary(10000));
            Assert.AreEqual(1000,  clientAcct.PercInvest(10000, .10));
            Assert.AreEqual(1000,  clientAcct.Perc401k(10000, .10));
            Assert.AreEqual(1000,  clientAcct.PercLISA(10000, .10));

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
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestGoogle()
        {
            StkPortfolio stkPortfolio = new Google();

            stkPortfolio.CurrStockVal(250.00);
            stkPortfolio.RandStkVal(.01, .05);
            stkPortfolio.ShowDayChange(250.00, .05, 1);
            stkPortfolio.ShowTtlChange(250.00, stkPortfolio.ShowDayChange(250.00, .05, 1));
            Assert.AreEqual(250.00, stkPortfolio.CurrStockVal(250.00));
            Assert.IsTrue(stkPortfolio.RandStkVal(.01, .05) <= .05);
            Assert.IsTrue(stkPortfolio.RandStkVal(.01, .05) >= .01);
            double change = stkPortfolio.ShowDayChange(250.00, .05, 1)[0];
            double value = stkPortfolio.ShowDayChange(250.00, .05, 1)[1];
            Assert.IsTrue(change <= 12.50);
            Assert.IsTrue(change >= -12.50);
            Assert.IsTrue(value <= 262.50);
            Assert.IsTrue(value >= 238.50);
            double ttlChange = stkPortfolio.ShowTtlChange(250.00, stkPortfolio.ShowDayChange(250.00, .05, 1))[0];
            double ttlValue = stkPortfolio.ShowTtlChange(250.00, stkPortfolio.ShowDayChange(250.00, .05, 1))[1];
            Assert.IsTrue(ttlChange <= 12.50);
            Assert.IsTrue(ttlChange >= -12.50);
            Assert.IsTrue(ttlValue <= 262.50);
            Assert.IsTrue(ttlValue >= 238.50);
        }
        [TestMethod]
        public void TestCurrVal()
        {
            StkPortfolio stkPortfolio = new Google();
            Assert.AreEqual(250.00, stkPortfolio.CurrStockVal(250.00));
        }
        [TestMethod]
        public void TestRandStkVal()
        {
            StkPortfolio stkPortfolio = new Google();
            stkPortfolio.RandStkVal(.01, .05);
            Assert.IsTrue(stkPortfolio.RandStkVal(.01, .05) <= .05);
            Assert.IsTrue(stkPortfolio.RandStkVal(.01, .05) >= .01);
        }
        [TestMethod]
        public void TestRandVal()
        {
            StkPortfolio stkPortfolio = new Google();
            stkPortfolio.RandVal(0, 1);
            Assert.IsTrue(stkPortfolio.RandVal(0, 1) <= 1);
            Assert.IsTrue(stkPortfolio.RandVal(0, 1) >= 0);
        }
        [TestMethod]
        public void TestDayChange()
        {
            StkPortfolio stkPortfolio = new Google();
            double change = stkPortfolio.ShowDayChange(250.00, .05, 1)[0];
            double value = stkPortfolio.ShowDayChange(250.00, .05, 1)[1];
            Assert.IsTrue(change <= 12.50);
            Assert.IsTrue(change >= -12.50);
            Assert.IsTrue(value <= 262.50);
            Assert.IsTrue(value >= 238.50);
        }
        [TestMethod]
        public void TestShowTtlChange()
        {
           
            StkPortfolio stkPortfolio = new Google();
            double ttlChange = stkPortfolio.ShowTtlChange(250.00, stkPortfolio.ShowDayChange(250.00, .05, 1))[0];
            double ttlValue = stkPortfolio.ShowTtlChange(250.00, stkPortfolio.ShowDayChange(250.00, .05, 1))[1];
            Assert.IsTrue(ttlChange <= 12.50);
            Assert.IsTrue(ttlChange >= -12.50);
            Assert.IsTrue(ttlValue <= 262.50);
            Assert.IsTrue(ttlValue >= 238.50);

        }
    }
}
