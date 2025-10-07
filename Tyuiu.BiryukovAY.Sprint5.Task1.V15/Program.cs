using System;
using Tyuiu.BiryukovAY.Sprint5.Task1.V15.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Табулирование функции F(x) = (cos(x) / (x - 0.4)) + sin(x) * 8x + 2");
        Console.WriteLine("Интервал: [-5; 5] с шагом 1\n");

        DataService service = new DataService();
        service.SaveToFileTextData(-5, 5);

        Console.ReadKey();
    }
}