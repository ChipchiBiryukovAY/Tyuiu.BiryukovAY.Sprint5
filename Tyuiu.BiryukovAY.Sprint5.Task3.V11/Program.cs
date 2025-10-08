using System;
using Tyuiu.BiryukovAY.Sprint5.Task3.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int x = 3;
        string result = ds.SaveToFileTextData(x);

        Console.WriteLine($"Выражение: y = (4 - x³) / x²");
        Console.WriteLine($"При x = {x}:");
        Console.WriteLine($"Результат: {result}");

        string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
        Console.WriteLine($"Файл сохранен: {filePath}");

        Console.ReadKey();

    }
}