using System;
using Tyuiu.BiryukovAY.Sprint5.Task4.V17.Lib;
namespace Tyuiu.BiryukovAY.Sprint5.Task4.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string tempFile = Path.Combine(Path.GetTempPath(), "testfile.txt");
            File.WriteAllText(tempFile, "4.68"); 

            double result = ds.LoadFromDataFile(tempFile);

            double expected = Math.Sin(2.0 / (3 * 4.68)) + Math.Pow(4.68, 2);
            expected = Math.Round(expected, 3);
            Assert.AreEqual(expected, result);

            File.Delete(tempFile);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void LoadFromDataFile_WithZeroValue()
        {
            DataService ds = new DataService();
            string tempFile = Path.Combine(Path.GetTempPath(), "testfile.txt");
            File.WriteAllText(tempFile, "0");

            ds.LoadFromDataFile(tempFile);

            File.Delete(tempFile);
        }
    }
}
