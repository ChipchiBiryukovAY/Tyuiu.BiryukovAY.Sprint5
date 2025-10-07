using System;
using System.IO;
using Tyuiu.BiryukovAY.Sprint5.Task0.V9.Lib;
namespace Tyuiu.BiryukovAY.Sprint5.Task0.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.BiryukovAY.Sprint5\Tyuiu.BiryukovAY.Sprint5.Task0.V9\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
