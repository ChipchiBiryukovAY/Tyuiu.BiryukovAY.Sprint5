using System;
using Tyuiu.BiryukovAY.Sprint5.Task3.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int x = 3;
        string result = ds.SaveToFileTextData(x);

        Console.WriteLine($"Результат: {result}");
        Console.WriteLine($"При x = {x}: y = {-2.778}"); 

        string path = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "OutPutFileTask3.bin");
        Console.WriteLine($"Файл создан: {path}");

        Console.ReadKey();
    }
}