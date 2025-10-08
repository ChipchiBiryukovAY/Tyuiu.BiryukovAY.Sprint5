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

            string result = ds.SaveToFileTextData(3);

            string expected = "-2,556";
            Assert.AreEqual(expected, result);

        }
    }
}
