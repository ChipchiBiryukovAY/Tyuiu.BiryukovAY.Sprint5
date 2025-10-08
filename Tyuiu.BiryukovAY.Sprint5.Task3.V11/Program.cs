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
        Console.WriteLine($"Base64 результат: {result}");

        double y = (4 - Math.Pow(x, 3)) / Math.Pow(x, 2);
        Console.WriteLine($"Числовое значение: {Math.Round(y, 3)}");

        string filePath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "OutPutFileTask3.bin");
        Console.WriteLine($"Файл сохранен: {filePath}");

        Console.ReadKey();

    }
}