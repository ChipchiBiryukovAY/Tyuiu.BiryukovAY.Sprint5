using System;
using System.IO;
using Tyuiu.BiryukovAY.Sprint5.Task1.V15.Lib;
namespace Tyuiu.BiryukovAY.Sprint5.Task1.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string result = ds.SaveToFileTextData(-5, 5);

            string expected = "-36,41\n-22,07\n5,68\n16,72\n8,35\n-0,5\n9,63\n16,29\n5,01\n-22,4\n-36,3";
            Assert.AreEqual(expected, result);
        }
    }
}
