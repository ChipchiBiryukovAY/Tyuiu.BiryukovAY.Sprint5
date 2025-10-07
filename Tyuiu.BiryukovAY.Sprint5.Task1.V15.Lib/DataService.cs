using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BiryukovAY.Sprint5.Task1.V15.Lib
{
    public class DataService : ISprint5Task1V15
    {
        public string SaveToFileTextData(int start, int end)
        {
            List<string> lines = new List<string>();
            StringBuilder resultBuilder = new StringBuilder();

            for (int x = start; x <= end; x++)
            {
                double fx = CalculateFx(x);
                string roundedValue = Math.Round(fx, 2).ToString().Replace(",", ".");

                if (x != start)
                    resultBuilder.Append("\\n");

                resultBuilder.Append(roundedValue);
                lines.Add($"{x}\t\t{roundedValue}");
            }

            string path = Path.Combine(Environment.CurrentDirectory, "OutPutFileTask1.txt");
            File.WriteAllLines(path, lines);

            return resultBuilder.ToString();
        }

        private double CalculateFx(int x)
        {
            double denominator = x - 0.4;
            if (Math.Abs(denominator) < 0.000001)
                return 0;

            return (Math.Cos(x) / denominator) + (Math.Sin(x) * 8 * x) + 2;
        }
    }
    
}