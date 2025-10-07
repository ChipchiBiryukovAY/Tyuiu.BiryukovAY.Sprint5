using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BiryukovAY.Sprint5.Task1.V15.Lib
{
    public class DataService : ISprint5Task1V15
    {
        public string SaveToFileTextData(int start, int end)
        {
            List<string> lines = new List<string>();

            lines.Add("x\t\tF(x)");
            lines.Add("------------------------");

            for (int x = start; x <= end; x++)
            {
                double fx = CalculateFx(x);
                string line = $"{x}\t\t{Math.Round(fx, 2)}";
                lines.Add(line);
            }

            string path = Path.Combine(Directory.GetCurrentDirectory(), "OutPutFileTask1.txt");
            File.WriteAllLines(path, lines);

            return "Функция протабулирована успешно";
        }

        private double CalculateFx(int x)
        {
            if (x == 0.4)
                return 0;

            return (Math.Cos(x) / (x - 0.4)) + (Math.Sin(x) * 8 * x) + 2;
        }
    }
}