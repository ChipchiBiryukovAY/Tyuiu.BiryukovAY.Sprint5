using System;
using System.IO;
using Tyuiu.BiryukovAY.Sprint5.Task3.V11.Lib;
namespace Tyuiu.BiryukovAY.Sprint5.Task3.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string resultPath = ds.SaveToFileTextData(3);

            Assert.IsTrue(File.Exists(resultPath));
            Assert.IsTrue(resultPath.Contains("OutPutFileTask3.bin"));
        }

        [TestMethod]
        public void SaveToFileTextData_ShouldReturnCorrectPath()
        {
            DataService ds = new DataService();
            string expectedPath = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            string resultPath = ds.SaveToFileTextData(3);

            Assert.AreEqual(expectedPath, resultPath);

        }
    }
}
