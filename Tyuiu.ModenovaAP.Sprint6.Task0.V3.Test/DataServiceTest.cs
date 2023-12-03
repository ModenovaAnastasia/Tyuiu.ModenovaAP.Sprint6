using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ModenovaAP.Sprint6.Task0.V3.Lib;

namespace Tyuiu.ModenovaAP.Sprint6.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(2);
            double wait = 4.571;
            Assert.AreEqual(wait, res);
        }
    }
}
