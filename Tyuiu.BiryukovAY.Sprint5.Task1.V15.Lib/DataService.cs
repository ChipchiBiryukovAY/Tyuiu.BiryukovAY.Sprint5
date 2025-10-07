using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BiryukovAY.Sprint5.Task1.V15.Lib
{
    public class DataService : ISprint5Task1V15
    {
        public string SaveToFileTextData(int start, int stop)
        {
            List<string> lines = new List<string>();

            string header = "x\t\tF(x)";
            string separator = "------------------------";

            Console.WriteLine(header);
            Console.WriteLine(separator);

            lines.Add(header);
            lines.Add(separator);

            for (int x = start; x <= stop; x++)
            {
                double fx = CalculateFx(x);
                string line = $"{x}\t\t{fx:F2}";
                Console.WriteLine(line);
                lines.Add(line);
            }

            File.WriteAllLines("OutPutFileTask1.txt", lines);
        }

        private double CalculateFx(int x)
        {
            double denominator = x - 0.4;
            if (Math.Abs(denominator) < 0.000001)
                return 0;

            double part1 = Math.Cos(x) / denominator;
            double part2 = Math.Sin(x) * 8 * x;
            return part1 + part2 + 2;
        }
    }
}
