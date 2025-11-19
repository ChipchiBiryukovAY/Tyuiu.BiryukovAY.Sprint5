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
                "3", "4", "5", "1" 
            });

            double result = ds.LoadFromDataFile(tempFile);

            Assert.AreEqual(3.25, result);

            File.Delete(tempFile);
        }
    }
}
