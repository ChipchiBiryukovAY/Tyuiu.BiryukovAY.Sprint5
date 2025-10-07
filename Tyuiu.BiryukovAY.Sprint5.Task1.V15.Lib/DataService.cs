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
                Console.WriteLine(line); 
            }

            string fileName = "OutPutFileTask1.txt";
            string path = Path.Combine(Environment.CurrentDirectory, fileName);

            try
            {
                File.WriteAllLines(path, lines);
                return $"Функция протабулирована успешно. Файл: {path}";
            }
            catch (UnauthorizedAccessException)
            {
                string tempPath = Path.Combine(Path.GetTempPath(), fileName);
                File.WriteAllLines(tempPath, lines);
                return $"Функция протабулирована успешно. Файл сохранен в Temp: {tempPath}";
            }
        }

        private double CalculateFx(int x)
        {
            // Проверка деления на ноль
            double denominator = x - 0.4;
            if (Math.Abs(denominator) < 0.000001)
                return 0;

            return (Math.Cos(x) / denominator) + (Math.Sin(x) * 8 * x) + 2;
        }
    }
    
}