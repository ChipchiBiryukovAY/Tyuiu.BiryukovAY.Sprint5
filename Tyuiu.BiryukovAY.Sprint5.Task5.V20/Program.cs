using System;
using Tyuiu.BiryukovAY.Sprint5.Task5.V20.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        string filePath = @"C:\DataSprint5\InPutDataFileTask5V20.txt";

        Console.WriteLine("Поиск среднего значения целых чисел в диапазоне [-10, 10]");
        Console.WriteLine($"Путь к файлу: {filePath}");
        Console.WriteLine("==========================================");

        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Ошибка: Файл не найден по пути {filePath}");
                Console.WriteLine("Убедитесь, что:");
                Console.WriteLine("1. Папка C:\\DataSprint5\\ существует");
                Console.WriteLine("2. Файл InPutDataFileTask5V20.txt скопирован в эту папку");
            }
            else
            {
                double result = ds.LoadFromDataFile(filePath);

                Console.WriteLine($"Среднее значение целых чисел в диапазоне [-10, 10]: {result:F3}");

                Console.WriteLine("\nСодержимое файла:");
                string[] fileContent = File.ReadAllLines(filePath);
                foreach (string line in fileContent)
                {
                    Console.WriteLine($"  {line}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

        Console.ReadKey();
    }
}