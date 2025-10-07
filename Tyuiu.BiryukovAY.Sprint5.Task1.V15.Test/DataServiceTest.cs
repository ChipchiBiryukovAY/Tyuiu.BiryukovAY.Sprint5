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
            var service = new DataService();
            string filePath = "OutPutFileTask1.txt";

            if (File.Exists(filePath))
                File.Delete(filePath);

            service.SaveToFileTextData(-5, 5);

            Assert.IsTrue(File.Exists(filePath));
        }
    }
}
