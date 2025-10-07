using System;
using Tyuiu.BiryukovAY.Sprint5.Task1.V15.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        string result = ds.SaveToFileTextData(-5, 5);
        Console.WriteLine($"Результат: {result}");

        string[] values = result.Split("\\n");
        Console.WriteLine("\nТаблица результатов:");
        Console.WriteLine("x\t\tF(x)");
        Console.WriteLine("------------------------");

        for (int i = 0, x = -5; x <= 5; x++, i++)
        {
            Console.WriteLine($"{x}\t\t{values[i]}");
        }

        Console.ReadKey();
    }
}