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

            string path1 = Path.Combine(Environment.CurrentDirectory, "OutPutFileTask1.txt");
            string path2 = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            if (File.Exists(path1)) File.Delete(path1);
            if (File.Exists(path2)) File.Delete(path2);

            string result = ds.SaveToFileTextData(-5, 5);

            FileInfo fileInfo1 = new FileInfo(path1);
            FileInfo fileInfo2 = new FileInfo(path2);

            bool fileExists = fileInfo1.Exists || fileInfo2.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
