using System;
using System.IO;
using Tyuiu.BiryukovAY.Sprint5.Task2.V25.Lib;
namespace Tyuiu.BiryukovAY.Sprint5.Task2.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] testArray = new int[3, 3]
            {
                { 4, 8, 5 },
                { 1, 4, 2 },
                { 4, 9, 9 }
            };

            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            if (File.Exists(filePath))
                File.Delete(filePath);

            string result = ds.SaveToFileTextData(testArray);

            Assert.IsTrue(File.Exists(filePath));
            string expectedResult = "4;8;0\n0;4;2\n4;0;0";
            Assert.AreEqual(expectedResult, result);
        }
    }
}
