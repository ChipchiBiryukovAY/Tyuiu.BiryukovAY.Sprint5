using System;
using Tyuiu.BiryukovAY.Sprint5.Task3.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int x = 3;
        string filePath = ds.SaveToFileTextData(x);

        double y = (4 - Math.Pow(x, 3)) / Math.Pow(x, 2);
        double roundedY = Math.Round(y, 3);

        Console.WriteLine($"Выражение: y = (4 - x³) / x²");
        Console.WriteLine($"При x = {x}:");
        Console.WriteLine($"Результат: {roundedY}");
        Console.WriteLine($"Путь к файлу: {filePath}");

        byte[] fileBytes = File.ReadAllBytes(filePath);
        Console.WriteLine($"Размер файла: {fileBytes.Length} байт");
        Console.WriteLine($"Бинарное представление: {BitConverter.ToString(fileBytes)}");

        Console.ReadKey();

    }
}