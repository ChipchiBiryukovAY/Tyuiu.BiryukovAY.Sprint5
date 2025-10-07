using System;
using Tyuiu.BiryukovAY.Sprint5.Task1.V15.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        string result = ds.SaveToFileTextData(-5, 5);
        Console.WriteLine($"Результат: {result}");

        string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";
        Console.WriteLine($"Файл создан: {path}");

        Console.WriteLine("\nСодержимое файла:");
        string[] fileContent = File.ReadAllLines(path);
        foreach (string line in fileContent)
        {
            Console.WriteLine(line);
        }

        Console.ReadKey();
    }
}