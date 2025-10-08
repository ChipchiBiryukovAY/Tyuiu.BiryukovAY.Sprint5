using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.BiryukovAY.Sprint5.Task2.V25.Lib
{
    public class DataService : ISprint5Task2V25
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] resultArray = (int[,])matrix.Clone();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (resultArray[i, j] % 2 != 0) 
                    {
                        resultArray[i, j] = 0;
                    }
                }
            }

            StringBuilder resultBuilder = new StringBuilder();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    resultBuilder.Append(resultArray[i, j]);
                    if (j < cols - 1)
                        resultBuilder.Append(";");
                }
                if (i < rows - 1)
                    resultBuilder.Append("\n");
            }

            string fileName = "OutPutFileTask2.csv";
            string tempPath = Path.Combine(Path.GetTempPath(), fileName);

            using (StreamWriter writer = new StreamWriter(tempPath, false, Encoding.UTF8))
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        writer.Write(resultArray[i, j]);
                        if (j < cols - 1)
                            writer.Write(";");
                    }
                    writer.WriteLine();
                }
            }

            return resultBuilder.ToString();
        }
    }
}
