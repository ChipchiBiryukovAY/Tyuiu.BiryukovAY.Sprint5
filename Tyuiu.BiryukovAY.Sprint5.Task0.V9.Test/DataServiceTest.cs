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
            DataService ds = new DataService();

            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            string result = ds.SaveToFileTextData(3);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
