using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ModenovaAP.Sprint6.Task7.V12.Lib;

namespace Tyuiu.ModenovaAP.Sprint6.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\1\source\repos\Tyuiu.ModenovaAP.Sprint6\Tyuiu.ModenovaAP.Sprint6.Task7.V12\bin\Debug\OutPutFileTask7V12.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
