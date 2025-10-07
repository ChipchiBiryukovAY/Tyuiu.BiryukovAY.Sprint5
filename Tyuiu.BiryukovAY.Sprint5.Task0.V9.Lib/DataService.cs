using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BiryukovAY.Sprint5.Task0.V9.Lib
{
    public class DataService : ISprint5Task0V9
    {
        public string SaveToFileTextData(int x)
        {
            if (x == 1 || x == -1)
            {
                throw new ArgumentException("x не может быть равен 1 или -1 (деление на ноль)");
            }

            double num = Math.Pow(x, 3);
            double den = Math.Pow(x, 2) - 1;
            double y = num / den;

            string z = Math.Round(y, 3).ToString();
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            File.WriteAllText(path, z);

            return z;
        }
    }
}
