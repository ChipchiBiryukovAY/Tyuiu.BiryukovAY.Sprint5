using System;
using Tyuiu.BiryukovAY.Sprint5.Task7.V29.Lib;
namespace Tyuiu.BiryukovAY.Sprint5.Task7.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string tempFile = Path.Combine(Path.GetTempPath(), "test_input.txt");
            File.WriteAllText(tempFile, "у меня есть 5");

            string resultPath = ds.LoadDataAndSave(tempFile);
            string resultText = File.ReadAllText(resultPath);

            string expected = "у меня есть";
            Assert.AreEqual(expected, resultText);

            File.Delete(tempFile);
            File.Delete(resultPath);
        }
    }
}
