﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SokolovaAA.Sprint5.Task2.V12.Lib;
namespace Tyuiu.SokolovaAA.Sprint5.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Пользователи\nassok\source\repos\Tyuiu.SokolovaAA.Sprint5\Tyuiu.SokolovaAA.Sprint5.Task2.V12\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
