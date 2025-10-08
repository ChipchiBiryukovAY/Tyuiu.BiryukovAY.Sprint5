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
                throw new ArgumentException("x не может быть равен 0");

            double y = (4 - Math.Pow(x, 3)) / Math.Pow(x, 2);

            string tempPath = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            using (BinaryWriter writer = new BinaryWriter(File.Open(tempPath, FileMode.Create)))
            {
                writer.Write(y);
            }

            byte[] fileBytes = File.ReadAllBytes(tempPath);
            return Convert.ToBase64String(fileBytes);
        }
    }
}
