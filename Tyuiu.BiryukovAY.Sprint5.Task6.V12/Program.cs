using System;
using Tyuiu.BiryukovAY.Sprint5.Task6.V12.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        string filePath = @"C:\DataSprint5\InPutDataFileTask6V12.txt";

        Console.WriteLine("Поиск количества удвоенных букв 'нн' в тексте");
        Console.WriteLine($"Путь к файлу: {filePath}");
        Console.WriteLine("==========================================");

        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Ошибка: Файл не найден по пути {filePath}");
                Console.WriteLine("Убедитесь, что:");
                Console.WriteLine("1. Папка C:\\DataSprint5\\ существует");
                Console.WriteLine("2. Файл InPutDataFileTask6V12.txt скопирован в эту папку");
            }
            else
            {
                int result = ds.LoadFromDataFile(filePath);

                Console.WriteLine($"Количество удвоенных букв 'нн': {result}");

                string fileContent = File.ReadAllText(filePath);
                int previewLength = Math.Min(100, fileContent.Length);
                Console.WriteLine($"\nПредпросмотр текста (первые {previewLength} символов):");
                Console.WriteLine($"\"{fileContent.Substring(0, previewLength)}\"");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

        Console.ReadKey();
    }
}