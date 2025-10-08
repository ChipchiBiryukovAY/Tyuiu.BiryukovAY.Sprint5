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

            string resultString = ds.SaveToFileTextData(3);

            string expectedBase64 = "ppvEILByBMA=";
            Assert.AreEqual(expectedBase64, resultString);

            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            Assert.IsTrue(File.Exists(filePath));

            byte[] fileBytes = File.ReadAllBytes(filePath);
            string fileBase64 = Convert.ToBase64String(fileBytes);
            Assert.AreEqual(expectedBase64, fileBase64);

        }
    }
}
