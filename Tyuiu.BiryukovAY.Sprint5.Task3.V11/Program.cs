using System;
using Tyuiu.BiryukovAY.Sprint5.Task3.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Вычисление выражения y = (4 - x³) / x²");

        int x = 3;
        byte[] result = SaveToFileTextData(x);
        string base64Result = Convert.ToBase64String(result);

        Console.WriteLine($"Base64 результат: {base64Result}");
        Console.WriteLine($"При x = {x}: y = {-2.778}");

        Console.ReadKey();
    }
}