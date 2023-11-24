using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BratsunDA.Sprint5.Task4.V20.Lib;
using System.IO;

namespace Tyuiu.BratsunDA.Sprint5.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V20.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExist = fileinfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
