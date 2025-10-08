using System;
using Tyuiu.BiryukovAY.Sprint5.Task3.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int x = 3;
        string result = ds.SaveToFileTextData(x);
        Console.WriteLine($"Результат при x = {x}: {result}");

        string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
        Console.WriteLine($"Файл создан: {path}");

        // Чтение и вывод содержимого бинарного файла
        byte[] fileBytes = File.ReadAllBytes(path);
        Console.WriteLine($"Бинарное содержимое: {BitConverter.ToString(fileBytes)}");

        Console.ReadKey();
    }
}