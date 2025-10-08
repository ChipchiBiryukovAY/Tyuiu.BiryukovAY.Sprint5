using System;
using Tyuiu.BiryukovAY.Sprint5.Task3.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int x = 3;
        byte[] result = ds.SaveToFileTextData(x);
        string base64Result = Convert.ToBase64String(result);

        Console.WriteLine($"Base64 результат: {base64Result}");
        Console.WriteLine($"При x = {x}: y = {-2.778}");

        string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
        Console.WriteLine($"Файл создан: {path}");

        Console.ReadKey();
    }
}