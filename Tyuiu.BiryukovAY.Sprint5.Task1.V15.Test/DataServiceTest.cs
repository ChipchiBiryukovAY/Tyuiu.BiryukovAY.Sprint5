using System;
using System.IO;
using Tyuiu.BiryukovAY.Sprint5.Task1.V15.Lib;
namespace Tyuiu.BiryukovAY.Sprint5.Task1.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            string result = ds.SaveToFileTextData(-5, 5);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
