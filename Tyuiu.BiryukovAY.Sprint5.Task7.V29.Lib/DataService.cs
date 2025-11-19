using System;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BiryukovAY.Sprint5.Task7.V29.Lib
{
    public class DataService : ISprint5Task7V29
    {
        public string LoadDataAndSave(string path)
        {
            string text = File.ReadAllText(path);

            string pattern = @"\s?\b\d\b\s?";
            string resultText = Regex.Replace(text, pattern, " ");

            resultText = Regex.Replace(resultText, @"\s+", " ");

            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V29.txt");

            File.WriteAllText(outputPath, resultText);

            return outputPath;
        }
    }
}
