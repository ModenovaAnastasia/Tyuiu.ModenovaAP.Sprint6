using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ModenovaAP.Sprint6.Task5.V22.Lib;

namespace Tyuiu.ModenovaAP.Sprint6.Task5.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\1\source\repos\Tyuiu.ModenovaAP.Sprint6\Tyuiu.ModenovaAP.Sprint6.Task5.V22\bin\Debug\InPutFileTask5V22.txt";
            DataService ds = new DataService();
            double[] wait = new double[] { 12, 12.89, 35, 13.83, 12.76, 8.86 };
            double[] res = ds.LoadFromDataFile(path);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
