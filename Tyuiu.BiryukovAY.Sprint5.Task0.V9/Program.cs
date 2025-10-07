using System;
using Tyuiu.BiryukovAY.Sprint5.Task0.V9.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        string result = ds.SaveToFileTextData(3);
        Console.WriteLine($"Результат: {result}");

        string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
        Console.WriteLine($"Файл создан: {path}");

        Console.ReadKey();
    }
}