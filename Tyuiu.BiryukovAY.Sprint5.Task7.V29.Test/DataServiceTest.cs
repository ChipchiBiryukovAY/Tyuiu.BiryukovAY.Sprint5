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
            File.WriteAllText(tempFile, "1 2 3 4 5 6 7 8 9 0");

            string resultPath = ds.LoadDataAndSave(tempFile);
            string resultText = File.ReadAllText(resultPath);

            string expected = "          ";
            Assert.AreEqual(expected, resultText);

            File.Delete(tempFile);
            File.Delete(resultPath);
        }
    }
}
