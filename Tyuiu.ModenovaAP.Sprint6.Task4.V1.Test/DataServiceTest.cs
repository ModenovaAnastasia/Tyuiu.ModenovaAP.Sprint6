using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ModenovaAP.Sprint6.Task4.V1.Lib;

namespace Tyuiu.ModenovaAP.Sprint6.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -1;
            int stop = 1;
            double[] valuearray = new double[stop - start + 1];
            valuearray[0] = -9.99;
            valuearray[1] = -2;
            valuearray[2] = 2.16;
            double[] wait = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(valuearray, wait);
        }
    }
}
