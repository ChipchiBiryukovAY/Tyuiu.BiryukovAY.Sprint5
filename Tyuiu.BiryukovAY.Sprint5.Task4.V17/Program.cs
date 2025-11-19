using System;
using Tyuiu.BiryukovAY.Sprint5.Task4.V17.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        string filePath = @"C:\DataSprint5\InPutDataFileTask4V0.txt";

        Console.WriteLine("Чтение значения X из файла и вычисление формулы");
        Console.WriteLine($"Путь к файлу: {filePath}");
        Console.WriteLine("Формула: y = sin(2 / (3x)) + x²");
        Console.WriteLine("==========================================");

        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Ошибка: Файл не найден по пути {filePath}");
                Console.WriteLine("Убедитесь, что папка C:\\DataSprint5\\ существует и файл скопирован");
            }
            else
            {
                double result = ds.LoadFromDataFile(filePath);

                string xValue = File.ReadAllText(filePath);
                Console.WriteLine($"Прочитано значение X: {xValue}");
                Console.WriteLine($"Результат вычисления: {result}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

        Console.ReadKey();
    }
}