using System;
using Tyuiu.BiryukovAY.Sprint5.Task3.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int x = 3;
        byte[] resultBytes = ds.SaveToFileTextData(x);

        string base64Result = Convert.ToBase64String(resultBytes);
        Console.WriteLine($"Результат в base64: {base64Result}");

        double y = (4 - Math.Pow(x, 3)) / Math.Pow(x, 2);
        Console.WriteLine($"Значение при x = {x}: {Math.Round(y, 3)}");

        string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
        Console.WriteLine($"Файл создан: {path}");

        Console.ReadKey();
    }
}