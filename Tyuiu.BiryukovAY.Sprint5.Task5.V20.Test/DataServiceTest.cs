using System;
using Tyuiu.BiryukovAY.Sprint5.Task5.V20.Lib;
namespace Tyuiu.BiryukovAY.Sprint5.Task5.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string tempFile = Path.Combine(Path.GetTempPath(), "testfile.txt");

            File.WriteAllLines(tempFile, new string[]
            {
                "5", "-3", "10", "0", "7", "-10", "2"
            });

            double result = ds.LoadFromDataFile(tempFile);

            double expected = 11.0 / 7.0;
            expected = Math.Round(expected, 3);
            Assert.AreEqual(expected, result);

            File.Delete(tempFile);
        }
    }
}
