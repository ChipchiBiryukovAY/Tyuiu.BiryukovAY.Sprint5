using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BiryukovAY.Sprint5.Task3.V11.Lib
{
    public class DataService : ISprint5Task3V11
    {
        public string SaveToFileTextData(int x)
        {
            if (x == 0)
                throw new ArgumentException("x не может быть равен 0 (деление на ноль)");

            double numerator = 4 - Math.Pow(x, 3);
            double denominator = Math.Pow(x, 2);
            double y = numerator / denominator;
            double roundedY = Math.Round(y, 3);

            string fileName = "OutPutFileTask3.bin";
            string tempPath = Path.Combine(Path.GetTempPath(), fileName);

            using (BinaryWriter writer = new BinaryWriter(File.Open(tempPath, FileMode.Create)))
            {
                writer.Write(roundedY);
            }

            return File.ReadAllBytes(tempPath);
        }
    }
}
