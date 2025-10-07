using System;
using Tyuiu.BiryukovAY.Sprint5.Task1.V15.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        string result = ds.SaveToFileTextData(-5, 5);
        Console.WriteLine($"Результат:");
        Console.WriteLine(result);

        Console.ReadKey();
    }
}