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

            byte[] result = ds.SaveToFileTextData(3);
            string base64Result = System.Convert.ToBase64String(result);

            string expectedBase64 = "ppvEILByBMA=";
            Assert.AreEqual(expectedBase64, base64Result);

        }
    }
