using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BratsunDA.Sprint5.Task1.V1.Lib;
using System.IO;

namespace Tyuiu.BratsunDA.Sprint5.Task1.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\беброн\source\repos\Tyuiu.BratsunDA.Sprint5\Tyuiu.BratsunDA.Sprint5.Task1.V1\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExist = fileinfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
