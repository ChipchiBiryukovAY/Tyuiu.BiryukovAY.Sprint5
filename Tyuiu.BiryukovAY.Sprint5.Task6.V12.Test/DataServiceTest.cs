using System;
using Tyuiu.BiryukovAY.Sprint5.Task6.V12.Lib;
namespace Tyuiu.BiryukovAY.Sprint5.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string tempFile = Path.Combine(Path.GetTempPath(), "testfile.txt");
            File.WriteAllText(tempFile, "анна");

            int result = ds.LoadFromDataFile(tempFile);

            Assert.AreEqual(1, result);

            File.Delete(tempFile);
        }
    }
}
