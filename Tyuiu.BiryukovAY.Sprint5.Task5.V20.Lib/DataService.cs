using System;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BiryukovAY.Sprint5.Task5.V20.Lib
{
    public class DataService : ISprint5Task5V20
    {
        public double LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);

            double sum = 0;
            int count = 0;

            char[] separators = new char[] { ' ', '\t', ',', ';', ':', '\n', '\r' };

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] numberStrings = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                foreach (string numberStr in numberStrings)
                {
                    try
                    {
                        string normalized = numberStr.Replace(',', '.');

                        if (double.TryParse(normalized, NumberStyles.Any, CultureInfo.InvariantCulture, out double number))
                        {
                            if (IsInteger(number) && number >= -10 && number <= 10)
                            {
                                sum += number;
                                count++;
                            }
                        }
                    }
                    catch (FormatException)
                    {
                        continue;
                    }
                }
            }

            if (count == 0)
                return 0;

            double average = sum / count;
            return Math.Round(average, 3);
        }

        private bool IsInteger(double number)
        {
            return Math.Abs(number - Math.Round(number)) < 0.000001;
        }
    }
}
