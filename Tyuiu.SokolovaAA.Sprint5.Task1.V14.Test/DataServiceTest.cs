﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SokolovaAA.Sprint5.Task1.V14.Lib;
namespace Tyuiu.SokolovaAA.Sprint5.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Пользователи\nassok\source\repos\Tyuiu.SokolovaAA.Sprint5\Tyuiu.SokolovaAA.Sprint5.Task1.V14\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
