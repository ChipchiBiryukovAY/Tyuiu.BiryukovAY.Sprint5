using System;
using Tyuiu.BiryukovAY.Sprint5.Task2.V25.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int[,] array = new int[3, 3];

        Console.WriteLine("Введите элементы массива 3x3:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Элемент [{i},{j}]: ");
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nИсходный массив:");
        PrintArray(array);

        DataService ds = new DataService();
        string result = ds.SaveToFileTextData(array);

        Console.WriteLine("\nРезультат (нечетные заменены на 0):");
        Console.WriteLine(result);

        string filePath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "OutPutFileTask2.csv");
        Console.WriteLine($"\nРезультат сохранен в файл: {filePath}");

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    private static void PrintArray(int[,] array)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(array[i, j] + (j < 2 ? "; " : ""));
            }
            Console.WriteLine();
        }
}