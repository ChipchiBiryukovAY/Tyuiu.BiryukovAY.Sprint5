using System;
using Tyuiu.BiryukovAY.Sprint5.Task7.V29.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        string inputPath = @"C:\DataSprint5\InPutDataFileTask7V29.txt";

        Console.WriteLine("Удаление однозначных чисел из файла");
        Console.WriteLine($"Входной файл: {inputPath}");
        Console.WriteLine("==========================================");

        try
        {
            if (!File.Exists(inputPath))
            {
                Console.WriteLine($"Ошибка: Файл не найден по пути {inputPath}");
                Console.WriteLine("Убедитесь, что:");
                Console.WriteLine("1. Папка C:\\DataSprint5\\ существует");
                Console.WriteLine("2. Файл InPutDataFileTask7V29.txt скопирован в эту папку");
            }
            else
            {
                string outputPath = ds.LoadDataAndSave(inputPath);

                Console.WriteLine($"Обработанный файл сохранен: {outputPath}");

                string originalText = File.ReadAllText(inputPath);
                string resultText = File.ReadAllText(outputPath);

                Console.WriteLine("\nИсходный текст:");
                Console.WriteLine(originalText);
                Console.WriteLine("\nТекст после удаления однозначных чисел:");
                Console.WriteLine(resultText);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

        Console.ReadKey();
    }
}