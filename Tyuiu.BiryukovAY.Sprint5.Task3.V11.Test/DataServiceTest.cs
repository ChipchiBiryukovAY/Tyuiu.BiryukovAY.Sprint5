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
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            if (File.Exists(path))
                File.Delete(path);

            string result = ds.SaveToFileTextData(3);

            Assert.IsTrue(File.Exists(path));
            Assert.AreEqual("-2,556", result);
        }
    }
}
