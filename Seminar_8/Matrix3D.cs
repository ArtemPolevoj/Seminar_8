using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_8
{
    internal class Matrix3D
    {
        public static int[,,] GetMatirx3DInts()
        {
            int row = Value.getInt("Введите количество строк массива:");
            if (row <= 0)
            {
                Console.WriteLine("Количество строк не может быть меньше или равно нулю");
                row = Value.getInt("Введите количество строк массива");
            }
            int columns = Value.getInt("Введите количество столбцов массива:");
            if (columns <= 0)
            {
                Console.WriteLine("Количество столбцов не может быть меньше или равно нулю");
                columns = Value.getInt("Введите количество столбцов массива");
            }
            int depth = Value.getInt("Введите глубину массива");
            if (depth <= 0)
            {
                Console.WriteLine("Глубину массива не может быть меньше или равно нулю");
                depth = Value.getInt("Введите глубину массива");
            }
            return new int[row, columns, depth];
        }

        public static int[,,] FillMatrixRandomInts(int[,,] matrixInts)
        {
            int min = Value.getInt("Введите минимальное значение массива");
            int max = Value.getInt("Введите максимальное значение массива");
            Random random = new Random();
            for (int i = 0; i < matrixInts.GetLength(0); i++)
            {
                for (int j = 0; j < matrixInts.GetLength(1); j++)
                {
                    for (int k = 0; k < matrixInts.GetLength(1); k++)
                    {
                        matrixInts[i, j, k] = random.Next(min, max);
                    }
                }
            }
            return matrixInts;
        }

        public static void GetValueOfIndex(int[,,] matrixInts)
        {
            for (int i = 0; i < matrixInts.GetLength(0); i++)
            {
                for (int j = 0; j < matrixInts.GetLength(1); j++)
                {
                    for (int k = 0; k < matrixInts.GetLength(2); k++)
                    {
                        Console.Write($"{matrixInts[j, k, i]}({j},{k},{i})  ");
                    }
                    Console.WriteLine();
                }

            }

        }
    }
}
