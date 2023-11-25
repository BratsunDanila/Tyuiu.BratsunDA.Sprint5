using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BratsunDA.Sprint5.Task7.V12.Lib;
using System.IO;

namespace Tyuiu.BratsunDA.Sprint5.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            string path = @"C:\Users\беброн\source\repos\Tyuiu.BratsunDA.Sprint5\Tyuiu.BratsunDA.Sprint5.Task7.V12\bin\Debug\OutPutDataFileTask7V12.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExist = fileinfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
