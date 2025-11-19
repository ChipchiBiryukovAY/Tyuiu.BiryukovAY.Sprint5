using System;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BiryukovAY.Sprint5.Task4.V17.Lib
{
    public class DataService : ISprint5Task4V17
    {
        public double LoadFromDataFile(string path)
        {
            string fileContent = File.ReadAllText(path);
            double x = double.Parse(fileContent, CultureInfo.InvariantCulture);

            double denominator = 3 * x;

            if (Math.Abs(denominator) < 0.000001)
            {
                throw new DivideByZeroException("Деление на ноль в выражении 2/(3x)");
            }

            double part = 2 / denominator;
            double sinValue = Math.Sin(part);
            double xSquared = Math.Pow(x, 2);
            double result = sinValue + xSquared;

            return Math.Round(result, 3);
        }
    }
}
