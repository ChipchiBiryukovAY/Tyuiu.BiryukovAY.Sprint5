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

            Console.WriteLine("x\t\tF(x)");
            lines.Add("x\t\tF(x)");
            Console.WriteLine("------------------------");
            lines.Add("------------------------");

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
            if (Math.Abs(x - 0.4) < 0.000001)
                return 0;

            return (Math.Cos(x) / (x - 0.4)) + (Math.Sin(x) * 8 * x) + 2;
        }
    }
}
