using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.BratsunDA.Sprint5.Task2.V14.Lib;

namespace Tyuiu.BratsunDA.Sprint5.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            string path = @"C:\Users\беброн\source\repos\Tyuiu.BratsunDA.Sprint5\Tyuiu.BratsunDA.Sprint5.Task2.V14\bin\Debug\OutPutFileTask2.csv";

            FileInfo fileinfo = new FileInfo(path);
            bool fileexists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileexists);
        }
    }
}
