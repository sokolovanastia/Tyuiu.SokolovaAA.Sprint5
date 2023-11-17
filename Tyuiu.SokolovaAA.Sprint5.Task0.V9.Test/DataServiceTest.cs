using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SokolovaAA.Sprint5.Task0.V9.Lib;
using System.IO;
namespace Tyuiu.SokolovaAA.Sprint5.Task0.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Пользователи\nassok\source\repos\Tyuiu.SokolovaAA.Sprint5\Tyuiu.SokolovaAA.Sprint5.Task0.V9\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
