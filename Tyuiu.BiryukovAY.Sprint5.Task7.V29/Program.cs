using System;
using System.Text.RegularExpressions;
using Tyuiu.BiryukovAY.Sprint5.Task7.V29.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Удаление однозначных чисел из файла");
        Console.WriteLine("==========================================");

        string inputPath = @"C:\DataSprint5\InPutDataFileTask7V29.txt";

        try
        {
            if (!File.Exists(inputPath))
            {
                Console.WriteLine($"Файл не найден: {inputPath}");
                Console.WriteLine("Создайте папку C:\\DataSprint5\\ и скопируйте туда файл");
            }
            else
            {
                string outputPath = LoadDataAndSave(inputPath);
                Console.WriteLine($"Обработанный файл: {outputPath}");

                Console.WriteLine("\nИсходный текст:");
                Console.WriteLine(File.ReadAllText(inputPath));
                Console.WriteLine("\nРезультат:");
                Console.WriteLine(File.ReadAllText(outputPath));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

        Console.ReadKey();
    }

    static string LoadDataAndSave(string path)
    {
        string text = File.ReadAllText(path);

        string resultText = Regex.Replace(text, @"\s?\b\d\b\s?", " ");

        resultText = Regex.Replace(resultText, @"\s+", " ").Trim();

        string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V29.txt");
        File.WriteAllText(outputPath, resultText);

        return outputPath;
    }
}