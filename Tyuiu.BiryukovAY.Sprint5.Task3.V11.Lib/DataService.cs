using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BiryukovAY.Sprint5.Task3.V11.Lib
{
    public class DataService : ISprint5Task3V11
    {
        public string SaveToFileTextData(int x)
        {
            double y = (4 - Math.Pow(x, 3)) / Math.Pow(x, 2);
            double roundedY = Math.Round(y, 3);

            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                writer.Write(roundedY);
            }

            return filePath;
        }
    }
}